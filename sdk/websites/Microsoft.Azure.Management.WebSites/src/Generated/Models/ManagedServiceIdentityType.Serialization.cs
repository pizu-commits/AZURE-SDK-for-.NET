// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class ManagedServiceIdentityTypeExtensions
    {
        public static string ToSerialString(this ManagedServiceIdentityType value) => value switch
        {
            ManagedServiceIdentityType.SystemAssigned => "SystemAssigned",
            ManagedServiceIdentityType.UserAssigned => "UserAssigned",
            ManagedServiceIdentityType.SystemAssignedUserAssigned => "SystemAssigned, UserAssigned",
            ManagedServiceIdentityType.None => "None",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagedServiceIdentityType value.")
        };

        public static ManagedServiceIdentityType ToManagedServiceIdentityType(this string value)
        {
            if (string.Equals(value, "SystemAssigned", StringComparison.InvariantCultureIgnoreCase)) return ManagedServiceIdentityType.SystemAssigned;
            if (string.Equals(value, "UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ManagedServiceIdentityType.UserAssigned;
            if (string.Equals(value, "SystemAssigned, UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ManagedServiceIdentityType.SystemAssignedUserAssigned;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ManagedServiceIdentityType.None;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagedServiceIdentityType value.");
        }
    }
}
