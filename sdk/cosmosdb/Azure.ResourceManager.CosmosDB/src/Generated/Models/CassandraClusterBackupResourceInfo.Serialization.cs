// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterBackupResourceInfo : IUtf8JsonSerializable, IJsonModel<CassandraClusterBackupResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterBackupResourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CassandraClusterBackupResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupId))
            {
                writer.WritePropertyName("backupId"u8);
                writer.WriteStringValue(BackupId);
            }
            if (Optional.IsDefined(BackupState))
            {
                writer.WritePropertyName("backupState"u8);
                writer.WriteStringValue(BackupState.Value.ToString());
            }
            if (Optional.IsDefined(BackupStartTimestamp))
            {
                writer.WritePropertyName("backupStartTimestamp"u8);
                writer.WriteStringValue(BackupStartTimestamp.Value, "O");
            }
            if (Optional.IsDefined(BackupStopTimestamp))
            {
                writer.WritePropertyName("backupStopTimestamp"u8);
                writer.WriteStringValue(BackupStopTimestamp.Value, "O");
            }
            if (Optional.IsDefined(BackupExpiryTimestamp))
            {
                writer.WritePropertyName("backupExpiryTimestamp"u8);
                writer.WriteStringValue(BackupExpiryTimestamp.Value, "O");
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

        CassandraClusterBackupResourceInfo IJsonModel<CassandraClusterBackupResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterBackupResourceInfo(document.RootElement, options);
        }

        internal static CassandraClusterBackupResourceInfo DeserializeCassandraClusterBackupResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string backupId = default;
            CassandraClusterBackupState? backupState = default;
            DateTimeOffset? backupStartTimestamp = default;
            DateTimeOffset? backupStopTimestamp = default;
            DateTimeOffset? backupExpiryTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupId"u8))
                {
                    backupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupState = new CassandraClusterBackupState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupStartTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStartTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupStopTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStopTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupExpiryTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupExpiryTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CassandraClusterBackupResourceInfo(
                backupId,
                backupState,
                backupStartTimestamp,
                backupStopTimestamp,
                backupExpiryTimestamp,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackupId))
                {
                    builder.Append("  backupId: ");
                    if (BackupId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BackupId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BackupId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackupState))
                {
                    builder.Append("  backupState: ");
                    builder.AppendLine($"'{BackupState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupStartTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupStartTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackupStartTimestamp))
                {
                    builder.Append("  backupStartTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(BackupStartTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupStopTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupStopTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackupStopTimestamp))
                {
                    builder.Append("  backupStopTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(BackupStopTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupExpiryTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupExpiryTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackupExpiryTimestamp))
                {
                    builder.Append("  backupExpiryTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(BackupExpiryTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CassandraClusterBackupResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        CassandraClusterBackupResourceInfo IPersistableModel<CassandraClusterBackupResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterBackupResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterBackupResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
