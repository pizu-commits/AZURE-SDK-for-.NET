// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class ProviderInstanceListResult
    {
        internal static ProviderInstanceListResult DeserializeProviderInstanceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SapProviderInstanceData>> value = default;
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
                    List<SapProviderInstanceData> array = new List<SapProviderInstanceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SapProviderInstanceData.DeserializeSapProviderInstanceData(item));
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
            return new ProviderInstanceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
