// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Translation.Document
{
    internal static partial class StorageInputUriKindExtensions
    {
        public static string ToSerialString(this StorageInputUriKind value) => value switch
        {
            StorageInputUriKind.Folder => "Folder",
            StorageInputUriKind.File => "File",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageInputUriKind value.")
        };

        public static StorageInputUriKind ToStorageInputUriKind(this string value)
        {
            if (string.Equals(value, "Folder", StringComparison.InvariantCultureIgnoreCase)) return StorageInputUriKind.Folder;
            if (string.Equals(value, "File", StringComparison.InvariantCultureIgnoreCase)) return StorageInputUriKind.File;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageInputUriKind value.");
        }
    }
}
