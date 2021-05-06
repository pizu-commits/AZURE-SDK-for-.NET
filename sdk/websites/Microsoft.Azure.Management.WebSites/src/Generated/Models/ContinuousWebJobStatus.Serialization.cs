// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class ContinuousWebJobStatusExtensions
    {
        public static string ToSerialString(this ContinuousWebJobStatus value) => value switch
        {
            ContinuousWebJobStatus.Initializing => "Initializing",
            ContinuousWebJobStatus.Starting => "Starting",
            ContinuousWebJobStatus.Running => "Running",
            ContinuousWebJobStatus.PendingRestart => "PendingRestart",
            ContinuousWebJobStatus.Stopped => "Stopped",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContinuousWebJobStatus value.")
        };

        public static ContinuousWebJobStatus ToContinuousWebJobStatus(this string value)
        {
            if (string.Equals(value, "Initializing", StringComparison.InvariantCultureIgnoreCase)) return ContinuousWebJobStatus.Initializing;
            if (string.Equals(value, "Starting", StringComparison.InvariantCultureIgnoreCase)) return ContinuousWebJobStatus.Starting;
            if (string.Equals(value, "Running", StringComparison.InvariantCultureIgnoreCase)) return ContinuousWebJobStatus.Running;
            if (string.Equals(value, "PendingRestart", StringComparison.InvariantCultureIgnoreCase)) return ContinuousWebJobStatus.PendingRestart;
            if (string.Equals(value, "Stopped", StringComparison.InvariantCultureIgnoreCase)) return ContinuousWebJobStatus.Stopped;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContinuousWebJobStatus value.");
        }
    }
}
