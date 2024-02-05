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

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlTempDBSettings : IUtf8JsonSerializable, IJsonModel<SqlTempDBSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlTempDBSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlTempDBSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlTempDBSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlTempDBSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DataFileSize))
            {
                writer.WritePropertyName("dataFileSize"u8);
                writer.WriteNumberValue(DataFileSize.Value);
            }
            if (Optional.IsDefined(DataGrowth))
            {
                writer.WritePropertyName("dataGrowth"u8);
                writer.WriteNumberValue(DataGrowth.Value);
            }
            if (Optional.IsDefined(LogFileSize))
            {
                writer.WritePropertyName("logFileSize"u8);
                writer.WriteNumberValue(LogFileSize.Value);
            }
            if (Optional.IsDefined(LogGrowth))
            {
                writer.WritePropertyName("logGrowth"u8);
                writer.WriteNumberValue(LogGrowth.Value);
            }
            if (Optional.IsDefined(DataFileCount))
            {
                writer.WritePropertyName("dataFileCount"u8);
                writer.WriteNumberValue(DataFileCount.Value);
            }
            if (Optional.IsDefined(PersistFolder))
            {
                writer.WritePropertyName("persistFolder"u8);
                writer.WriteBooleanValue(PersistFolder.Value);
            }
            if (Optional.IsDefined(PersistFolderPath))
            {
                writer.WritePropertyName("persistFolderPath"u8);
                writer.WriteStringValue(PersistFolderPath);
            }
            if (Optional.IsCollectionDefined(LogicalUnitNumbers))
            {
                writer.WritePropertyName("luns"u8);
                writer.WriteStartArray();
                foreach (var item in LogicalUnitNumbers)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultFilePath))
            {
                writer.WritePropertyName("defaultFilePath"u8);
                writer.WriteStringValue(DefaultFilePath);
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

        SqlTempDBSettings IJsonModel<SqlTempDBSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlTempDBSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlTempDBSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlTempDBSettings(document.RootElement, options);
        }

        internal static SqlTempDBSettings DeserializeSqlTempDBSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> dataFileSize = default;
            Optional<int> dataGrowth = default;
            Optional<int> logFileSize = default;
            Optional<int> logGrowth = default;
            Optional<int> dataFileCount = default;
            Optional<bool> persistFolder = default;
            Optional<string> persistFolderPath = default;
            Optional<IList<int>> luns = default;
            Optional<string> defaultFilePath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataFileSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFileSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataGrowth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataGrowth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logFileSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logFileSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logGrowth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logGrowth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFileCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFileCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("persistFolder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    persistFolder = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("persistFolderPath"u8))
                {
                    persistFolderPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("luns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    luns = array;
                    continue;
                }
                if (property.NameEquals("defaultFilePath"u8))
                {
                    defaultFilePath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlTempDBSettings(Optional.ToNullable(dataFileSize), Optional.ToNullable(dataGrowth), Optional.ToNullable(logFileSize), Optional.ToNullable(logGrowth), Optional.ToNullable(dataFileCount), Optional.ToNullable(persistFolder), persistFolderPath.Value, Optional.ToList(luns), defaultFilePath.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(DataFileSize))
            {
                builder.Append("  dataFileSize:");
                builder.AppendLine($" {DataFileSize.Value}");
            }

            if (Optional.IsDefined(DataGrowth))
            {
                builder.Append("  dataGrowth:");
                builder.AppendLine($" {DataGrowth.Value}");
            }

            if (Optional.IsDefined(LogFileSize))
            {
                builder.Append("  logFileSize:");
                builder.AppendLine($" {LogFileSize.Value}");
            }

            if (Optional.IsDefined(LogGrowth))
            {
                builder.Append("  logGrowth:");
                builder.AppendLine($" {LogGrowth.Value}");
            }

            if (Optional.IsDefined(DataFileCount))
            {
                builder.Append("  dataFileCount:");
                builder.AppendLine($" {DataFileCount.Value}");
            }

            if (Optional.IsDefined(PersistFolder))
            {
                builder.Append("  persistFolder:");
                var boolValue = PersistFolder.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(PersistFolderPath))
            {
                builder.Append("  persistFolderPath:");
                builder.AppendLine($" '{PersistFolderPath}'");
            }

            if (Optional.IsCollectionDefined(LogicalUnitNumbers))
            {
                if (LogicalUnitNumbers.Any())
                {
                    builder.Append("  luns:");
                    builder.AppendLine(" [");
                    foreach (var item in LogicalUnitNumbers)
                    {
                        builder.AppendLine($"    {item}");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(DefaultFilePath))
            {
                builder.Append("  defaultFilePath:");
                builder.AppendLine($" '{DefaultFilePath}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<SqlTempDBSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlTempDBSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SqlTempDBSettings)} does not support '{options.Format}' format.");
            }
        }

        SqlTempDBSettings IPersistableModel<SqlTempDBSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlTempDBSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlTempDBSettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SqlTempDBSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlTempDBSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
