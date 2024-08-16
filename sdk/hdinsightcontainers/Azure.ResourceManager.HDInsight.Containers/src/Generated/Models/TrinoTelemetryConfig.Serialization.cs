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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class TrinoTelemetryConfig : IUtf8JsonSerializable, IJsonModel<TrinoTelemetryConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrinoTelemetryConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TrinoTelemetryConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoTelemetryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrinoTelemetryConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HivecatalogName))
            {
                writer.WritePropertyName("hivecatalogName"u8);
                writer.WriteStringValue(HivecatalogName);
            }
            if (Optional.IsDefined(HivecatalogSchema))
            {
                writer.WritePropertyName("hivecatalogSchema"u8);
                writer.WriteStringValue(HivecatalogSchema);
            }
            if (Optional.IsDefined(PartitionRetentionInDays))
            {
                writer.WritePropertyName("partitionRetentionInDays"u8);
                writer.WriteNumberValue(PartitionRetentionInDays.Value);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
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

        TrinoTelemetryConfig IJsonModel<TrinoTelemetryConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoTelemetryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrinoTelemetryConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrinoTelemetryConfig(document.RootElement, options);
        }

        internal static TrinoTelemetryConfig DeserializeTrinoTelemetryConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hivecatalogName = default;
            string hivecatalogSchema = default;
            int? partitionRetentionInDays = default;
            string path = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hivecatalogName"u8))
                {
                    hivecatalogName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hivecatalogSchema"u8))
                {
                    hivecatalogSchema = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partitionRetentionInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionRetentionInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TrinoTelemetryConfig(hivecatalogName, hivecatalogSchema, partitionRetentionInDays, path, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HivecatalogName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hivecatalogName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HivecatalogName))
                {
                    builder.Append("  hivecatalogName: ");
                    if (HivecatalogName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HivecatalogName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HivecatalogName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HivecatalogSchema), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hivecatalogSchema: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HivecatalogSchema))
                {
                    builder.Append("  hivecatalogSchema: ");
                    if (HivecatalogSchema.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HivecatalogSchema}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HivecatalogSchema}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartitionRetentionInDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partitionRetentionInDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartitionRetentionInDays))
                {
                    builder.Append("  partitionRetentionInDays: ");
                    builder.AppendLine($"{PartitionRetentionInDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Path), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  path: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Path))
                {
                    builder.Append("  path: ");
                    if (Path.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Path}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Path}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<TrinoTelemetryConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoTelemetryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TrinoTelemetryConfig)} does not support writing '{options.Format}' format.");
            }
        }

        TrinoTelemetryConfig IPersistableModel<TrinoTelemetryConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoTelemetryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrinoTelemetryConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrinoTelemetryConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrinoTelemetryConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
