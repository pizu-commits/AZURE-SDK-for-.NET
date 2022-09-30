// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.WorkloadMonitor;

namespace Azure.ResourceManager.WorkloadMonitor.Models
{
    internal partial class HealthMonitorList
    {
        internal static HealthMonitorList DeserializeHealthMonitorList(JsonElement element)
        {
            Optional<IReadOnlyList<HealthMonitorData>> value = default;
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
                    List<HealthMonitorData> array = new List<HealthMonitorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthMonitorData.DeserializeHealthMonitorData(item));
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
            return new HealthMonitorList(Optional.ToList(value), nextLink.Value);
        }
    }
}
