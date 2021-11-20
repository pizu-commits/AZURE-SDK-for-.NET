// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class AddressRanges
    {
        internal static AddressRanges DeserializeAddressRanges(JsonElement element)
        {
            Optional<string> rangeLeft = default;
            Optional<string> rangeRight = default;
            Optional<LatLong> @from = default;
            Optional<LatLong> to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rangeLeft"))
                {
                    rangeLeft = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rangeRight"))
                {
                    rangeRight = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @from = LatLong.DeserializeLatLong(property.Value);
                    continue;
                }
                if (property.NameEquals("to"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    to = LatLong.DeserializeLatLong(property.Value);
                    continue;
                }
            }
            return new AddressRanges(rangeLeft.Value, rangeRight.Value, @from.Value, to.Value);
        }
    }
}
