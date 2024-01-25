// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningEndpointKeyRegenerateContent : IUtf8JsonSerializable, IJsonModel<MachineLearningEndpointKeyRegenerateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEndpointKeyRegenerateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningEndpointKeyRegenerateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointKeyRegenerateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyType"u8);
            writer.WriteStringValue(KeyType.ToString());
            if (Optional.IsDefined(KeyValue))
            {
                if (KeyValue != null)
                {
                    writer.WritePropertyName("keyValue"u8);
                    writer.WriteStringValue(KeyValue);
                }
                else
                {
                    writer.WriteNull("keyValue");
                }
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

        MachineLearningEndpointKeyRegenerateContent IJsonModel<MachineLearningEndpointKeyRegenerateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointKeyRegenerateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEndpointKeyRegenerateContent(document.RootElement, options);
        }

        internal static MachineLearningEndpointKeyRegenerateContent DeserializeMachineLearningEndpointKeyRegenerateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningKeyType keyType = default;
            Optional<string> keyValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyType"u8))
                {
                    keyType = new MachineLearningKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyValue = null;
                        continue;
                    }
                    keyValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningEndpointKeyRegenerateContent(keyType, keyValue.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningEndpointKeyRegenerateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEndpointKeyRegenerateContent)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningEndpointKeyRegenerateContent IPersistableModel<MachineLearningEndpointKeyRegenerateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningEndpointKeyRegenerateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEndpointKeyRegenerateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningEndpointKeyRegenerateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
