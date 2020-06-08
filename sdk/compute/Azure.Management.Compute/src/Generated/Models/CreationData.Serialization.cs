// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class CreationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("createOption");
            writer.WriteStringValue(CreateOption.ToString());
            if (StorageAccountId != null)
            {
                writer.WritePropertyName("storageAccountId");
                writer.WriteStringValue(StorageAccountId);
            }
            if (ImageReference != null)
            {
                writer.WritePropertyName("imageReference");
                writer.WriteObjectValue(ImageReference);
            }
            if (GalleryImageReference != null)
            {
                writer.WritePropertyName("galleryImageReference");
                writer.WriteObjectValue(GalleryImageReference);
            }
            if (SourceUri != null)
            {
                writer.WritePropertyName("sourceUri");
                writer.WriteStringValue(SourceUri);
            }
            if (SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId");
                writer.WriteStringValue(SourceResourceId);
            }
            if (SourceUniqueId != null)
            {
                writer.WritePropertyName("sourceUniqueId");
                writer.WriteStringValue(SourceUniqueId);
            }
            if (UploadSizeBytes != null)
            {
                writer.WritePropertyName("uploadSizeBytes");
                writer.WriteNumberValue(UploadSizeBytes.Value);
            }
            writer.WriteEndObject();
        }

        internal static CreationData DeserializeCreationData(JsonElement element)
        {
            DiskCreateOption createOption = default;
            string storageAccountId = default;
            ImageDiskReference imageReference = default;
            ImageDiskReference galleryImageReference = default;
            string sourceUri = default;
            string sourceResourceId = default;
            string sourceUniqueId = default;
            long? uploadSizeBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createOption"))
                {
                    createOption = new DiskCreateOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("galleryImageReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    galleryImageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceUniqueId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceUniqueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadSizeBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadSizeBytes = property.Value.GetInt64();
                    continue;
                }
            }
            return new CreationData(createOption, storageAccountId, imageReference, galleryImageReference, sourceUri, sourceResourceId, sourceUniqueId, uploadSizeBytes);
        }
    }
}
