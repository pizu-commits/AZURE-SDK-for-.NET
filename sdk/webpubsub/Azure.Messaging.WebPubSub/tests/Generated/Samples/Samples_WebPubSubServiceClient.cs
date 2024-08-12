// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Messaging.WebPubSub.Samples
{
    public partial class Samples_WebPubSubServiceClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseAllConnections_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseAllConnections();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseAllConnections_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseAllConnectionsAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseAllConnections_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseAllConnections(excluded: new string[] { "<excluded>" }, reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseAllConnections_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseAllConnectionsAsync(excluded: new string[] { "<excluded>" }, reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToAll_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToAll(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToAll_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToAllAsync(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToAll_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToAll(content, new ContentType("application/json"), excluded: new string[] { "<excluded>" }, filter: "<filter>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToAll_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToAllAsync(content, new ContentType("application/json"), excluded: new string[] { "<excluded>" }, filter: "<filter>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseConnection_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseConnection("<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseConnection_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseConnectionAsync("<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseConnection_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseConnection("<connectionId>", reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseConnection_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseConnectionAsync("<connectionId>", reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToConnection_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToConnection("<connectionId>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToConnection_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToConnectionAsync("<connectionId>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToConnection_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToConnection("<connectionId>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToConnection_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToConnectionAsync("<connectionId>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromAllGroups_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.RemoveConnectionFromAllGroups("<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromAllGroups_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.RemoveConnectionFromAllGroupsAsync("<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromAllGroups_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.RemoveConnectionFromAllGroups("<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromAllGroups_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.RemoveConnectionFromAllGroupsAsync("<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseGroupConnections_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseGroupConnections("<group>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseGroupConnections_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseGroupConnectionsAsync("<group>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseGroupConnections_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseGroupConnections("<group>", excluded: new string[] { "<excluded>" }, reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseGroupConnections_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseGroupConnectionsAsync("<group>", excluded: new string[] { "<excluded>" }, reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToGroup_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToGroup("<group>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToGroup_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToGroupAsync("<group>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToGroup_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToGroup("<group>", content, new ContentType("application/json"), excluded: new string[] { "<excluded>" }, filter: "<filter>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToGroup_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToGroupAsync("<group>", content, new ContentType("application/json"), excluded: new string[] { "<excluded>" }, filter: "<filter>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromGroup_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.RemoveConnectionFromGroup("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromGroup_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.RemoveConnectionFromGroupAsync("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromGroup_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.RemoveConnectionFromGroup("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromGroup_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.RemoveConnectionFromGroupAsync("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AddConnectionToGroup_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.AddConnectionToGroup("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AddConnectionToGroup_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.AddConnectionToGroupAsync("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AddConnectionToGroup_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.AddConnectionToGroup("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AddConnectionToGroup_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.AddConnectionToGroupAsync("<group>", "<connectionId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseUserConnections_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseUserConnections("<userId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseUserConnections_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseUserConnectionsAsync("<userId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseUserConnections_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.CloseUserConnections("<userId>", excluded: new string[] { "<excluded>" }, reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseUserConnections_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.CloseUserConnectionsAsync("<userId>", excluded: new string[] { "<excluded>" }, reason: "<reason>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToUser_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToUser("<userId>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToUser_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToUserAsync("<userId>", content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToUser_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.SendToUser("<userId>", content, new ContentType("application/json"), filter: "<filter>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToUser_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.SendToUserAsync("<userId>", content, new ContentType("application/json"), filter: "<filter>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveUserFromAllGroups_ShortVersion()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.RemoveUserFromAllGroups("<userId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveUserFromAllGroups_ShortVersion_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.RemoveUserFromAllGroupsAsync("<userId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveUserFromAllGroups_AllParameters()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = client.RemoveUserFromAllGroups("<userId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveUserFromAllGroups_AllParameters_Async()
        {
            WebPubSubServiceClient client = new WebPubSubServiceClient("<Endpoint>", "<Hub>");

            Response response = await client.RemoveUserFromAllGroupsAsync("<userId>");

            Console.WriteLine(response.Status);
        }
    }
}
