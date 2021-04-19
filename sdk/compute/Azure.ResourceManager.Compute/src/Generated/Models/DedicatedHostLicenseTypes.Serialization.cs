// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static partial class DedicatedHostLicenseTypesExtensions
    {
        public static string ToSerialString(this DedicatedHostLicenseTypes value) => value switch
        {
            DedicatedHostLicenseTypes.None => "None",
            DedicatedHostLicenseTypes.WindowsServerHybrid => "Windows_Server_Hybrid",
            DedicatedHostLicenseTypes.WindowsServerPerpetual => "Windows_Server_Perpetual",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DedicatedHostLicenseTypes value.")
        };

        public static DedicatedHostLicenseTypes ToDedicatedHostLicenseTypes(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return DedicatedHostLicenseTypes.None;
            if (string.Equals(value, "Windows_Server_Hybrid", StringComparison.InvariantCultureIgnoreCase)) return DedicatedHostLicenseTypes.WindowsServerHybrid;
            if (string.Equals(value, "Windows_Server_Perpetual", StringComparison.InvariantCultureIgnoreCase)) return DedicatedHostLicenseTypes.WindowsServerPerpetual;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DedicatedHostLicenseTypes value.");
        }
    }
}
