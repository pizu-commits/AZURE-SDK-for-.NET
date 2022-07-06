// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    internal partial class NotificationListResponse
    {
        internal static NotificationListResponse DeserializeNotificationListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<UpgradeNotification>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UpgradeNotification> array = new List<UpgradeNotification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UpgradeNotification.DeserializeUpgradeNotification(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NotificationListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
