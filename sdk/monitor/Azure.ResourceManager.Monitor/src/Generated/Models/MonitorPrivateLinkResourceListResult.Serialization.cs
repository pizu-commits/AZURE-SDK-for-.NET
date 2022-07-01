// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class MonitorPrivateLinkResourceListResult
    {
        internal static MonitorPrivateLinkResourceListResult DeserializeMonitorPrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateLinkData>> value = default;
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
                    List<PrivateLinkData> array = new List<PrivateLinkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkData.DeserializePrivateLinkData(item));
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
            return new MonitorPrivateLinkResourceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
