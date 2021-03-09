// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class RestorePointTypeExtensions
    {
        public static string ToSerialString(this RestorePointType value) => value switch
        {
            RestorePointType.Continuous => "CONTINUOUS",
            RestorePointType.Discrete => "DISCRETE",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RestorePointType value.")
        };

        public static RestorePointType ToRestorePointType(this string value)
        {
            if (string.Equals(value, "CONTINUOUS", StringComparison.InvariantCultureIgnoreCase)) return RestorePointType.Continuous;
            if (string.Equals(value, "DISCRETE", StringComparison.InvariantCultureIgnoreCase)) return RestorePointType.Discrete;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RestorePointType value.");
        }
    }
}
