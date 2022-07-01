// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SharedGalleryDataDiskImage
    {
        internal static SharedGalleryDataDiskImage DeserializeSharedGalleryDataDiskImage(JsonElement element)
        {
            int lun = default;
            Optional<int> diskSizeGB = default;
            Optional<SharedGalleryHostCaching> hostCaching = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostCaching"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hostCaching = new SharedGalleryHostCaching(property.Value.GetString());
                    continue;
                }
            }
            return new SharedGalleryDataDiskImage(Optional.ToNullable(diskSizeGB), Optional.ToNullable(hostCaching), lun);
        }
    }
}
