// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Azure.Messaging.ServiceBus;
using Azure.Messaging.ServiceBus.Administration;
using Microsoft.Azure.WebJobs.Extensions.ServiceBus.Config;
using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.Azure.WebJobs.ServiceBus.Listeners;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Listeners
{
    internal class ServiceBusScalerProvider : IScaleMonitorProvider, ITargetScalerProvider
    {
        private readonly IConfiguration _configuration;
        private readonly MessagingProvider _messagingProvider;
        private readonly IOptions<ServiceBusOptions> _options;
        private readonly AzureEventSourceLogForwarder _logForwarder;
        private readonly TriggerMetadata _triggerMetadata;
        private readonly ILoggerFactory _loggerFactory;
        private readonly ServiceBusMetadata _serviceBusMetadata;
        private readonly AzureComponentFactory _azureComponentFactory;

        public ServiceBusScalerProvider(IServiceProvider serviceProvider, TriggerMetadata triggerMetadata)
        {
            _configuration = serviceProvider.GetService<IConfiguration>();

            if ((triggerMetadata.Properties != null) && (triggerMetadata.Properties.TryGetValue(nameof(AzureComponentFactory), out object value)))
            {
                _azureComponentFactory = value as AzureComponentFactory;
            }
            else
            {
                _azureComponentFactory = serviceProvider.GetService<AzureComponentFactory>();
            }

            _messagingProvider = serviceProvider.GetService<MessagingProvider>();
            _triggerMetadata = triggerMetadata;
            _logForwarder = serviceProvider.GetService<AzureEventSourceLogForwarder>();
            _options = serviceProvider.GetService<IOptions<ServiceBusOptions>>();
            _loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            _serviceBusMetadata = JsonConvert.DeserializeObject<ServiceBusMetadata>(_triggerMetadata.Metadata.ToString());
        }

        public IScaleMonitor GetMonitor()
        {
            (ServiceBusAdministrationClient adminClient, ServiceBusReceiver receiver) = CreateParameters(_configuration, _serviceBusMetadata, _azureComponentFactory);

            return new ServiceBusScaleMonitor(
                _triggerMetadata.FunctionName,
                receiver.EntityPath,
                !string.IsNullOrEmpty(_serviceBusMetadata.QueueName) ? ServiceBusEntityType.Queue : ServiceBusEntityType.Topic,
                new Lazy<ServiceBusReceiver>(() => receiver),
                new Lazy<ServiceBusAdministrationClient>(() => adminClient),
                _loggerFactory);
        }

        public ITargetScaler GetTargetScaler()
        {
            (ServiceBusAdministrationClient adminClient, ServiceBusReceiver receiver) = CreateParameters(_configuration, _serviceBusMetadata, _azureComponentFactory);

            return new ServiceBusTargetScaler(
                _triggerMetadata.FunctionName,
                receiver.EntityPath,
                receiver.EntityPath.Contains("//") ? ServiceBusEntityType.Topic : ServiceBusEntityType.Queue,
                new Lazy<ServiceBusReceiver>(() => receiver),
                new Lazy<ServiceBusAdministrationClient>(() => adminClient),
                _options.Value,
                _serviceBusMetadata.IsSessionsEnabled,
                !string.Equals(_serviceBusMetadata.Cardinality, "many"),
                _loggerFactory);
        }

        private (ServiceBusAdministrationClient AdminClient, ServiceBusReceiver Receiver) CreateParameters(IConfiguration configuration, ServiceBusMetadata serviceBusMetadata, AzureComponentFactory azureComponentFactory)
        {
            ServiceBusClientFactory factory = new ServiceBusClientFactory(configuration, azureComponentFactory, _messagingProvider, _logForwarder, _options);

            ServiceBusAdministrationClient adminClient = factory.CreateAdministrationClient(serviceBusMetadata.Connection);
            ServiceBusClient client = factory.CreateClientFromSetting(serviceBusMetadata.Connection);
            ServiceBusReceiver receiver = !string.IsNullOrEmpty(serviceBusMetadata.QueueName) ? client.CreateReceiver(serviceBusMetadata.QueueName)
                : client.CreateReceiver(serviceBusMetadata.TopicName, serviceBusMetadata.SubscriptionName);

            return (AdminClient: adminClient, Receiver: receiver);
        }

        internal class ServiceBusMetadata
        {
            [JsonProperty]
            public string Type { get; set; }

            [JsonProperty]
            public string Connection { get; set; }

            [JsonProperty]
            public string QueueName { get; set; }

            [JsonProperty]
            public string TopicName { get; set; }

            [JsonProperty]
            public string SubscriptionName { get; set; }

            [JsonProperty]
            public bool IsSessionsEnabled { get; set; }

            [JsonProperty]
            public string Cardinality { get; set; }
        }
    }
}
