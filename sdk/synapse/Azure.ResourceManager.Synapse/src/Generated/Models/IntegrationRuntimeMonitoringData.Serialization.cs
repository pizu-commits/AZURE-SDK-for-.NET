// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class IntegrationRuntimeMonitoringData
    {
        internal static IntegrationRuntimeMonitoringData DeserializeIntegrationRuntimeMonitoringData(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<IntegrationRuntimeNodeMonitoringData>> nodes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IntegrationRuntimeNodeMonitoringData> array = new List<IntegrationRuntimeNodeMonitoringData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationRuntimeNodeMonitoringData.DeserializeIntegrationRuntimeNodeMonitoringData(item));
                    }
                    nodes = array;
                    continue;
                }
            }
            return new IntegrationRuntimeMonitoringData(name.Value, Optional.ToList(nodes));
        }
    }
}
