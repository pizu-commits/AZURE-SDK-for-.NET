// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownJobLimits : IUtf8JsonSerializable, IJsonModel<MachineLearningJobLimits>, IPersistableModel<MachineLearningJobLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningJobLimits>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningJobLimits>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("jobLimitsType"u8);
            writer.WriteStringValue(JobLimitsType.ToString());
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout"u8);
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
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

        MachineLearningJobLimits IJsonModel<MachineLearningJobLimits>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownJobLimits(document.RootElement, options);
        }

        internal static UnknownJobLimits DeserializeUnknownJobLimits(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            JobLimitsType jobLimitsType = "Unknown";
            Optional<TimeSpan?> timeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobLimitsType"u8))
                {
                    jobLimitsType = new JobLimitsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownJobLimits(jobLimitsType, Optional.ToNullable(timeout), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(JobLimitsType))
            {
                builder.Append("  jobLimitsType:");
                builder.AppendLine($" '{JobLimitsType.ToString()}'");
            }

            if (Optional.IsDefined(Timeout))
            {
                builder.Append("  timeout:");
                var formattedTimeSpan = XmlConvert.ToString(Timeout.Value);
                builder.AppendLine($" '{formattedTimeSpan}'");
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

        BinaryData IPersistableModel<MachineLearningJobLimits>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningJobLimits IPersistableModel<MachineLearningJobLimits>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownJobLimits(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningJobLimits>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
