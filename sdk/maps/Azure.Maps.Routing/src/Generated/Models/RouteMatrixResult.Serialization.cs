// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteMatrixResult
    {
        internal static RouteMatrixResult DeserializeRouteMatrixResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> formatVersion = default;
            Core.Optional<IReadOnlyList<IList<RouteMatrix>>> matrix = default;
            Core.Optional<RouteMatrixSummary> summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatVersion"u8))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matrix"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<RouteMatrix>> array = new List<IList<RouteMatrix>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<RouteMatrix> array0 = new List<RouteMatrix>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(RouteMatrix.DeserializeRouteMatrix(item0));
                            }
                            array.Add(array0);
                        }
                    }
                    matrix = array;
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = RouteMatrixSummary.DeserializeRouteMatrixSummary(property.Value);
                    continue;
                }
            }
            return new RouteMatrixResult(formatVersion.Value, Core.Optional.ToList(matrix), summary.Value);
        }
    }
}
