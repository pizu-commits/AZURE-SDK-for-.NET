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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class RoutePolicyStatementProperties : IUtf8JsonSerializable, IJsonModel<RoutePolicyStatementProperties>, IPersistableModel<RoutePolicyStatementProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutePolicyStatementProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoutePolicyStatementProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutePolicyStatementProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutePolicyStatementProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sequenceNumber"u8);
            writer.WriteNumberValue(SequenceNumber);
            writer.WritePropertyName("condition"u8);
            writer.WriteObjectValue(Condition);
            writer.WritePropertyName("action"u8);
            writer.WriteObjectValue(Action);
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
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

        RoutePolicyStatementProperties IJsonModel<RoutePolicyStatementProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutePolicyStatementProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutePolicyStatementProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutePolicyStatementProperties(document.RootElement, options);
        }

        internal static RoutePolicyStatementProperties DeserializeRoutePolicyStatementProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long sequenceNumber = default;
            StatementConditionProperties condition = default;
            StatementActionProperties action = default;
            Optional<string> annotation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sequenceNumber"u8))
                {
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("condition"u8))
                {
                    condition = StatementConditionProperties.DeserializeStatementConditionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = StatementActionProperties.DeserializeStatementActionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("annotation"u8))
                {
                    annotation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoutePolicyStatementProperties(annotation.Value, serializedAdditionalRawData, sequenceNumber, condition, action);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SequenceNumber))
            {
                builder.Append("  sequenceNumber:");
                builder.AppendLine($" '{SequenceNumber.ToString()}'");
            }

            if (Optional.IsDefined(Condition))
            {
                builder.Append("  condition:");
                AppendChildObject(builder, Condition, options, 2);
            }

            if (Optional.IsDefined(Action))
            {
                builder.Append("  action:");
                AppendChildObject(builder, Action, options, 2);
            }

            if (Optional.IsDefined(Annotation))
            {
                builder.Append("  annotation:");
                builder.AppendLine($" '{Annotation}'");
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

        BinaryData IPersistableModel<RoutePolicyStatementProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutePolicyStatementProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RoutePolicyStatementProperties)} does not support '{options.Format}' format.");
            }
        }

        RoutePolicyStatementProperties IPersistableModel<RoutePolicyStatementProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutePolicyStatementProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoutePolicyStatementProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(RoutePolicyStatementProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutePolicyStatementProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
