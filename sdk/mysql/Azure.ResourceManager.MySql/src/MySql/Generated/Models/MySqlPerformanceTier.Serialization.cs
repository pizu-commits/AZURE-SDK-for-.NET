// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlPerformanceTier : IUtf8JsonSerializable, IJsonModel<MySqlPerformanceTier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlPerformanceTier>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlPerformanceTier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlPerformanceTier)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(MaxBackupRetentionDays))
            {
                writer.WritePropertyName("maxBackupRetentionDays"u8);
                writer.WriteNumberValue(MaxBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MinBackupRetentionDays))
            {
                writer.WritePropertyName("minBackupRetentionDays"u8);
                writer.WriteNumberValue(MinBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MaxStorageInMB))
            {
                writer.WritePropertyName("maxStorageMB"u8);
                writer.WriteNumberValue(MaxStorageInMB.Value);
            }
            if (Optional.IsDefined(MinLargeStorageInMB))
            {
                writer.WritePropertyName("minLargeStorageMB"u8);
                writer.WriteNumberValue(MinLargeStorageInMB.Value);
            }
            if (Optional.IsDefined(MaxLargeStorageInMB))
            {
                writer.WritePropertyName("maxLargeStorageMB"u8);
                writer.WriteNumberValue(MaxLargeStorageInMB.Value);
            }
            if (Optional.IsDefined(MinStorageInMB))
            {
                writer.WritePropertyName("minStorageMB"u8);
                writer.WriteNumberValue(MinStorageInMB.Value);
            }
            if (Optional.IsCollectionDefined(ServiceLevelObjectives))
            {
                writer.WritePropertyName("serviceLevelObjectives"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLevelObjectives)
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

        MySqlPerformanceTier IJsonModel<MySqlPerformanceTier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlPerformanceTier)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlPerformanceTier(document.RootElement, options);
        }

        internal static MySqlPerformanceTier DeserializeMySqlPerformanceTier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            int? maxBackupRetentionDays = default;
            int? minBackupRetentionDays = default;
            int? maxStorageMB = default;
            int? minLargeStorageMB = default;
            int? maxLargeStorageMB = default;
            int? minStorageMB = default;
            IReadOnlyList<MySqlPerformanceTierServiceLevelObjectives> serviceLevelObjectives = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLargeStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLargeStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceLevelObjectives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlPerformanceTierServiceLevelObjectives> array = new List<MySqlPerformanceTierServiceLevelObjectives>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlPerformanceTierServiceLevelObjectives.DeserializeMySqlPerformanceTierServiceLevelObjectives(item, options));
                    }
                    serviceLevelObjectives = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlPerformanceTier(
                id,
                maxBackupRetentionDays,
                minBackupRetentionDays,
                maxStorageMB,
                minLargeStorageMB,
                maxLargeStorageMB,
                minStorageMB,
                serviceLevelObjectives ?? new ChangeTrackingList<MySqlPerformanceTierServiceLevelObjectives>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (Optional.IsDefined(Id) || hasPropertyOverride)
            {
                builder.Append("  id: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Id.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Id}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Id}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxBackupRetentionDays), out propertyOverride);
            if (Optional.IsDefined(MaxBackupRetentionDays) || hasPropertyOverride)
            {
                builder.Append("  maxBackupRetentionDays: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MaxBackupRetentionDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinBackupRetentionDays), out propertyOverride);
            if (Optional.IsDefined(MinBackupRetentionDays) || hasPropertyOverride)
            {
                builder.Append("  minBackupRetentionDays: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MinBackupRetentionDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxStorageInMB), out propertyOverride);
            if (Optional.IsDefined(MaxStorageInMB) || hasPropertyOverride)
            {
                builder.Append("  maxStorageMB: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MaxStorageInMB.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinLargeStorageInMB), out propertyOverride);
            if (Optional.IsDefined(MinLargeStorageInMB) || hasPropertyOverride)
            {
                builder.Append("  minLargeStorageMB: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MinLargeStorageInMB.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxLargeStorageInMB), out propertyOverride);
            if (Optional.IsDefined(MaxLargeStorageInMB) || hasPropertyOverride)
            {
                builder.Append("  maxLargeStorageMB: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MaxLargeStorageInMB.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinStorageInMB), out propertyOverride);
            if (Optional.IsDefined(MinStorageInMB) || hasPropertyOverride)
            {
                builder.Append("  minStorageMB: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{MinStorageInMB.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceLevelObjectives), out propertyOverride);
            if (Optional.IsCollectionDefined(ServiceLevelObjectives) || hasPropertyOverride)
            {
                if (ServiceLevelObjectives.Any() || hasPropertyOverride)
                {
                    builder.Append("  serviceLevelObjectives: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in ServiceLevelObjectives)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  serviceLevelObjectives: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<MySqlPerformanceTier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MySqlPerformanceTier)} does not support '{options.Format}' format.");
            }
        }

        MySqlPerformanceTier IPersistableModel<MySqlPerformanceTier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlPerformanceTier(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MySqlPerformanceTier)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlPerformanceTier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
