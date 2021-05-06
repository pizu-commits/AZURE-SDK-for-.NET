// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal static partial class AzureStorageTypeExtensions
    {
        public static string ToSerialString(this AzureStorageType value) => value switch
        {
            AzureStorageType.AzureFiles => "AzureFiles",
            AzureStorageType.AzureBlob => "AzureBlob",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AzureStorageType value.")
        };

        public static AzureStorageType ToAzureStorageType(this string value)
        {
            if (string.Equals(value, "AzureFiles", StringComparison.InvariantCultureIgnoreCase)) return AzureStorageType.AzureFiles;
            if (string.Equals(value, "AzureBlob", StringComparison.InvariantCultureIgnoreCase)) return AzureStorageType.AzureBlob;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AzureStorageType value.");
        }
    }
}
