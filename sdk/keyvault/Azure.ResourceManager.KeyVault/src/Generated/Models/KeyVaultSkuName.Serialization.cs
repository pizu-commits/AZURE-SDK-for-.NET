// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static partial class KeyVaultSkuNameExtensions
    {
        public static string ToSerialString(this KeyVaultSkuName value) => value switch
        {
            KeyVaultSkuName.Standard => "standard",
            KeyVaultSkuName.Premium => "premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultSkuName value.")
        };

        public static KeyVaultSkuName ToKeyVaultSkuName(this string value)
        {
            if (string.Equals(value, "standard", StringComparison.InvariantCultureIgnoreCase)) return KeyVaultSkuName.Standard;
            if (string.Equals(value, "premium", StringComparison.InvariantCultureIgnoreCase)) return KeyVaultSkuName.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultSkuName value.");
        }
    }
}
