// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Temp.Batch.Samples
{
    public class Samples_AccountClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSupportedImages()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            foreach (var item in client.GetSupportedImages("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("nodeAgentSKUId").ToString());
                Console.WriteLine(result.GetProperty("imageReference").ToString());
                Console.WriteLine(result.GetProperty("osType").ToString());
                Console.WriteLine(result.GetProperty("verificationType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSupportedImages_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            foreach (var item in client.GetSupportedImages("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("nodeAgentSKUId").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("publisher").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("offer").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("sku").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("version").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("virtualMachineImageId").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("exactVersion").ToString());
                Console.WriteLine(result.GetProperty("osType").ToString());
                Console.WriteLine(result.GetProperty("capabilities")[0].ToString());
                Console.WriteLine(result.GetProperty("batchSupportEndOfLife").ToString());
                Console.WriteLine(result.GetProperty("verificationType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSupportedImages_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            await foreach (var item in client.GetSupportedImagesAsync("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("nodeAgentSKUId").ToString());
                Console.WriteLine(result.GetProperty("imageReference").ToString());
                Console.WriteLine(result.GetProperty("osType").ToString());
                Console.WriteLine(result.GetProperty("verificationType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSupportedImages_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            await foreach (var item in client.GetSupportedImagesAsync("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("nodeAgentSKUId").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("publisher").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("offer").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("sku").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("version").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("virtualMachineImageId").ToString());
                Console.WriteLine(result.GetProperty("imageReference").GetProperty("exactVersion").ToString());
                Console.WriteLine(result.GetProperty("osType").ToString());
                Console.WriteLine(result.GetProperty("capabilities")[0].ToString());
                Console.WriteLine(result.GetProperty("batchSupportEndOfLife").ToString());
                Console.WriteLine(result.GetProperty("verificationType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPoolNodeCounts()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            foreach (var item in client.GetPoolNodeCounts("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("poolId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPoolNodeCounts_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            foreach (var item in client.GetPoolNodeCounts("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("poolId").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("creating").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("idle").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("offline").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("preempted").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("rebooting").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("reimaging").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("running").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("starting").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("startTaskFailed").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("leavingPool").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("unknown").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("unusable").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("waitingForStartTask").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("total").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("creating").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("idle").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("offline").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("preempted").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("rebooting").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("reimaging").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("running").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("starting").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("startTaskFailed").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("leavingPool").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("unknown").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("unusable").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("waitingForStartTask").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("total").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPoolNodeCounts_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            await foreach (var item in client.GetPoolNodeCountsAsync("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("poolId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPoolNodeCounts_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new AccountClient("<batchUrl>", credential);

            await foreach (var item in client.GetPoolNodeCountsAsync("<filter>", 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("poolId").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("creating").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("idle").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("offline").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("preempted").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("rebooting").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("reimaging").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("running").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("starting").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("startTaskFailed").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("leavingPool").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("unknown").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("unusable").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("waitingForStartTask").ToString());
                Console.WriteLine(result.GetProperty("dedicated").GetProperty("total").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("creating").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("idle").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("offline").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("preempted").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("rebooting").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("reimaging").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("running").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("starting").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("startTaskFailed").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("leavingPool").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("unknown").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("unusable").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("waitingForStartTask").ToString());
                Console.WriteLine(result.GetProperty("lowPriority").GetProperty("total").ToString());
            }
        }
    }
}
