// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class HostNameTypeExtensions
    {
        public static string ToSerialString(this HostNameType value) => value switch
        {
            HostNameType.Verified => "Verified",
            HostNameType.Managed => "Managed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HostNameType value.")
        };

        public static HostNameType ToHostNameType(this string value)
        {
            if (string.Equals(value, "Verified", StringComparison.InvariantCultureIgnoreCase)) return HostNameType.Verified;
            if (string.Equals(value, "Managed", StringComparison.InvariantCultureIgnoreCase)) return HostNameType.Managed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HostNameType value.");
        }
    }
}
