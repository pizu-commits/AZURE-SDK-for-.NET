// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderItemAddressDetails : IUtf8JsonSerializable, IJsonModel<EdgeOrderItemAddressDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderItemAddressDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderItemAddressDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemAddressDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("forwardAddress"u8);
            writer.WriteObjectValue(ForwardAddress);
            if (options.Format != "W" && Optional.IsDefined(ReturnAddress))
            {
                writer.WritePropertyName("returnAddress"u8);
                writer.WriteObjectValue(ReturnAddress);
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

        EdgeOrderItemAddressDetails IJsonModel<EdgeOrderItemAddressDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemAddressDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderItemAddressDetails(document.RootElement, options);
        }

        internal static EdgeOrderItemAddressDetails DeserializeEdgeOrderItemAddressDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdgeOrderItemAddressProperties forwardAddress = default;
            EdgeOrderItemAddressProperties returnAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forwardAddress"u8))
                {
                    forwardAddress = EdgeOrderItemAddressProperties.DeserializeEdgeOrderItemAddressProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("returnAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnAddress = EdgeOrderItemAddressProperties.DeserializeEdgeOrderItemAddressProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderItemAddressDetails(forwardAddress, returnAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderItemAddressDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderItemAddressDetails)} does not support '{options.Format}' format.");
            }
        }

        EdgeOrderItemAddressDetails IPersistableModel<EdgeOrderItemAddressDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderItemAddressDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderItemAddressDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderItemAddressDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
