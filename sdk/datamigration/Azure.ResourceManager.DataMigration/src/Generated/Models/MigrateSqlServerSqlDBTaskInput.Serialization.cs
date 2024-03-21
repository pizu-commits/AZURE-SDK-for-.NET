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
    public partial class MigrateSqlServerSqlDBTaskInput : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlDBTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlDBTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlDBTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ValidationOptions))
            {
                writer.WritePropertyName("validationOptions"u8);
                writer.WriteObjectValue(ValidationOptions);
            }
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn);
            }
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
            }
            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo"u8);
            writer.WriteObjectValue(TargetConnectionInfo);
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

        MigrateSqlServerSqlDBTaskInput IJsonModel<MigrateSqlServerSqlDBTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskInput(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlDBTaskInput DeserializeMigrateSqlServerSqlDBTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSqlServerSqlDBDatabaseInput> selectedDatabases = default;
            MigrationValidationOptions validationOptions = default;
            string startedOn = default;
            string encryptedKeyForSecureFields = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlDBDatabaseInput> array = new List<MigrateSqlServerSqlDBDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlDBDatabaseInput.DeserializeMigrateSqlServerSqlDBDatabaseInput(item, options));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("validationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationOptions = MigrationValidationOptions.DeserializeMigrationValidationOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    startedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlServerSqlDBTaskInput(
                sourceConnectionInfo,
                targetConnectionInfo,
                serializedAdditionalRawData,
                selectedDatabases,
                validationOptions,
                startedOn,
                encryptedKeyForSecureFields);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlDBTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskInput)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlDBTaskInput IPersistableModel<MigrateSqlServerSqlDBTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlDBTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlDBTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
