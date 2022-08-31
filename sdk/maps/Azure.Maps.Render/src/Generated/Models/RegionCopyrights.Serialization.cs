// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Render
{
    public partial class RegionCopyrights
    {
        internal static RegionCopyrights DeserializeRegionCopyrights(JsonElement element)
        {
            Optional<IReadOnlyList<string>> copyrights = default;
            Optional<RegionCopyrightsCountry> country = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyrights"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    copyrights = array;
                    continue;
                }
                if (property.NameEquals("country"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    country = RegionCopyrightsCountry.DeserializeRegionCopyrightsCountry(property.Value);
                    continue;
                }
            }
            return new RegionCopyrights(Optional.ToList(copyrights), country.Value);
        }
    }
}
