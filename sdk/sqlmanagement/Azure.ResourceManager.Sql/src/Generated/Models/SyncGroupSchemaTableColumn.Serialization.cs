// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupSchemaTableColumn : IUtf8JsonSerializable, IJsonModel<SyncGroupSchemaTableColumn>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncGroupSchemaTableColumn>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncGroupSchemaTableColumn>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupSchemaTableColumn)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(QuotedName))
            {
                writer.WritePropertyName("quotedName"u8);
                writer.WriteStringValue(QuotedName);
            }
            if (Optional.IsDefined(DataSize))
            {
                writer.WritePropertyName("dataSize"u8);
                writer.WriteStringValue(DataSize);
            }
            if (Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
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

        SyncGroupSchemaTableColumn IJsonModel<SyncGroupSchemaTableColumn>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupSchemaTableColumn)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncGroupSchemaTableColumn(document.RootElement, options);
        }

        internal static SyncGroupSchemaTableColumn DeserializeSyncGroupSchemaTableColumn(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string quotedName = default;
            string dataSize = default;
            string dataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quotedName"u8))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSize"u8))
                {
                    dataSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncGroupSchemaTableColumn(quotedName, dataSize, dataType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyncGroupSchemaTableColumn>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyncGroupSchemaTableColumn)} does not support '{options.Format}' format.");
            }
        }

        SyncGroupSchemaTableColumn IPersistableModel<SyncGroupSchemaTableColumn>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchemaTableColumn>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncGroupSchemaTableColumn(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncGroupSchemaTableColumn)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncGroupSchemaTableColumn>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
