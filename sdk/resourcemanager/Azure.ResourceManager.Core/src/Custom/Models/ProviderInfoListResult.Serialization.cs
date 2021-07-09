// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    internal partial class ProviderInfoListResult
    {
        internal static ProviderInfoListResult DeserializeProviderInfoListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ProviderInfo>> value = default;
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
                    List<ProviderInfo> array = new List<ProviderInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderInfo.DeserializeProviderInfo(item));
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
            return new ProviderInfoListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
