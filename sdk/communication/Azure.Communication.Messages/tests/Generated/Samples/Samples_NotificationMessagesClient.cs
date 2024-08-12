// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Communication.Messages.Samples
{
    public partial class Samples_NotificationMessagesClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NotificationMessagesClient_Send_ShortVersion()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            using RequestContent content = RequestContent.Create(new
            {
                kind = "text",
                content = "<content>",
                channelRegistrationId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                to = new object[]
            {
"<to>"
            },
            });
            Response response = client.Send(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("messageId").ToString());
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("to").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NotificationMessagesClient_Send_ShortVersion_Async()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            using RequestContent content = RequestContent.Create(new
            {
                kind = "text",
                content = "<content>",
                channelRegistrationId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                to = new object[]
            {
"<to>"
            },
            });
            Response response = await client.SendAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("messageId").ToString());
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("to").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NotificationMessagesClient_Send_ShortVersion_Convenience()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            NotificationContent notificationContent = new TextNotificationContent(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new string[] { "<to>" }, "<content>");
            Response<SendMessageResult> response = client.Send(notificationContent);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NotificationMessagesClient_Send_ShortVersion_Convenience_Async()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            NotificationContent notificationContent = new TextNotificationContent(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new string[] { "<to>" }, "<content>");
            Response<SendMessageResult> response = await client.SendAsync(notificationContent);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NotificationMessagesClient_Send_AllParameters()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            using RequestContent content = RequestContent.Create(new
            {
                kind = "text",
                content = "<content>",
                channelRegistrationId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                to = new object[]
            {
"<to>"
            },
            });
            Response response = client.Send(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("messageId").ToString());
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("to").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NotificationMessagesClient_Send_AllParameters_Async()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            using RequestContent content = RequestContent.Create(new
            {
                kind = "text",
                content = "<content>",
                channelRegistrationId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                to = new object[]
            {
"<to>"
            },
            });
            Response response = await client.SendAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("messageId").ToString());
            Console.WriteLine(result.GetProperty("receipts")[0].GetProperty("to").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NotificationMessagesClient_Send_AllParameters_Convenience()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            NotificationContent notificationContent = new TextNotificationContent(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new string[] { "<to>" }, "<content>");
            Response<SendMessageResult> response = client.Send(notificationContent);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NotificationMessagesClient_Send_AllParameters_Convenience_Async()
        {
            NotificationMessagesClient client = new NotificationMessagesClient(null);

            NotificationContent notificationContent = new TextNotificationContent(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new string[] { "<to>" }, "<content>");
            Response<SendMessageResult> response = await client.SendAsync(notificationContent);
        }
    }
}
