// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteRange
    {
        internal static RouteRange DeserializeRouteRange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LatLongPair center = default;
            IReadOnlyList<LatLongPair> boundary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("center"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    center = LatLongPair.DeserializeLatLongPair(property.Value);
                    continue;
                }
                if (property.NameEquals("boundary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LatLongPair> array = new List<LatLongPair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LatLongPair.DeserializeLatLongPair(item));
                    }
                    boundary = array;
                    continue;
                }
            }
            return new RouteRange(center, boundary ?? new ChangeTrackingList<LatLongPair>());
        }
    }
}
