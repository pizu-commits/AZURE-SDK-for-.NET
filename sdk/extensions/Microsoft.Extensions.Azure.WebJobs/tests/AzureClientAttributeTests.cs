﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using NUnit.Framework;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Extensions.WebJobs;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host.TestCommon;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Microsoft.Extensions.Azure.WebJobs.Tests
{
    public class AzureClientAttributeTests : RecordedTestBase<WebJobsTestEnvironment>
    {
        public AzureClientAttributeTests(bool isAsync) : base(isAsync)
        {
            Matcher = new RecordMatcher()
            {
                VolatileQueryParameters =
                {
                    // Ignore KeyVault client API Version when matching
                    "api-version"
                }
            };
        }

        [RecordedTest]
        public async Task CanInjectKeyVaultClient()
        {
            var host = new HostBuilder()
                .ConfigureServices(services => services.AddAzureClients(builder => builder
                    .ConfigureDefaults(options => Recording.InstrumentClientOptions(options))
                    .UseCredential(TestEnvironment.Credential)))
                .ConfigureAppConfiguration(config =>
                {
                    config.AddInMemoryCollection(new Dictionary<string, string>
                    {
                        { "AzureWebJobs:Connection:vaultUri", TestEnvironment.KeyVaultUrl }
                    });
                })
                .ConfigureDefaultTestHost<FunctionWithAzureClient>(builder =>
                {
                    builder.AddAzureClients();
                }).Build();

            var jobHost = host.GetJobHost<FunctionWithAzureClient>();
            await jobHost.CallAsync(nameof(FunctionWithAzureClient.Run));
        }

        public class FunctionWithAzureClient
        {
            public async Task Run([AzureClient("Connection")] SecretClient keyClient)
            {
                await keyClient.SetSecretAsync("TestSecret", "Secret value");
            }
        }
    }
}
