// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoResourceSkuZoneDetails
    {
        internal static KustoResourceSkuZoneDetails DeserializeKustoResourceSkuZoneDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<string>> name = default;
            Core.Optional<IReadOnlyList<KustoResourceSkuCapabilities>> capabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    name = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KustoResourceSkuCapabilities> array = new List<KustoResourceSkuCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoResourceSkuCapabilities.DeserializeKustoResourceSkuCapabilities(item));
                    }
                    capabilities = array;
                    continue;
                }
            }
            return new KustoResourceSkuZoneDetails(Core.Optional.ToList(name), Core.Optional.ToList(capabilities));
        }
    }
}
