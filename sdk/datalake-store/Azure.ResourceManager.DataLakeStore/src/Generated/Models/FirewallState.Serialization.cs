// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal static partial class FirewallStateExtensions
    {
        public static string ToSerialString(this FirewallState value) => value switch
        {
            FirewallState.Enabled => "Enabled",
            FirewallState.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FirewallState value.")
        };

        public static FirewallState ToFirewallState(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return FirewallState.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return FirewallState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FirewallState value.");
        }
    }
}
