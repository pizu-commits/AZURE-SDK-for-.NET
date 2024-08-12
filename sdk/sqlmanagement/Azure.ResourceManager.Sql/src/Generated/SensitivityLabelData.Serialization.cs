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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SensitivityLabelData : IUtf8JsonSerializable, IJsonModel<SensitivityLabelData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SensitivityLabelData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SensitivityLabelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivityLabelData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            if (options.Format != "W" && Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (options.Format != "W" && Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName"u8);
                writer.WriteStringValue(ColumnName);
            }
            if (Optional.IsDefined(LabelName))
            {
                writer.WritePropertyName("labelName"u8);
                writer.WriteStringValue(LabelName);
            }
            if (Optional.IsDefined(LabelId))
            {
                writer.WritePropertyName("labelId"u8);
                writer.WriteStringValue(LabelId);
            }
            if (Optional.IsDefined(InformationType))
            {
                writer.WritePropertyName("informationType"u8);
                writer.WriteStringValue(InformationType);
            }
            if (Optional.IsDefined(InformationTypeId))
            {
                writer.WritePropertyName("informationTypeId"u8);
                writer.WriteStringValue(InformationTypeId);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDisabled))
            {
                writer.WritePropertyName("isDisabled"u8);
                writer.WriteBooleanValue(IsDisabled.Value);
            }
            if (Optional.IsDefined(Rank))
            {
                writer.WritePropertyName("rank"u8);
                writer.WriteStringValue(Rank.Value.ToSerialString());
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

        SensitivityLabelData IJsonModel<SensitivityLabelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivityLabelData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSensitivityLabelData(document.RootElement, options);
        }

        internal static SensitivityLabelData DeserializeSensitivityLabelData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string managedBy = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string schemaName = default;
            string tableName = default;
            string columnName = default;
            string labelName = default;
            string labelId = default;
            string informationType = default;
            string informationTypeId = default;
            bool? isDisabled = default;
            SensitivityLabelRank? rank = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("schemaName"u8))
                        {
                            schemaName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"u8))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("columnName"u8))
                        {
                            columnName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labelName"u8))
                        {
                            labelName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labelId"u8))
                        {
                            labelId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("informationType"u8))
                        {
                            informationType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("informationTypeId"u8))
                        {
                            informationTypeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDisabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("rank"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rank = property0.Value.GetString().ToSensitivityLabelRank();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SensitivityLabelData(
                id,
                name,
                type,
                systemData,
                managedBy,
                schemaName,
                tableName,
                columnName,
                labelName,
                labelId,
                informationType,
                informationTypeId,
                isDisabled,
                rank,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  managedBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ManagedBy))
                {
                    builder.Append("  managedBy: ");
                    if (ManagedBy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ManagedBy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ManagedBy}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SchemaName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    schemaName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SchemaName))
                {
                    builder.Append("    schemaName: ");
                    if (SchemaName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SchemaName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SchemaName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TableName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    tableName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TableName))
                {
                    builder.Append("    tableName: ");
                    if (TableName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TableName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TableName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    columnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ColumnName))
                {
                    builder.Append("    columnName: ");
                    if (ColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ColumnName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LabelName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    labelName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LabelName))
                {
                    builder.Append("    labelName: ");
                    if (LabelName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LabelName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LabelName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LabelId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    labelId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LabelId))
                {
                    builder.Append("    labelId: ");
                    if (LabelId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LabelId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LabelId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InformationType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    informationType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InformationType))
                {
                    builder.Append("    informationType: ");
                    if (InformationType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{InformationType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{InformationType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InformationTypeId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    informationTypeId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InformationTypeId))
                {
                    builder.Append("    informationTypeId: ");
                    if (InformationTypeId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{InformationTypeId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{InformationTypeId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDisabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isDisabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDisabled))
                {
                    builder.Append("    isDisabled: ");
                    var boolValue = IsDisabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rank), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rank: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Rank))
                {
                    builder.Append("    rank: ");
                    builder.AppendLine($"'{Rank.Value.ToSerialString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SensitivityLabelData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SensitivityLabelData)} does not support writing '{options.Format}' format.");
            }
        }

        SensitivityLabelData IPersistableModel<SensitivityLabelData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivityLabelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSensitivityLabelData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SensitivityLabelData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SensitivityLabelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
