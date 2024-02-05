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

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringSpaceSavings : IUtf8JsonSerializable, IJsonModel<CloudTieringSpaceSavings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudTieringSpaceSavings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudTieringSpaceSavings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(VolumeSizeInBytes))
            {
                writer.WritePropertyName("volumeSizeBytes"u8);
                writer.WriteNumberValue(VolumeSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CloudTotalSizeInBytes))
            {
                writer.WritePropertyName("totalSizeCloudBytes"u8);
                writer.WriteNumberValue(CloudTotalSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CachedSizeInBytes))
            {
                writer.WritePropertyName("cachedSizeBytes"u8);
                writer.WriteNumberValue(CachedSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SpaceSavingsPercent))
            {
                writer.WritePropertyName("spaceSavingsPercent"u8);
                writer.WriteNumberValue(SpaceSavingsPercent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SpaceSavingsInBytes))
            {
                writer.WritePropertyName("spaceSavingsBytes"u8);
                writer.WriteNumberValue(SpaceSavingsInBytes.Value);
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

        CloudTieringSpaceSavings IJsonModel<CloudTieringSpaceSavings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringSpaceSavings(document.RootElement, options);
        }

        internal static CloudTieringSpaceSavings DeserializeCloudTieringSpaceSavings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<long> volumeSizeBytes = default;
            Optional<long> totalSizeCloudBytes = default;
            Optional<long> cachedSizeBytes = default;
            Optional<int> spaceSavingsPercent = default;
            Optional<long> spaceSavingsBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("volumeSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumeSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalSizeCloudBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSizeCloudBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cachedSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cachedSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spaceSavingsPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spaceSavingsPercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("spaceSavingsBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spaceSavingsBytes = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudTieringSpaceSavings(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(volumeSizeBytes), Optional.ToNullable(totalSizeCloudBytes), Optional.ToNullable(cachedSizeBytes), Optional.ToNullable(spaceSavingsPercent), Optional.ToNullable(spaceSavingsBytes), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(LastUpdatedOn))
            {
                builder.Append("  lastUpdatedTimestamp:");
                var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(VolumeSizeInBytes))
            {
                builder.Append("  volumeSizeBytes:");
                builder.AppendLine($" '{VolumeSizeInBytes.Value.ToString()}'");
            }

            if (Optional.IsDefined(CloudTotalSizeInBytes))
            {
                builder.Append("  totalSizeCloudBytes:");
                builder.AppendLine($" '{CloudTotalSizeInBytes.Value.ToString()}'");
            }

            if (Optional.IsDefined(CachedSizeInBytes))
            {
                builder.Append("  cachedSizeBytes:");
                builder.AppendLine($" '{CachedSizeInBytes.Value.ToString()}'");
            }

            if (Optional.IsDefined(SpaceSavingsPercent))
            {
                builder.Append("  spaceSavingsPercent:");
                builder.AppendLine($" {SpaceSavingsPercent.Value}");
            }

            if (Optional.IsDefined(SpaceSavingsInBytes))
            {
                builder.Append("  spaceSavingsBytes:");
                builder.AppendLine($" '{SpaceSavingsInBytes.Value.ToString()}'");
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

        BinaryData IPersistableModel<CloudTieringSpaceSavings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{options.Format}' format.");
            }
        }

        CloudTieringSpaceSavings IPersistableModel<CloudTieringSpaceSavings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudTieringSpaceSavings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudTieringSpaceSavings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
