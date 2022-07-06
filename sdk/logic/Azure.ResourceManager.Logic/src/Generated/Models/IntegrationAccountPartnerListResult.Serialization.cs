// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class IntegrationAccountPartnerListResult
    {
        internal static IntegrationAccountPartnerListResult DeserializeIntegrationAccountPartnerListResult(JsonElement element)
        {
            Optional<IReadOnlyList<IntegrationAccountPartnerData>> value = default;
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
                    List<IntegrationAccountPartnerData> array = new List<IntegrationAccountPartnerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationAccountPartnerData.DeserializeIntegrationAccountPartnerData(item));
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
            return new IntegrationAccountPartnerListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
