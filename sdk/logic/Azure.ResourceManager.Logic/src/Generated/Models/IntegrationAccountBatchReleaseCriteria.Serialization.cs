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
    public partial class IntegrationAccountBatchReleaseCriteria : IUtf8JsonSerializable, IJsonModel<IntegrationAccountBatchReleaseCriteria>, IPersistableModel<IntegrationAccountBatchReleaseCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountBatchReleaseCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationAccountBatchReleaseCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBatchReleaseCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountBatchReleaseCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MessageCount))
            {
                writer.WritePropertyName("messageCount"u8);
                writer.WriteNumberValue(MessageCount.Value);
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence"u8);
                writer.WriteObjectValue(Recurrence);
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

        IntegrationAccountBatchReleaseCriteria IJsonModel<IntegrationAccountBatchReleaseCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBatchReleaseCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountBatchReleaseCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountBatchReleaseCriteria(document.RootElement, options);
        }

        internal static IntegrationAccountBatchReleaseCriteria DeserializeIntegrationAccountBatchReleaseCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> messageCount = default;
            Optional<int> batchSize = default;
            Optional<LogicWorkflowTriggerRecurrence> recurrence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("batchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = LogicWorkflowTriggerRecurrence.DeserializeLogicWorkflowTriggerRecurrence(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationAccountBatchReleaseCriteria(Optional.ToNullable(messageCount), Optional.ToNullable(batchSize), recurrence.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(MessageCount))
            {
                builder.Append("  messageCount:");
                builder.AppendLine($" '{MessageCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(BatchSize))
            {
                builder.Append("  batchSize:");
                builder.AppendLine($" '{BatchSize.Value.ToString()}'");
            }

            if (Optional.IsDefined(Recurrence))
            {
                builder.Append("  recurrence:");
                AppendChildObject(builder, Recurrence, options, 2);
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

        BinaryData IPersistableModel<IntegrationAccountBatchReleaseCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBatchReleaseCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountBatchReleaseCriteria)} does not support '{options.Format}' format.");
            }
        }

        IntegrationAccountBatchReleaseCriteria IPersistableModel<IntegrationAccountBatchReleaseCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBatchReleaseCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationAccountBatchReleaseCriteria(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountBatchReleaseCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationAccountBatchReleaseCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
