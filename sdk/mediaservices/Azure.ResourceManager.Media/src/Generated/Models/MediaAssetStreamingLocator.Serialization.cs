// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaAssetStreamingLocator : IUtf8JsonSerializable, IJsonModel<MediaAssetStreamingLocator>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaAssetStreamingLocator>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaAssetStreamingLocator>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetStreamingLocator>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAssetStreamingLocator)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(AssetName))
            {
                writer.WritePropertyName("assetName"u8);
                writer.WriteStringValue(AssetName);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StreamingLocatorId))
            {
                writer.WritePropertyName("streamingLocatorId"u8);
                writer.WriteStringValue(StreamingLocatorId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StreamingPolicyName))
            {
                writer.WritePropertyName("streamingPolicyName"u8);
                writer.WriteStringValue(StreamingPolicyName);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultContentKeyPolicyName))
            {
                writer.WritePropertyName("defaultContentKeyPolicyName"u8);
                writer.WriteStringValue(DefaultContentKeyPolicyName);
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
            writer.WriteEndObject();
        }

        MediaAssetStreamingLocator IJsonModel<MediaAssetStreamingLocator>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetStreamingLocator>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAssetStreamingLocator)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaAssetStreamingLocator(document.RootElement, options);
        }

        internal static MediaAssetStreamingLocator DeserializeMediaAssetStreamingLocator(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string assetName = default;
            DateTimeOffset? created = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            Guid? streamingLocatorId = default;
            string streamingPolicyName = default;
            string defaultContentKeyPolicyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assetName"u8))
                {
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("streamingLocatorId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    streamingLocatorId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("streamingPolicyName"u8))
                {
                    streamingPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultContentKeyPolicyName"u8))
                {
                    defaultContentKeyPolicyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MediaAssetStreamingLocator(
                name,
                assetName,
                created,
                startTime,
                endTime,
                streamingLocatorId,
                streamingPolicyName,
                defaultContentKeyPolicyName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaAssetStreamingLocator>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetStreamingLocator>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaAssetStreamingLocator)} does not support writing '{options.Format}' format.");
            }
        }

        MediaAssetStreamingLocator IPersistableModel<MediaAssetStreamingLocator>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetStreamingLocator>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaAssetStreamingLocator(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaAssetStreamingLocator)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaAssetStreamingLocator>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
