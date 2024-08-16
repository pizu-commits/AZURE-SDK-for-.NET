// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    public partial class TemperatureResolution : IUtf8JsonSerializable, IJsonModel<TemperatureResolution>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TemperatureResolution>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TemperatureResolution>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemperatureResolution>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemperatureResolution)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("unit"u8);
            writer.WriteStringValue(Unit.ToString());
            writer.WritePropertyName("resolutionKind"u8);
            writer.WriteStringValue(ResolutionKind.ToString());
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

        TemperatureResolution IJsonModel<TemperatureResolution>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemperatureResolution>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemperatureResolution)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTemperatureResolution(document.RootElement, options);
        }

        internal static TemperatureResolution DeserializeTemperatureResolution(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double value = default;
            TemperatureUnit unit = default;
            ResolutionKind resolutionKind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = new TemperatureUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolutionKind"u8))
                {
                    resolutionKind = new ResolutionKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TemperatureResolution(resolutionKind, serializedAdditionalRawData, value, unit);
        }

        BinaryData IPersistableModel<TemperatureResolution>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemperatureResolution>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TemperatureResolution)} does not support writing '{options.Format}' format.");
            }
        }

        TemperatureResolution IPersistableModel<TemperatureResolution>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemperatureResolution>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTemperatureResolution(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TemperatureResolution)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TemperatureResolution>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TemperatureResolution FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTemperatureResolution(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
