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
    public partial class PeriodicModeProperties : IUtf8JsonSerializable, IJsonModel<PeriodicModeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeriodicModeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeriodicModeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicModeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeriodicModeProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupIntervalInMinutes))
            {
                writer.WritePropertyName("backupIntervalInMinutes"u8);
                writer.WriteNumberValue(BackupIntervalInMinutes.Value);
            }
            if (Optional.IsDefined(BackupRetentionIntervalInHours))
            {
                writer.WritePropertyName("backupRetentionIntervalInHours"u8);
                writer.WriteNumberValue(BackupRetentionIntervalInHours.Value);
            }
            if (Optional.IsDefined(BackupStorageRedundancy))
            {
                writer.WritePropertyName("backupStorageRedundancy"u8);
                writer.WriteStringValue(BackupStorageRedundancy.Value.ToString());
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

        PeriodicModeProperties IJsonModel<PeriodicModeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicModeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeriodicModeProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeriodicModeProperties(document.RootElement, options);
        }

        internal static PeriodicModeProperties DeserializePeriodicModeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> backupIntervalInMinutes = default;
            Optional<int> backupRetentionIntervalInHours = default;
            Optional<CosmosDBBackupStorageRedundancy> backupStorageRedundancy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupIntervalInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupIntervalInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupRetentionIntervalInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupRetentionIntervalInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupStorageRedundancy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStorageRedundancy = new CosmosDBBackupStorageRedundancy(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeriodicModeProperties(Optional.ToNullable(backupIntervalInMinutes), Optional.ToNullable(backupRetentionIntervalInHours), Optional.ToNullable(backupStorageRedundancy), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeriodicModeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicModeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeriodicModeProperties)} does not support '{options.Format}' format.");
            }
        }

        PeriodicModeProperties IPersistableModel<PeriodicModeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicModeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeriodicModeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeriodicModeProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeriodicModeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
