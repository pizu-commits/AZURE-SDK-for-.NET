// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class BigDataPoolResourceInfoListResult
    {
        internal static BigDataPoolResourceInfoListResult DeserializeBigDataPoolResourceInfoListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<BigDataPoolResourceInfoData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BigDataPoolResourceInfoData> array = new List<BigDataPoolResourceInfoData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BigDataPoolResourceInfoData.DeserializeBigDataPoolResourceInfoData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BigDataPoolResourceInfoListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
