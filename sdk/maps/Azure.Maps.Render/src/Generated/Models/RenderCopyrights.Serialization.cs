// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Render
{
    public partial class RenderCopyrights
    {
        internal static RenderCopyrights DeserializeRenderCopyrights(JsonElement element)
        {
            Optional<string> formatVersion = default;
            Optional<IReadOnlyList<string>> generalCopyrights = default;
            Optional<IReadOnlyList<RegionCopyrights>> regions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatVersion"))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generalCopyrights"))
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
                    generalCopyrights = array;
                    continue;
                }
                if (property.NameEquals("regions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RegionCopyrights> array = new List<RegionCopyrights>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegionCopyrights.DeserializeRegionCopyrights(item));
                    }
                    regions = array;
                    continue;
                }
            }
            return new RenderCopyrights(formatVersion.Value, Optional.ToList(generalCopyrights), Optional.ToList(regions));
        }
    }
}
