// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class ResolveStatusExtensions
    {
        public static string ToSerialString(this ResolveStatus value) => value switch
        {
            ResolveStatus.Initialized => "Initialized",
            ResolveStatus.Resolved => "Resolved",
            ResolveStatus.InvalidSyntax => "InvalidSyntax",
            ResolveStatus.MSINotEnabled => "MSINotEnabled",
            ResolveStatus.VaultNotFound => "VaultNotFound",
            ResolveStatus.SecretNotFound => "SecretNotFound",
            ResolveStatus.SecretVersionNotFound => "SecretVersionNotFound",
            ResolveStatus.AccessToKeyVaultDenied => "AccessToKeyVaultDenied",
            ResolveStatus.OtherReasons => "OtherReasons",
            ResolveStatus.FetchTimedOut => "FetchTimedOut",
            ResolveStatus.UnauthorizedClient => "UnauthorizedClient",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResolveStatus value.")
        };

        public static ResolveStatus ToResolveStatus(this string value)
        {
            if (string.Equals(value, "Initialized", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.Initialized;
            if (string.Equals(value, "Resolved", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.Resolved;
            if (string.Equals(value, "InvalidSyntax", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.InvalidSyntax;
            if (string.Equals(value, "MSINotEnabled", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.MSINotEnabled;
            if (string.Equals(value, "VaultNotFound", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.VaultNotFound;
            if (string.Equals(value, "SecretNotFound", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.SecretNotFound;
            if (string.Equals(value, "SecretVersionNotFound", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.SecretVersionNotFound;
            if (string.Equals(value, "AccessToKeyVaultDenied", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.AccessToKeyVaultDenied;
            if (string.Equals(value, "OtherReasons", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.OtherReasons;
            if (string.Equals(value, "FetchTimedOut", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.FetchTimedOut;
            if (string.Equals(value, "UnauthorizedClient", StringComparison.InvariantCultureIgnoreCase)) return ResolveStatus.UnauthorizedClient;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResolveStatus value.");
        }
    }
}
