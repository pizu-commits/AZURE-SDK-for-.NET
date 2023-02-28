// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Developer.DevCenter.Tests
{
    public class EnvironmentCreateTests : RecordedTestBase<DevCenterClientTestEnvironment>
    {
        public EnvironmentCreateTests(bool isAsync) : base(isAsync)
        {
        }

        private EnvironmentsClient GetEnvironmentsClient() =>
            InstrumentClient(new EnvironmentsClient(
                TestEnvironment.Endpoint,
                TestEnvironment.Credential,
                InstrumentClientOptions(new DevCenterClientOptions())));

        [RecordedTest]
        [PlaybackOnly("Environment creation is unstable due to service issues currently under investigation")]
        public async Task EnvironmentCreationSucceeds()
        {
            EnvironmentsClient environmentsClient = GetEnvironmentsClient();
            string environmentDefinitionName = null;

            await foreach (BinaryData environmentDefinitionData in environmentsClient.GetEnvironmentDefinitionsByProjectAsync(TestEnvironment.ProjectName))
            {
                JsonElement environmentDefinition = JsonDocument.Parse(environmentDefinitionData.ToStream()).RootElement;
                environmentDefinitionName = environmentDefinition.GetProperty("name").ToString();
            }

            var content = new
            {
                catalogName = TestEnvironment.CatalogName,
                environmentDefinitionName = environmentDefinitionName,
                environmentType = TestEnvironment.EnvironmentTypeName,
            };

            Operation<BinaryData> environmentCreateOperation = await environmentsClient.CreateOrReplaceEnvironmentAsync(WaitUntil.Completed, TestEnvironment.ProjectName, "DevTestEnv", RequestContent.Create(content));
            BinaryData environmentData = await environmentCreateOperation.WaitForCompletionAsync();
            JsonElement environment = JsonDocument.Parse(environmentData.ToStream()).RootElement;
            Console.WriteLine($"Started provisioning for environment with status {environment.GetProperty("provisioningState")}.");
            Console.WriteLine($"Completed provisioning for environment with status {environment.GetProperty("provisioningState")}.");

            Assert.IsTrue(environment.GetProperty("provisioningState").ToString().Equals("Succeeded", StringComparison.OrdinalIgnoreCase));

            // Delete the dev box
            Operation environmentDeleteOperation = await environmentsClient.DeleteEnvironmentAsync(WaitUntil.Started,TestEnvironment.ProjectName, "DevTestEnv");
            await environmentDeleteOperation.WaitForCompletionResponseAsync();
            Console.WriteLine($"Completed environment deletion.");
        }

        #region Helpers

        private static BinaryData GetContentFromResponse(Response r)
        {
            // Workaround azure/azure-sdk-for-net#21048, which prevents .Content from working when dealing with responses
            // from the playback system.

            MemoryStream ms = new MemoryStream();
            r.ContentStream.CopyTo(ms);
            return new BinaryData(ms.ToArray());
        }
        #endregion
    }
}
