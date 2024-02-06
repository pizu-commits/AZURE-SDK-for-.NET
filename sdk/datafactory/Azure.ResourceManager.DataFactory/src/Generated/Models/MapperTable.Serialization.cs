// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class MapperTable : IUtf8JsonSerializable, IJsonModel<MapperTable>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapperTable>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MapperTable>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapperTable)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteStartArray();
                foreach (var item in Schema)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DslConnectorProperties))
            {
                writer.WritePropertyName("dslConnectorProperties"u8);
                writer.WriteStartArray();
                foreach (var item in DslConnectorProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        MapperTable IJsonModel<MapperTable>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapperTable)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapperTable(document.RootElement, options);
        }

        internal static MapperTable DeserializeMapperTable(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IList<MapperTableSchema>> schema = default;
            Optional<IList<MapperDslConnectorProperties>> dslConnectorProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("schema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MapperTableSchema> array = new List<MapperTableSchema>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MapperTableSchema.DeserializeMapperTableSchema(item));
                            }
                            schema = array;
                            continue;
                        }
                        if (property0.NameEquals("dslConnectorProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MapperDslConnectorProperties> array = new List<MapperDslConnectorProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MapperDslConnectorProperties.DeserializeMapperDslConnectorProperties(item));
                            }
                            dslConnectorProperties = array;
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
            return new MapperTable(name.Value, Optional.ToList(schema), Optional.ToList(dslConnectorProperties), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapperTable>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MapperTable)} does not support '{options.Format}' format.");
            }
        }

        MapperTable IPersistableModel<MapperTable>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMapperTable(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MapperTable)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MapperTable>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
