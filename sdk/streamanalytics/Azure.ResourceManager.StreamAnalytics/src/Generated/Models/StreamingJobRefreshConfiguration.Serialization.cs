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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamingJobRefreshConfiguration : IUtf8JsonSerializable, IJsonModel<StreamingJobRefreshConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobRefreshConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobRefreshConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobRefreshConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobRefreshConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PathPattern))
            {
                writer.WritePropertyName("pathPattern"u8);
                writer.WriteStringValue(PathPattern);
            }
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteStringValue(DateFormat);
            }
            if (Optional.IsDefined(TimeFormat))
            {
                writer.WritePropertyName("timeFormat"u8);
                writer.WriteStringValue(TimeFormat);
            }
            if (Optional.IsDefined(RefreshInterval))
            {
                writer.WritePropertyName("refreshInterval"u8);
                writer.WriteStringValue(RefreshInterval);
            }
            if (Optional.IsDefined(RefreshType))
            {
                writer.WritePropertyName("refreshType"u8);
                writer.WriteStringValue(RefreshType.Value.ToString());
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

        StreamingJobRefreshConfiguration IJsonModel<StreamingJobRefreshConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobRefreshConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobRefreshConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobRefreshConfiguration(document.RootElement, options);
        }

        internal static StreamingJobRefreshConfiguration DeserializeStreamingJobRefreshConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> pathPattern = default;
            Optional<string> dateFormat = default;
            Optional<string> timeFormat = default;
            Optional<string> refreshInterval = default;
            Optional<DataRefreshType> refreshType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pathPattern"u8))
                {
                    pathPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dateFormat"u8))
                {
                    dateFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeFormat"u8))
                {
                    timeFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshInterval"u8))
                {
                    refreshInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshType = new DataRefreshType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingJobRefreshConfiguration(pathPattern.Value, dateFormat.Value, timeFormat.Value, refreshInterval.Value, Optional.ToNullable(refreshType), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PathPattern))
            {
                builder.Append("  pathPattern:");
                builder.AppendLine($" '{PathPattern}'");
            }

            if (Optional.IsDefined(DateFormat))
            {
                builder.Append("  dateFormat:");
                builder.AppendLine($" '{DateFormat}'");
            }

            if (Optional.IsDefined(TimeFormat))
            {
                builder.Append("  timeFormat:");
                builder.AppendLine($" '{TimeFormat}'");
            }

            if (Optional.IsDefined(RefreshInterval))
            {
                builder.Append("  refreshInterval:");
                builder.AppendLine($" '{RefreshInterval}'");
            }

            if (Optional.IsDefined(RefreshType))
            {
                builder.Append("  refreshType:");
                builder.AppendLine($" '{RefreshType.ToString()}'");
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

        BinaryData IPersistableModel<StreamingJobRefreshConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobRefreshConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobRefreshConfiguration)} does not support '{options.Format}' format.");
            }
        }

        StreamingJobRefreshConfiguration IPersistableModel<StreamingJobRefreshConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobRefreshConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobRefreshConfiguration(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(StreamingJobRefreshConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobRefreshConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
