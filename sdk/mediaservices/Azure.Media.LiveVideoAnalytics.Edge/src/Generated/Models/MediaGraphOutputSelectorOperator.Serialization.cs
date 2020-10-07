// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    internal static class MediaGraphOutputSelectorOperatorExtensions
    {
        public static string ToSerialString(this MediaGraphOutputSelectorOperator value) => value switch
        {
            MediaGraphOutputSelectorOperator.Is => "is",
            MediaGraphOutputSelectorOperator.IsNot => "isNot",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MediaGraphOutputSelectorOperator value.")
        };

        public static MediaGraphOutputSelectorOperator ToMediaGraphOutputSelectorOperator(this string value)
        {
            if (string.Equals(value, "is", StringComparison.InvariantCultureIgnoreCase)) return MediaGraphOutputSelectorOperator.Is;
            if (string.Equals(value, "isNot", StringComparison.InvariantCultureIgnoreCase)) return MediaGraphOutputSelectorOperator.IsNot;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MediaGraphOutputSelectorOperator value.");
        }
    }
}
