// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class HostingEnvironmentStatusExtensions
    {
        public static string ToSerialString(this HostingEnvironmentStatus value) => value switch
        {
            HostingEnvironmentStatus.Preparing => "Preparing",
            HostingEnvironmentStatus.Ready => "Ready",
            HostingEnvironmentStatus.Scaling => "Scaling",
            HostingEnvironmentStatus.Deleting => "Deleting",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HostingEnvironmentStatus value.")
        };

        public static HostingEnvironmentStatus ToHostingEnvironmentStatus(this string value)
        {
            if (string.Equals(value, "Preparing", StringComparison.InvariantCultureIgnoreCase)) return HostingEnvironmentStatus.Preparing;
            if (string.Equals(value, "Ready", StringComparison.InvariantCultureIgnoreCase)) return HostingEnvironmentStatus.Ready;
            if (string.Equals(value, "Scaling", StringComparison.InvariantCultureIgnoreCase)) return HostingEnvironmentStatus.Scaling;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return HostingEnvironmentStatus.Deleting;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HostingEnvironmentStatus value.");
        }
    }
}
