// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Messaging.ServiceBus.Tests;
using Microsoft.Azure.WebJobs.Host.EndToEndTests;
using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Azure.WebJobs.Host.TestCommon;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Tests
{
    internal class ScaleHostEndToEndTests : WebJobsServiceBusTestBase
    {
        private const string Function1Name = "Function1";
        private const string Function2Name = "Function2";

        public ScaleHostEndToEndTests() : base(isSession: false)
        {
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public async Task ScaleHostEndToEndTest(bool tbsEnabled)
        {
            string hostJson =
            @"{
                ""azureWebJobs"" : {
                    ""extensions"": {
                        ""serviceBus"": {
                            ""maxConcurrentCalls"" :  1
                        }
                    }
                }   
            }";

            // Function1Name uses connection string
            // Function2Name uses AzureComponentFactory - simulating managed identity scenario in ScaleController
            string triggers = $@"{{
""triggers"": [
    {{
        ""name"": ""myQueueItem"",
        ""type"": ""serviceBusTrigger"",
        ""direction"": ""in"",
        ""queueName"": ""{FirstQueueScope.QueueName}"",
        ""functionName"": ""{Function1Name}""
    }},
    {{
        ""name"": ""myQueueItem"",
        ""type"": ""serviceBusTrigger"",
        ""direction"": ""in"",
        ""queueName"": ""{SecondQueueScope.QueueName}"",
        ""connection"": ""ServiceBusConnection2"",
        ""functionName"": ""{Function2Name}""
    }}
 ]}}";

            IHost host = new HostBuilder().ConfigureServices(services => services.AddAzureClientsCore()).Build();
            AzureComponentFactory defaultAzureComponentFactory = host.Services.GetService<AzureComponentFactory>();
            AzureComponentFactoryWrapper factoryWrapper = new AzureComponentFactoryWrapper(defaultAzureComponentFactory, ServiceBusTestEnvironment.Instance.Credential);

            string hostId = "test-host";
            var loggerProvider = new TestLoggerProvider();

            IHostBuilder hostBuilder = new HostBuilder();
            hostBuilder.ConfigureLogging(configure =>
            {
                configure.SetMinimumLevel(LogLevel.Debug);
                configure.AddProvider(loggerProvider);
            });
            hostBuilder.ConfigureAppConfiguration((hostBuilderContext, config) =>
            {
                // Adding host.json here
                config.AddJsonStream(new MemoryStream(Encoding.UTF8.GetBytes(hostJson)));

                var settings = new Dictionary<string, string>();
                settings.Add("AzureWebJobsServiceBus", ServiceBusTestEnvironment.Instance.ServiceBusConnectionString);
                settings.Add("ServiceBusConnection2:fullyQualifiedNamespace", $"{SecondQueueScope.NamespaceName}.servicebus.windows.net");
                settings.Add("HostingConfig:Microsoft.Azure.WebJobs.Extensions.ServiceBus", "1");

                // Adding app setting
                config.AddInMemoryCollection(settings);
            })
            .ConfigureServices(services =>
            {
                services.AddAzureClientsCore();
                services.AddAzureStorageScaleServices();

                services.AddSingleton<IScaleMetricsRepository, TestScaleMetricsRepository>();
            })
            .ConfigureWebJobsScale((context, builder) =>
            {
                builder.AddServiceBus();
                builder.UseHostId(hostId);

                foreach (var jtoken in JObject.Parse(triggers)["triggers"])
                {
                    TriggerMetadata metadata = new TriggerMetadata(jtoken as JObject);
                    if (metadata.FunctionName == Function2Name)
                    {
                        metadata.Properties[nameof(AzureComponentFactory)] = factoryWrapper;
                    }
                    builder.AddServiceBusScaleForTrigger(metadata);
                }
            },
            scaleOptions =>
            {
                scaleOptions.IsTargetScalingEnabled = tbsEnabled;
                scaleOptions.MetricsPurgeEnabled = false;
                scaleOptions.ScaleMetricsMaxAge = TimeSpan.FromMinutes(4);
                scaleOptions.IsRuntimeScalingEnabled = true;
            });

            IHost scaleHost = hostBuilder.Build();
            await scaleHost.StartAsync();

            // add some messages to the queue
            await WriteQueueMessage("test");
            await WriteQueueMessage("test");
            await WriteQueueMessage("test", queueName: SecondQueueScope.QueueName);
            await WriteQueueMessage("test", queueName: SecondQueueScope.QueueName);
            await WriteQueueMessage("test", queueName: SecondQueueScope.QueueName);

            await TestHelpers.Await(async () =>
            {
                ScaleManager scaleManager = scaleHost.Services.GetService<ScaleManager>();

                var scaleStatus = await scaleManager.GetScaleStatusAsync(new ScaleStatusContext());

                bool scaledOut = false;
                if (!tbsEnabled)
                {
                    scaledOut = scaleStatus.Vote == ScaleVote.ScaleOut && scaleStatus.TargetWorkerCount == null
                     && scaleStatus.FunctionScaleStatuses[Function1Name].Vote == ScaleVote.ScaleOut
                     && scaleStatus.FunctionScaleStatuses[Function2Name].Vote == ScaleVote.ScaleOut;

                    if (scaledOut)
                    {
                        var logMessages = loggerProvider.GetAllLogMessages().Select(p => p.FormattedMessage).ToArray();
                        Assert.Contains("2 scale monitors to sample", logMessages);
                    }
                }
                else
                {
                    scaledOut = scaleStatus.Vote == ScaleVote.ScaleOut && scaleStatus.TargetWorkerCount == 3
                     && scaleStatus.FunctionTargetScalerResults[Function1Name].TargetWorkerCount == 2
                     && scaleStatus.FunctionTargetScalerResults[Function2Name].TargetWorkerCount == 3;

                    if (scaledOut)
                    {
                        var logMessages = loggerProvider.GetAllLogMessages().Select(p => p.FormattedMessage).ToArray();
                        Assert.Contains("2 target scalers to sample", logMessages);
                    }
                }

                if (scaledOut)
                {
                    var logMessages = loggerProvider.GetAllLogMessages().Select(p => p.FormattedMessage).ToArray();
                    Assert.IsNotEmpty(logMessages.Where(x => x.StartsWith("Runtime scale monitoring is enabled.")));
                    if (!tbsEnabled)
                    {
                        Assert.Contains("Scaling out based on votes", logMessages);
                    }
                }

                return scaledOut;
            });
        }

        internal class TestScaleMetricsRepository : IScaleMetricsRepository
        {
            private Dictionary<IScaleMonitor, List<ScaleMetrics>> _cache;

            public TestScaleMetricsRepository()
            {
                _cache = new Dictionary<IScaleMonitor, List<ScaleMetrics>>();
            }

            public Task WriteMetricsAsync(IDictionary<IScaleMonitor, ScaleMetrics> monitorMetrics)
            {
                foreach (var kvp in monitorMetrics)
                {
                    if (_cache.TryGetValue(kvp.Key, out var value))
                    {
                        value.Add(kvp.Value);
                    }
                    else
                    {
                        _cache[kvp.Key] = new List<ScaleMetrics> { kvp.Value };
                    }
                }

                return Task.CompletedTask;
            }

            public Task<IDictionary<IScaleMonitor, IList<ScaleMetrics>>> ReadMetricsAsync(IEnumerable<IScaleMonitor> monitors)
            {
                IDictionary<IScaleMonitor, IList<ScaleMetrics>> result = new Dictionary<IScaleMonitor, IList<ScaleMetrics>>();

                foreach (var monitor in monitors)
                {
                    if (_cache.TryGetValue(monitor, out var value))
                    {
                        result.Add(monitor, value);
                    }
                    else
                    {
                        result.Add(monitor, new List<ScaleMetrics>());
                    }
                }

                return Task.FromResult(result);
            }
        }

        internal class AzureComponentFactoryWrapper : AzureComponentFactory
        {
            private readonly AzureComponentFactory _factory;
            private readonly TokenCredential _tokenCredential;

            public AzureComponentFactoryWrapper(AzureComponentFactory factory, TokenCredential tokenCredential)
            {
                _factory = factory;
                _tokenCredential = tokenCredential;
            }

            public override TokenCredential CreateTokenCredential(IConfiguration configuration)
            {
                return _tokenCredential != null ? _tokenCredential : _factory.CreateTokenCredential(configuration);
            }

            public override object CreateClientOptions(Type optionsType, object serviceVersion, IConfiguration configuration)
                => _factory.CreateClientOptions(optionsType, serviceVersion, configuration);

            public override object CreateClient(Type clientType, IConfiguration configuration, TokenCredential credential, object clientOptions)
                => _factory.CreateClient(clientType, configuration, credential, clientOptions);
        }
    }
}
