// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteSectionTec
    {
        internal static RouteSectionTec DeserializeRouteSectionTec(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> effectCode = default;
            Core.Optional<IReadOnlyList<RouteSectionTecCause>> causes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("effectCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("causes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteSectionTecCause> array = new List<RouteSectionTecCause>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteSectionTecCause.DeserializeRouteSectionTecCause(item));
                    }
                    causes = array;
                    continue;
                }
            }
            return new RouteSectionTec(Core.Optional.ToNullable(effectCode), Core.Optional.ToList(causes));
        }
    }
}
