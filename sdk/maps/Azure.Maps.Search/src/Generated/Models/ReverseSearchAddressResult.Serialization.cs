// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class ReverseSearchAddressResult
    {
        internal static ReverseSearchAddressResult DeserializeReverseSearchAddressResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SearchSummary summary = default;
            IReadOnlyList<ReverseSearchAddressItem> addresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = SearchSummary.DeserializeSearchSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReverseSearchAddressItem> array = new List<ReverseSearchAddressItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReverseSearchAddressItem.DeserializeReverseSearchAddressItem(item));
                    }
                    addresses = array;
                    continue;
                }
            }
            return new ReverseSearchAddressResult(summary, addresses ?? new ChangeTrackingList<ReverseSearchAddressItem>());
        }
    }
}
