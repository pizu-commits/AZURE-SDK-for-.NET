// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Advisor;

namespace Azure.ResourceManager.Advisor.Models
{
    internal partial class SuppressionContractListResult
    {
        internal static SuppressionContractListResult DeserializeSuppressionContractListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<SuppressionContractData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SuppressionContractData> array = new List<SuppressionContractData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SuppressionContractData.DeserializeSuppressionContractData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SuppressionContractListResult(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
