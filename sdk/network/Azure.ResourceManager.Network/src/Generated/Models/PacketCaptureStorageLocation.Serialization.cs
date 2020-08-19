// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PacketCaptureStorageLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageId))
            {
                writer.WritePropertyName("storageId");
                writer.WriteStringValue(StorageId);
            }
            if (Optional.IsDefined(StoragePath))
            {
                writer.WritePropertyName("storagePath");
                writer.WriteStringValue(StoragePath);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath");
                writer.WriteStringValue(FilePath);
            }
            writer.WriteEndObject();
        }

        internal static PacketCaptureStorageLocation DeserializePacketCaptureStorageLocation(JsonElement element)
        {
            Optional<string> storageId = default;
            Optional<string> storagePath = default;
            Optional<string> filePath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageId"))
                {
                    storageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storagePath"))
                {
                    storagePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"))
                {
                    filePath = property.Value.GetString();
                    continue;
                }
            }
            return new PacketCaptureStorageLocation(storageId.Value, storagePath.Value, filePath.Value);
        }
    }
}
