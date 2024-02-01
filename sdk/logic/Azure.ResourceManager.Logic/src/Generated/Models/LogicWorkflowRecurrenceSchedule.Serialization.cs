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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRecurrenceSchedule : IUtf8JsonSerializable, IJsonModel<LogicWorkflowRecurrenceSchedule>, IPersistableModel<LogicWorkflowRecurrenceSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowRecurrenceSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWorkflowRecurrenceSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Minutes))
            {
                writer.WritePropertyName("minutes"u8);
                writer.WriteStartArray();
                foreach (var item in Minutes)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Hours))
            {
                writer.WritePropertyName("hours"u8);
                writer.WriteStartArray();
                foreach (var item in Hours)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WeekDays))
            {
                writer.WritePropertyName("weekDays"u8);
                writer.WriteStartArray();
                foreach (var item in WeekDays)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthDays))
            {
                writer.WritePropertyName("monthDays"u8);
                writer.WriteStartArray();
                foreach (var item in MonthDays)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthlyOccurrences))
            {
                writer.WritePropertyName("monthlyOccurrences"u8);
                writer.WriteStartArray();
                foreach (var item in MonthlyOccurrences)
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

        LogicWorkflowRecurrenceSchedule IJsonModel<LogicWorkflowRecurrenceSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRecurrenceSchedule(document.RootElement, options);
        }

        internal static LogicWorkflowRecurrenceSchedule DeserializeLogicWorkflowRecurrenceSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<int>> minutes = default;
            Optional<IList<int>> hours = default;
            Optional<IList<LogicWorkflowDayOfWeek>> weekDays = default;
            Optional<IList<int>> monthDays = default;
            Optional<IList<LogicWorkflowRecurrenceScheduleOccurrence>> monthlyOccurrences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minutes"u8))
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
                    minutes = array;
                    continue;
                }
                if (property.NameEquals("hours"u8))
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
                    hours = array;
                    continue;
                }
                if (property.NameEquals("weekDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogicWorkflowDayOfWeek> array = new List<LogicWorkflowDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToLogicWorkflowDayOfWeek());
                    }
                    weekDays = array;
                    continue;
                }
                if (property.NameEquals("monthDays"u8))
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
                    monthDays = array;
                    continue;
                }
                if (property.NameEquals("monthlyOccurrences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogicWorkflowRecurrenceScheduleOccurrence> array = new List<LogicWorkflowRecurrenceScheduleOccurrence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogicWorkflowRecurrenceScheduleOccurrence.DeserializeLogicWorkflowRecurrenceScheduleOccurrence(item));
                    }
                    monthlyOccurrences = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkflowRecurrenceSchedule(Optional.ToList(minutes), Optional.ToList(hours), Optional.ToList(weekDays), Optional.ToList(monthDays), Optional.ToList(monthlyOccurrences), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Minutes))
            {
                builder.Append("  minutes:");
                builder.AppendLine(" [");
                foreach (var item in Minutes)
                {
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(Hours))
            {
                builder.Append("  hours:");
                builder.AppendLine(" [");
                foreach (var item in Hours)
                {
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(WeekDays))
            {
                builder.Append("  weekDays:");
                builder.AppendLine(" [");
                foreach (var item in WeekDays)
                {
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(MonthDays))
            {
                builder.Append("  monthDays:");
                builder.AppendLine(" [");
                foreach (var item in MonthDays)
                {
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(MonthlyOccurrences))
            {
                builder.Append("  monthlyOccurrences:");
                builder.AppendLine(" [");
                foreach (var item in MonthlyOccurrences)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<LogicWorkflowRecurrenceSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceSchedule)} does not support '{options.Format}' format.");
            }
        }

        LogicWorkflowRecurrenceSchedule IPersistableModel<LogicWorkflowRecurrenceSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWorkflowRecurrenceSchedule(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkflowRecurrenceSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
