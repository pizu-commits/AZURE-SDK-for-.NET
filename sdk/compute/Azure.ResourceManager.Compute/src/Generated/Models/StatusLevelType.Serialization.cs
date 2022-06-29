// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static partial class StatusLevelTypeExtensions
    {
        public static string ToSerialString(this StatusLevelType value) => value switch
        {
            StatusLevelType.Info => "Info",
            StatusLevelType.Warning => "Warning",
            StatusLevelType.Error => "Error",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StatusLevelType value.")
        };

        public static StatusLevelType ToStatusLevelType(this string value)
        {
            if (string.Equals(value, "Info", StringComparison.InvariantCultureIgnoreCase)) return StatusLevelType.Info;
            if (string.Equals(value, "Warning", StringComparison.InvariantCultureIgnoreCase)) return StatusLevelType.Warning;
            if (string.Equals(value, "Error", StringComparison.InvariantCultureIgnoreCase)) return StatusLevelType.Error;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StatusLevelType value.");
        }
    }
}
