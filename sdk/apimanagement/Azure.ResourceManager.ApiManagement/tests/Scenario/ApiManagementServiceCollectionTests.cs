﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Network;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Tests
{
    public class ApiManagementServiceCollectionTests : ApiManagementManagementTestBase
    {
        public ApiManagementServiceCollectionTests(bool isAsync)
                    : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        private VirtualNetworkCollection VNetCollection { get; set; }

        private async Task<ApiManagementServiceCollection> GetApiManagementServiceCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            VNetCollection = resourceGroup.GetVirtualNetworks();
            return resourceGroup.GetApiManagementServices();
        }

        [Test]
        public async Task CRUD()
        {
            var collection = await GetApiManagementServiceCollectionAsync();
            var apiName = Recording.GenerateAssetName("testapi-");
            var data = new ApiManagementServiceData(AzureLocation.EastUS, new ApiManagementServiceSkuProperties(ApiManagementServiceSkuType.Developer, 1), "Sample@Sample.com", "sample")
            {
                Identity = new ApiManagementServiceIdentity(ApimIdentityType.SystemAssigned)
            };
            var apiManagementService = (await collection.CreateOrUpdateAsync(WaitUntil.Completed, apiName, data)).Value;
            Assert.AreEqual(apiManagementService.Data.Name, apiName);

            // TagOperation
            await apiManagementService.AddTagAsync("testkey", "testvalue");
            apiManagementService = (await apiManagementService.GetAsync()).Value;
            Assert.AreEqual(apiManagementService.Data.Tags.FirstOrDefault().Key, "testkey");
            Assert.AreEqual(apiManagementService.Data.Tags.FirstOrDefault().Value, "testvalue");

            var tags = new Dictionary<string, string>() { { "newkey", "newvalue" } };
            await apiManagementService.SetTagsAsync(tags);
            apiManagementService = (await apiManagementService.GetAsync()).Value;
            Assert.AreEqual(apiManagementService.Data.Tags.FirstOrDefault().Key, "newkey");
            Assert.AreEqual(apiManagementService.Data.Tags.FirstOrDefault().Value, "newvalue");

            await apiManagementService.RemoveTagAsync("newkey");
            apiManagementService = (await apiManagementService.GetAsync()).Value;
            Assert.AreEqual(apiManagementService.Data.Tags.Count, 0);

            // Update
            var patch = new ApiManagementServicePatch() { Tags = { { "newkey", "newvalue" } } };
            var updated = await apiManagementService.UpdateAsync(WaitUntil.Completed, patch);
            Assert.AreEqual(updated.Value.Data.Tags.FirstOrDefault().Key, "newkey");

            // Delete
            await apiManagementService.DeleteAsync(WaitUntil.Completed);
        }

        [Test]
        public async Task Get()
        {
            // Please create the resource first.
            var resourceGroup = await DefaultSubscription.GetResourceGroups().GetAsync("sdktestrg");
            var collection = resourceGroup.Value.GetApiManagementServices();
            var apiManagementService = (await collection.GetAsync("sdktestapi")).Value;
            Assert.NotNull(apiManagementService.Data.Name);
        }

        [Test]
        public async Task GetAll()
        {
            // Please create the resource first.
            var resourceGroup = await DefaultSubscription.GetResourceGroups().GetAsync("sdktestrg");
            var collection = resourceGroup.Value.GetApiManagementServices();
            var apiManagementServices = await collection.GetAllAsync().ToEnumerableAsync();
            Assert.GreaterOrEqual(apiManagementServices.Count, 1);
        }

        [Test]
        public async Task Exists()
        {
            // Please create the resource first.
            var resourceGroup = await DefaultSubscription.GetResourceGroups().GetAsync("sdktestrg");
            var collection = resourceGroup.Value.GetApiManagementServices();
            var apiManagementServiceTrue = await collection.ExistsAsync("sdktestapi");
            var apiManagementServiceFalse = await collection.ExistsAsync("foo");
            Assert.IsTrue(apiManagementServiceTrue);
            Assert.IsFalse(apiManagementServiceFalse);
        }
    }
}
