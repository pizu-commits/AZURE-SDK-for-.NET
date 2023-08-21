// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    internal partial class RouteMatrixResultResponse
    {
        internal static RouteMatrixResultResponse DeserializeRouteMatrixResultResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<RouteLegSummary> routeSummary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routeSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routeSummary = RouteLegSummary.DeserializeRouteLegSummary(property.Value);
                    continue;
                }
            }
            return new RouteMatrixResultResponse(routeSummary.Value);
        }
    }
}
