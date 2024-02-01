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
    public partial class CloudEndpointChangeEnumerationActivity : IUtf8JsonSerializable, IJsonModel<CloudEndpointChangeEnumerationActivity>, IPersistableModel<CloudEndpointChangeEnumerationActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudEndpointChangeEnumerationActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudEndpointChangeEnumerationActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointChangeEnumerationActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointChangeEnumerationActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(OperationState))
            {
                writer.WritePropertyName("operationState"u8);
                writer.WriteStringValue(OperationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StatusCode))
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteNumberValue(StatusCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedTimestamp"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProcessedFilesCount))
            {
                writer.WritePropertyName("processedFilesCount"u8);
                writer.WriteNumberValue(ProcessedFilesCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProcessedDirectoriesCount))
            {
                writer.WritePropertyName("processedDirectoriesCount"u8);
                writer.WriteNumberValue(ProcessedDirectoriesCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalFilesCount))
            {
                writer.WritePropertyName("totalFilesCount"u8);
                writer.WriteNumberValue(TotalFilesCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalDirectoriesCount))
            {
                writer.WritePropertyName("totalDirectoriesCount"u8);
                writer.WriteNumberValue(TotalDirectoriesCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalSizeInBytes))
            {
                writer.WritePropertyName("totalSizeBytes"u8);
                writer.WriteNumberValue(TotalSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProgressPercent))
            {
                writer.WritePropertyName("progressPercent"u8);
                writer.WriteNumberValue(ProgressPercent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MinutesRemaining))
            {
                writer.WritePropertyName("minutesRemaining"u8);
                writer.WriteNumberValue(MinutesRemaining.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalCountsState))
            {
                writer.WritePropertyName("totalCountsState"u8);
                writer.WriteStringValue(TotalCountsState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DeletesProgressPercent))
            {
                writer.WritePropertyName("deletesProgressPercent"u8);
                writer.WriteNumberValue(DeletesProgressPercent.Value);
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

        CloudEndpointChangeEnumerationActivity IJsonModel<CloudEndpointChangeEnumerationActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointChangeEnumerationActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointChangeEnumerationActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudEndpointChangeEnumerationActivity(document.RootElement, options);
        }

        internal static CloudEndpointChangeEnumerationActivity DeserializeCloudEndpointChangeEnumerationActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<CloudEndpointChangeEnumerationActivityState> operationState = default;
            Optional<int> statusCode = default;
            Optional<DateTimeOffset> startedTimestamp = default;
            Optional<long> processedFilesCount = default;
            Optional<long> processedDirectoriesCount = default;
            Optional<long> totalFilesCount = default;
            Optional<long> totalDirectoriesCount = default;
            Optional<long> totalSizeBytes = default;
            Optional<int> progressPercent = default;
            Optional<int> minutesRemaining = default;
            Optional<CloudEndpointChangeEnumerationTotalCountsState> totalCountsState = default;
            Optional<int> deletesProgressPercent = default;
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
                if (property.NameEquals("operationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationState = new CloudEndpointChangeEnumerationActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("processedFilesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedFilesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("processedDirectoriesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedDirectoriesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalFilesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalFilesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDirectoriesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDirectoriesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("progressPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minutesRemaining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minutesRemaining = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalCountsState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCountsState = new CloudEndpointChangeEnumerationTotalCountsState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deletesProgressPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletesProgressPercent = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudEndpointChangeEnumerationActivity(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(operationState), Optional.ToNullable(statusCode), Optional.ToNullable(startedTimestamp), Optional.ToNullable(processedFilesCount), Optional.ToNullable(processedDirectoriesCount), Optional.ToNullable(totalFilesCount), Optional.ToNullable(totalDirectoriesCount), Optional.ToNullable(totalSizeBytes), Optional.ToNullable(progressPercent), Optional.ToNullable(minutesRemaining), Optional.ToNullable(totalCountsState), Optional.ToNullable(deletesProgressPercent), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(LastUpdatedOn))
            {
                builder.Append("  lastUpdatedTimestamp:");
                builder.AppendLine($" '{LastUpdatedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(OperationState))
            {
                builder.Append("  operationState:");
                builder.AppendLine($" '{OperationState.ToString()}'");
            }

            if (Optional.IsDefined(StatusCode))
            {
                builder.Append("  statusCode:");
                builder.AppendLine($" '{StatusCode.Value.ToString()}'");
            }

            if (Optional.IsDefined(StartedOn))
            {
                builder.Append("  startedTimestamp:");
                builder.AppendLine($" '{StartedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProcessedFilesCount))
            {
                builder.Append("  processedFilesCount:");
                builder.AppendLine($" '{ProcessedFilesCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProcessedDirectoriesCount))
            {
                builder.Append("  processedDirectoriesCount:");
                builder.AppendLine($" '{ProcessedDirectoriesCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(TotalFilesCount))
            {
                builder.Append("  totalFilesCount:");
                builder.AppendLine($" '{TotalFilesCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(TotalDirectoriesCount))
            {
                builder.Append("  totalDirectoriesCount:");
                builder.AppendLine($" '{TotalDirectoriesCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(TotalSizeInBytes))
            {
                builder.Append("  totalSizeBytes:");
                builder.AppendLine($" '{TotalSizeInBytes.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProgressPercent))
            {
                builder.Append("  progressPercent:");
                builder.AppendLine($" '{ProgressPercent.Value.ToString()}'");
            }

            if (Optional.IsDefined(MinutesRemaining))
            {
                builder.Append("  minutesRemaining:");
                builder.AppendLine($" '{MinutesRemaining.Value.ToString()}'");
            }

            if (Optional.IsDefined(TotalCountsState))
            {
                builder.Append("  totalCountsState:");
                builder.AppendLine($" '{TotalCountsState.ToString()}'");
            }

            if (Optional.IsDefined(DeletesProgressPercent))
            {
                builder.Append("  deletesProgressPercent:");
                builder.AppendLine($" '{DeletesProgressPercent.Value.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<CloudEndpointChangeEnumerationActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointChangeEnumerationActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointChangeEnumerationActivity)} does not support '{options.Format}' format.");
            }
        }

        CloudEndpointChangeEnumerationActivity IPersistableModel<CloudEndpointChangeEnumerationActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointChangeEnumerationActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudEndpointChangeEnumerationActivity(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointChangeEnumerationActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudEndpointChangeEnumerationActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
