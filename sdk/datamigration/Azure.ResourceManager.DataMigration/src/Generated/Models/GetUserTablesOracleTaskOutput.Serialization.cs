// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesOracleTaskOutput : IUtf8JsonSerializable, IJsonModel<GetUserTablesOracleTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetUserTablesOracleTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetUserTablesOracleTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesOracleTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            if (options.Format != "W" && !(Tables is ChangeTrackingList<DatabaseTable> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tables"u8);
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(ValidationErrors is ChangeTrackingList<ReportableException> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        GetUserTablesOracleTaskOutput IJsonModel<GetUserTablesOracleTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesOracleTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetUserTablesOracleTaskOutput(document.RootElement, options);
        }

        internal static GetUserTablesOracleTaskOutput DeserializeGetUserTablesOracleTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> schemaName = default;
            Optional<IReadOnlyList<DatabaseTable>> tables = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatabaseTable> array = new List<DatabaseTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseTable.DeserializeDatabaseTable(item, options));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    validationErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetUserTablesOracleTaskOutput(schemaName.Value, Optional.ToList(tables), Optional.ToList(validationErrors), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetUserTablesOracleTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesOracleTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        GetUserTablesOracleTaskOutput IPersistableModel<GetUserTablesOracleTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetUserTablesOracleTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesOracleTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetUserTablesOracleTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
