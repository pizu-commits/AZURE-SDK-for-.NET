// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class PolygonResult
    {
        internal static PolygonResult DeserializePolygonResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<PolygonObject>> additionalData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolygonObject> array = new List<PolygonObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolygonObject.DeserializePolygonObject(item));
                    }
                    additionalData = array;
                    continue;
                }
            }
            return new PolygonResult(Core.Optional.ToList(additionalData));
        }
    }
}
