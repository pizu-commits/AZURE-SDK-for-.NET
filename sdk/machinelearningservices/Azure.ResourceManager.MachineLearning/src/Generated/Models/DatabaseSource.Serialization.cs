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
    public partial class DatabaseSource : IUtf8JsonSerializable, IJsonModel<DatabaseSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DatabaseSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseSource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                if (Query != null)
                {
                    writer.WritePropertyName("query"u8);
                    writer.WriteStringValue(Query);
                }
                else
                {
                    writer.WriteNull("query");
                }
            }
            if (Optional.IsDefined(StoredProcedure))
            {
                if (StoredProcedure != null)
                {
                    writer.WritePropertyName("storedProcedure"u8);
                    writer.WriteStringValue(StoredProcedure);
                }
                else
                {
                    writer.WriteNull("storedProcedure");
                }
            }
            if (Optional.IsCollectionDefined(StoredProcedureParams))
            {
                if (StoredProcedureParams != null)
                {
                    writer.WritePropertyName("storedProcedureParams"u8);
                    writer.WriteStartArray();
                    foreach (var item in StoredProcedureParams)
                    {
                        if (item == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStartObject();
                        foreach (var item0 in item)
                        {
                            writer.WritePropertyName(item0.Key);
                            writer.WriteStringValue(item0.Value);
                        }
                        writer.WriteEndObject();
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("storedProcedureParams");
                }
            }
            if (Optional.IsDefined(TableName))
            {
                if (TableName != null)
                {
                    writer.WritePropertyName("tableName"u8);
                    writer.WriteStringValue(TableName);
                }
                else
                {
                    writer.WriteNull("tableName");
                }
            }
            if (Optional.IsDefined(Connection))
            {
                if (Connection != null)
                {
                    writer.WritePropertyName("connection"u8);
                    writer.WriteStringValue(Connection);
                }
                else
                {
                    writer.WriteNull("connection");
                }
            }
            writer.WritePropertyName("sourceType"u8);
            writer.WriteStringValue(SourceType.ToString());
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

        DatabaseSource IJsonModel<DatabaseSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseSource(document.RootElement, options);
        }

        internal static DatabaseSource DeserializeDatabaseSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string query = default;
            string storedProcedure = default;
            IList<IDictionary<string, string>> storedProcedureParams = default;
            string tableName = default;
            string connection = default;
            DataImportSourceType sourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        query = null;
                        continue;
                    }
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storedProcedure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storedProcedure = null;
                        continue;
                    }
                    storedProcedure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storedProcedureParams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storedProcedureParams = null;
                        continue;
                    }
                    List<IDictionary<string, string>> array = new List<IDictionary<string, string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property0 in item.EnumerateObject())
                            {
                                dictionary.Add(property0.Name, property0.Value.GetString());
                            }
                            array.Add(dictionary);
                        }
                    }
                    storedProcedureParams = array;
                    continue;
                }
                if (property.NameEquals("tableName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tableName = null;
                        continue;
                    }
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connection = null;
                        continue;
                    }
                    connection = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceType"u8))
                {
                    sourceType = new DataImportSourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DatabaseSource(
                connection,
                sourceType,
                serializedAdditionalRawData,
                query,
                storedProcedure,
                storedProcedureParams ?? new ChangeTrackingList<IDictionary<string, string>>(),
                tableName);
        }

        BinaryData IPersistableModel<DatabaseSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseSource)} does not support writing '{options.Format}' format.");
            }
        }

        DatabaseSource IPersistableModel<DatabaseSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
