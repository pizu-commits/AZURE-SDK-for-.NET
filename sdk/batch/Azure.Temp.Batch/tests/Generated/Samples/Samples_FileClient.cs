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
    public class Samples_FileClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteFromTask()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.DeleteFromTask("<jobId>", "<taskId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteFromTask_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.DeleteFromTask("<jobId>", "<taskId>", "<filePath>", true, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteFromTask_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.DeleteFromTaskAsync("<jobId>", "<taskId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteFromTask_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.DeleteFromTaskAsync("<jobId>", "<taskId>", "<filePath>", true, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromTask()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetFromTask("<jobId>", "<taskId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromTask_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetFromTask("<jobId>", "<taskId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromTask_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetFromTaskAsync("<jobId>", "<taskId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromTask_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetFromTaskAsync("<jobId>", "<taskId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPropertiesFromTask()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetPropertiesFromTask("<jobId>", "<taskId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPropertiesFromTask_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetPropertiesFromTask("<jobId>", "<taskId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, null);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPropertiesFromTask_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetPropertiesFromTaskAsync("<jobId>", "<taskId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPropertiesFromTask_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetPropertiesFromTaskAsync("<jobId>", "<taskId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, null);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteFromComputeNode()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.DeleteFromComputeNode("<poolId>", "<nodeId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteFromComputeNode_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.DeleteFromComputeNode("<poolId>", "<nodeId>", "<filePath>", true, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteFromComputeNode_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.DeleteFromComputeNodeAsync("<poolId>", "<nodeId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteFromComputeNode_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.DeleteFromComputeNodeAsync("<poolId>", "<nodeId>", "<filePath>", true, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromComputeNode()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetFromComputeNode("<poolId>", "<nodeId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromComputeNode_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetFromComputeNode("<poolId>", "<nodeId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromComputeNode_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetFromComputeNodeAsync("<poolId>", "<nodeId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromComputeNode_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetFromComputeNodeAsync("<poolId>", "<nodeId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, "<ocpRange>", null, new RequestContext());
            if (response.ContentStream != null)
            {
                using (Stream outFileStream = File.OpenWrite("<filePath>"))
                {
                    response.ContentStream.CopyTo(outFileStream);
                }
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPropertiesFromComputeNode()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetPropertiesFromComputeNode("<poolId>", "<nodeId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPropertiesFromComputeNode_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = client.GetPropertiesFromComputeNode("<poolId>", "<nodeId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, null);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPropertiesFromComputeNode_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetPropertiesFromComputeNodeAsync("<poolId>", "<nodeId>", "<filePath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPropertiesFromComputeNode_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            Response response = await client.GetPropertiesFromComputeNodeAsync("<poolId>", "<nodeId>", "<filePath>", 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, null);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromTasks()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            foreach (var item in client.GetFromTasks("<jobId>", "<taskId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromTasks_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            foreach (var item in client.GetFromTasks("<jobId>", "<taskId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("url").ToString());
                Console.WriteLine(result.GetProperty("isDirectory").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("creationTime").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("lastModified").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentLength").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentType").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("fileMode").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromTasks_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            await foreach (var item in client.GetFromTasksAsync("<jobId>", "<taskId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromTasks_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            await foreach (var item in client.GetFromTasksAsync("<jobId>", "<taskId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("url").ToString());
                Console.WriteLine(result.GetProperty("isDirectory").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("creationTime").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("lastModified").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentLength").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentType").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("fileMode").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromComputeNodes()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            foreach (var item in client.GetFromComputeNodes("<poolId>", "<nodeId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetFromComputeNodes_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            foreach (var item in client.GetFromComputeNodes("<poolId>", "<nodeId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("url").ToString());
                Console.WriteLine(result.GetProperty("isDirectory").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("creationTime").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("lastModified").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentLength").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentType").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("fileMode").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromComputeNodes_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            await foreach (var item in client.GetFromComputeNodesAsync("<poolId>", "<nodeId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetFromComputeNodes_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FileClient("<batchUrl>", credential);

            await foreach (var item in client.GetFromComputeNodesAsync("<poolId>", "<nodeId>", "<filter>", true, 1234, 1234, Guid.NewGuid(), true, DateTimeOffset.UtcNow, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("url").ToString());
                Console.WriteLine(result.GetProperty("isDirectory").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("creationTime").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("lastModified").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentLength").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("contentType").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("fileMode").ToString());
            }
        }
    }
}
