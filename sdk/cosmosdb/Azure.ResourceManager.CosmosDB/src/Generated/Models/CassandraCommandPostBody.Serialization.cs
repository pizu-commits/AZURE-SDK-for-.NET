// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraCommandPostBody : IUtf8JsonSerializable, IJsonModel<CassandraCommandPostBody>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraCommandPostBody>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraCommandPostBody>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraCommandPostBody>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraCommandPostBody)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("command"u8);
            writer.WriteStringValue(Command);
            if (!(Arguments is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartObject();
                foreach (var item in Arguments)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("host"u8);
            writer.WriteStringValue(Host);
            if (Optional.IsDefined(CassandraStopStart))
            {
                writer.WritePropertyName("cassandra-stop-start"u8);
                writer.WriteBooleanValue(CassandraStopStart.Value);
            }
            if (Optional.IsDefined(AllowWrite))
            {
                writer.WritePropertyName("readwrite"u8);
                writer.WriteBooleanValue(AllowWrite.Value);
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

        CassandraCommandPostBody IJsonModel<CassandraCommandPostBody>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraCommandPostBody>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraCommandPostBody)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraCommandPostBody(document.RootElement, options);
        }

        internal static CassandraCommandPostBody DeserializeCassandraCommandPostBody(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string command = default;
            Optional<IDictionary<string, string>> arguments = default;
            string host = default;
            Optional<bool> cassandraStopStart = default;
            Optional<bool> readwrite = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("command"u8))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    arguments = dictionary;
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cassandra-stop-start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cassandraStopStart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readwrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readwrite = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraCommandPostBody(command, Optional.ToDictionary(arguments), host, Optional.ToNullable(cassandraStopStart), Optional.ToNullable(readwrite), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraCommandPostBody>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraCommandPostBody>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraCommandPostBody)} does not support '{options.Format}' format.");
            }
        }

        CassandraCommandPostBody IPersistableModel<CassandraCommandPostBody>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraCommandPostBody>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraCommandPostBody(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraCommandPostBody)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraCommandPostBody>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
