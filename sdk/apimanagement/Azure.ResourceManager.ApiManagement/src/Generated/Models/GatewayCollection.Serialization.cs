// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class GatewayCollection
    {
        internal static GatewayCollection DeserializeGatewayCollection(JsonElement element)
        {
            Optional<IReadOnlyList<GatewayContractData>> value = default;
            Optional<long> count = default;
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
                    List<GatewayContractData> array = new List<GatewayContractData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GatewayContractData.DeserializeGatewayContractData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GatewayCollection(Optional.ToList(value), Optional.ToNullable(count), nextLink.Value);
        }
    }
}
