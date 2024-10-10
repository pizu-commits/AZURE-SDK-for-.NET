// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class StoragePoolSkuInfo : IUtf8JsonSerializable, IJsonModel<StoragePoolSkuInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StoragePoolSkuInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StoragePoolSkuInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolSkuInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoragePoolSkuInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LocationInfo))
            {
                writer.WritePropertyName("locationInfo"u8);
                writer.WriteObjectValue(LocationInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Restrictions))
            {
                writer.WritePropertyName("restrictions"u8);
                writer.WriteStartArray();
                foreach (var item in Restrictions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
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
        }

        StoragePoolSkuInfo IJsonModel<StoragePoolSkuInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolSkuInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoragePoolSkuInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStoragePoolSkuInfo(document.RootElement, options);
        }

        internal static StoragePoolSkuInfo DeserializeStoragePoolSkuInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string apiVersion = default;
            string resourceType = default;
            IReadOnlyList<StoragePoolSkuCapability> capabilities = default;
            StoragePoolSkuLocationInfo locationInfo = default;
            string name = default;
            string tier = default;
            IReadOnlyList<StoragePoolSkuRestrictions> restrictions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StoragePoolSkuCapability> array = new List<StoragePoolSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StoragePoolSkuCapability.DeserializeStoragePoolSkuCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    locationInfo = StoragePoolSkuLocationInfo.DeserializeStoragePoolSkuLocationInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StoragePoolSkuRestrictions> array = new List<StoragePoolSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StoragePoolSkuRestrictions.DeserializeStoragePoolSkuRestrictions(item, options));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StoragePoolSkuInfo(
                apiVersion,
                resourceType,
                capabilities ?? new ChangeTrackingList<StoragePoolSkuCapability>(),
                locationInfo,
                name,
                tier,
                restrictions ?? new ChangeTrackingList<StoragePoolSkuRestrictions>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StoragePoolSkuInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolSkuInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StoragePoolSkuInfo)} does not support writing '{options.Format}' format.");
            }
        }

        StoragePoolSkuInfo IPersistableModel<StoragePoolSkuInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolSkuInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStoragePoolSkuInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StoragePoolSkuInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StoragePoolSkuInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
