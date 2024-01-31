// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class CsvFormatSerialization : IUtf8JsonSerializable, IJsonModel<CsvFormatSerialization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CsvFormatSerialization>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CsvFormatSerialization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvFormatSerialization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CsvFormatSerialization)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(EventSerializationType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(FieldDelimiter))
            {
                writer.WritePropertyName("fieldDelimiter"u8);
                writer.WriteStringValue(FieldDelimiter);
            }
            if (Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteStringValue(Encoding.Value.ToString());
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

        CsvFormatSerialization IJsonModel<CsvFormatSerialization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvFormatSerialization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CsvFormatSerialization)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCsvFormatSerialization(document.RootElement, options);
        }

        internal static CsvFormatSerialization DeserializeCsvFormatSerialization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EventSerializationType type = default;
            Optional<string> fieldDelimiter = default;
            Optional<StreamAnalyticsDataSerializationEncoding> encoding = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new EventSerializationType(property.Value.GetString());
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
                        if (property0.NameEquals("fieldDelimiter"u8))
                        {
                            fieldDelimiter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encoding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encoding = new StreamAnalyticsDataSerializationEncoding(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CsvFormatSerialization(type, serializedAdditionalRawData, fieldDelimiter.Value, Optional.ToNullable(encoding));
        }

        BinaryData IPersistableModel<CsvFormatSerialization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvFormatSerialization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CsvFormatSerialization)} does not support '{options.Format}' format.");
            }
        }

        CsvFormatSerialization IPersistableModel<CsvFormatSerialization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvFormatSerialization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCsvFormatSerialization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CsvFormatSerialization)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CsvFormatSerialization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
