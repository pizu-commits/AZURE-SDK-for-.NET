// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class OperationStatusExtensions
    {
        public static string ToSerialString(this OperationStatus value) => value switch
        {
            OperationStatus.InProgress => "InProgress",
            OperationStatus.Failed => "Failed",
            OperationStatus.Succeeded => "Succeeded",
            OperationStatus.TimedOut => "TimedOut",
            OperationStatus.Created => "Created",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OperationStatus value.")
        };

        public static OperationStatus ToOperationStatus(this string value)
        {
            if (string.Equals(value, "InProgress", StringComparison.InvariantCultureIgnoreCase)) return OperationStatus.InProgress;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return OperationStatus.Failed;
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return OperationStatus.Succeeded;
            if (string.Equals(value, "TimedOut", StringComparison.InvariantCultureIgnoreCase)) return OperationStatus.TimedOut;
            if (string.Equals(value, "Created", StringComparison.InvariantCultureIgnoreCase)) return OperationStatus.Created;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OperationStatus value.");
        }
    }
}
