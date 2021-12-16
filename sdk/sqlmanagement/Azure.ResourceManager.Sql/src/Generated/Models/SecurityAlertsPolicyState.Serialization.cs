// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class SecurityAlertsPolicyStateExtensions
    {
        public static string ToSerialString(this SecurityAlertsPolicyState value) => value switch
        {
            SecurityAlertsPolicyState.Enabled => "Enabled",
            SecurityAlertsPolicyState.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityAlertsPolicyState value.")
        };

        public static SecurityAlertsPolicyState ToSecurityAlertsPolicyState(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return SecurityAlertsPolicyState.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return SecurityAlertsPolicyState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityAlertsPolicyState value.");
        }
    }
}
