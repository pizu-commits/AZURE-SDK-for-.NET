// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    internal static class ResultTypeExtensions
    {
        public static string ToSerialString(this ResultType value) => value switch
        {
            ResultType.Data => "Data",
            ResultType.Metadata => "Metadata",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResultType value.")
        };

        public static ResultType ToResultType(this string value)
        {
            if (string.Equals(value, "Data", StringComparison.InvariantCultureIgnoreCase)) return ResultType.Data;
            if (string.Equals(value, "Metadata", StringComparison.InvariantCultureIgnoreCase)) return ResultType.Metadata;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResultType value.");
        }
    }
}
