// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class MediaAssetData : IUtf8JsonSerializable, IJsonModel<MediaAssetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaAssetData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaAssetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAssetData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AssetId))
            {
                writer.WritePropertyName("assetId"u8);
                writer.WriteStringValue(AssetId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModified"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(AlternateId))
            {
                writer.WritePropertyName("alternateId"u8);
                writer.WriteStringValue(AlternateId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container"u8);
                writer.WriteStringValue(Container);
            }
            if (Optional.IsDefined(StorageAccountName))
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageEncryptionFormat))
            {
                writer.WritePropertyName("storageEncryptionFormat"u8);
                writer.WriteStringValue(StorageEncryptionFormat.Value.ToString());
            }
            if (Optional.IsDefined(EncryptionScope))
            {
                writer.WritePropertyName("encryptionScope"u8);
                writer.WriteStringValue(EncryptionScope);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MediaAssetData IJsonModel<MediaAssetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAssetData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaAssetData(document.RootElement, options);
        }

        internal static MediaAssetData DeserializeMediaAssetData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? assetId = default;
            DateTimeOffset? created = default;
            DateTimeOffset? lastModified = default;
            string alternateId = default;
            string description = default;
            string container = default;
            string storageAccountName = default;
            MediaAssetStorageEncryptionFormat? storageEncryptionFormat = default;
            string encryptionScope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("assetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("alternateId"u8))
                        {
                            alternateId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("container"u8))
                        {
                            container = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountName"u8))
                        {
                            storageAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageEncryptionFormat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageEncryptionFormat = new MediaAssetStorageEncryptionFormat(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptionScope"u8))
                        {
                            encryptionScope = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MediaAssetData(
                id,
                name,
                type,
                systemData,
                assetId,
                created,
                lastModified,
                alternateId,
                description,
                container,
                storageAccountName,
                storageEncryptionFormat,
                encryptionScope,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaAssetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaAssetData)} does not support writing '{options.Format}' format.");
            }
        }

        MediaAssetData IPersistableModel<MediaAssetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaAssetData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaAssetData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaAssetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
