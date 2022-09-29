// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static partial class GalleryApplicationCustomActionParameterTypeExtensions
    {
        public static string ToSerialString(this GalleryApplicationCustomActionParameterType value) => value switch
        {
            GalleryApplicationCustomActionParameterType.String => "String",
            GalleryApplicationCustomActionParameterType.ConfigurationDataBlob => "ConfigurationDataBlob",
            GalleryApplicationCustomActionParameterType.LogOutputBlob => "LogOutputBlob",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GalleryApplicationCustomActionParameterType value.")
        };

        public static GalleryApplicationCustomActionParameterType ToGalleryApplicationCustomActionParameterType(this string value)
        {
            if (string.Equals(value, "String", StringComparison.InvariantCultureIgnoreCase)) return GalleryApplicationCustomActionParameterType.String;
            if (string.Equals(value, "ConfigurationDataBlob", StringComparison.InvariantCultureIgnoreCase)) return GalleryApplicationCustomActionParameterType.ConfigurationDataBlob;
            if (string.Equals(value, "LogOutputBlob", StringComparison.InvariantCultureIgnoreCase)) return GalleryApplicationCustomActionParameterType.LogOutputBlob;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GalleryApplicationCustomActionParameterType value.");
        }
    }
}
