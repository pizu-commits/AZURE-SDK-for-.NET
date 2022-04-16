// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class TestNotificationResponse
    {
        internal static TestNotificationResponse DeserializeTestNotificationResponse(JsonElement element)
        {
            string notificationId = default;
            string correlationId = default;
            string createdTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationId"))
                {
                    notificationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetString();
                    continue;
                }
            }
            return new TestNotificationResponse(notificationId, correlationId, createdTime);
        }
    }
}
