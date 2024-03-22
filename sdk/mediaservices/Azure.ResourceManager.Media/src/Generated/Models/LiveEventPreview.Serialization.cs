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
    public partial class LiveEventPreview : IUtf8JsonSerializable, IJsonModel<LiveEventPreview>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LiveEventPreview>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LiveEventPreview>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventPreview>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LiveEventPreview)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue<LiveEventEndpoint>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AccessControl))
            {
                if (AccessControl != null)
                {
                    writer.WritePropertyName("accessControl"u8);
                    writer.WriteObjectValue<LiveEventPreviewAccessControl>(AccessControl, options);
                }
                else
                {
                    writer.WriteNull("accessControl");
                }
            }
            if (Optional.IsDefined(PreviewLocator))
            {
                writer.WritePropertyName("previewLocator"u8);
                writer.WriteStringValue(PreviewLocator);
            }
            if (Optional.IsDefined(StreamingPolicyName))
            {
                writer.WritePropertyName("streamingPolicyName"u8);
                writer.WriteStringValue(StreamingPolicyName);
            }
            if (Optional.IsDefined(AlternativeMediaId))
            {
                writer.WritePropertyName("alternativeMediaId"u8);
                writer.WriteStringValue(AlternativeMediaId);
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

        LiveEventPreview IJsonModel<LiveEventPreview>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventPreview>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LiveEventPreview)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLiveEventPreview(document.RootElement, options);
        }

        internal static LiveEventPreview DeserializeLiveEventPreview(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<LiveEventEndpoint> endpoints = default;
            LiveEventPreviewAccessControl accessControl = default;
            string previewLocator = default;
            string streamingPolicyName = default;
            string alternativeMediaId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LiveEventEndpoint> array = new List<LiveEventEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LiveEventEndpoint.DeserializeLiveEventEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("accessControl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessControl = null;
                        continue;
                    }
                    accessControl = LiveEventPreviewAccessControl.DeserializeLiveEventPreviewAccessControl(property.Value, options);
                    continue;
                }
                if (property.NameEquals("previewLocator"u8))
                {
                    previewLocator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamingPolicyName"u8))
                {
                    streamingPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alternativeMediaId"u8))
                {
                    alternativeMediaId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LiveEventPreview(
                endpoints ?? new ChangeTrackingList<LiveEventEndpoint>(),
                accessControl,
                previewLocator,
                streamingPolicyName,
                alternativeMediaId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LiveEventPreview>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventPreview>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LiveEventPreview)} does not support writing '{options.Format}' format.");
            }
        }

        LiveEventPreview IPersistableModel<LiveEventPreview>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventPreview>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLiveEventPreview(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LiveEventPreview)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LiveEventPreview>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
