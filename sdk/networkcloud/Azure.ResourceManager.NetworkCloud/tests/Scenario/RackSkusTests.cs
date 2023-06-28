// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.ResourceManager.NetworkCloud.Tests.ScenarioTests
{
    public class RackSkusTests : NetworkCloudManagementTestBase
    {
        public RackSkusTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode) {}
        public RackSkusTests(bool isAsync) : base(isAsync) {}

        [Test]
        public async Task RackSkus()
        {
            string subscriptionId = TestEnvironment.SubscriptionId;

            // List by Subscription
            var listBySubscription = new List<RackSku>();
            await foreach (var item in SubscriptionResource.GetRackSkusBySubscriptionAsync())
            {
                listBySubscription.Add(item);
            }
            Assert.IsNotEmpty(listBySubscription);

            var rackSkuName = "VNearEdge1_Compute_DellR750_12C2M"; //listBySubscription[0].Data.Name;

            // Get
            RackSku result = await SubscriptionResource.GetRackSkuAsync(rackSkuName);
           Assert.AreEqual(rackSkuName, result.Name);
        }
    }
}
