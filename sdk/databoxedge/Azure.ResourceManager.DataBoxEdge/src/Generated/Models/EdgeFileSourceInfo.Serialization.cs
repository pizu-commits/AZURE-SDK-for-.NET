// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeFileSourceInfo : IUtf8JsonSerializable, IJsonModel<EdgeFileSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeFileSourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeFileSourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeFileSourceInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("shareId"u8);
            writer.WriteStringValue(ShareId);
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

        EdgeFileSourceInfo IJsonModel<EdgeFileSourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeFileSourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeFileSourceInfo(document.RootElement, options);
        }

        internal static EdgeFileSourceInfo DeserializeEdgeFileSourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier shareId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareId"u8))
                {
                    shareId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeFileSourceInfo(shareId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeFileSourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeFileSourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeFileSourceInfo IPersistableModel<EdgeFileSourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeFileSourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeFileSourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeFileSourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
