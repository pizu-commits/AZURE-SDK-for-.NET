// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    internal partial class NetworkFabricSkusListResult
    {
        internal static NetworkFabricSkusListResult DeserializeNetworkFabricSkusListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<NetworkFabricSkuData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkFabricSkuData> array = new List<NetworkFabricSkuData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkFabricSkuData.DeserializeNetworkFabricSkuData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkFabricSkusListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
