// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    internal static partial class FacetSortOrderExtensions
    {
        public static string ToSerialString(this FacetSortOrder value) => value switch
        {
            FacetSortOrder.Asc => "asc",
            FacetSortOrder.Desc => "desc",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FacetSortOrder value.")
        };

        public static FacetSortOrder ToFacetSortOrder(this string value)
        {
            if (string.Equals(value, "asc", StringComparison.InvariantCultureIgnoreCase)) return FacetSortOrder.Asc;
            if (string.Equals(value, "desc", StringComparison.InvariantCultureIgnoreCase)) return FacetSortOrder.Desc;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FacetSortOrder value.");
        }
    }
}
