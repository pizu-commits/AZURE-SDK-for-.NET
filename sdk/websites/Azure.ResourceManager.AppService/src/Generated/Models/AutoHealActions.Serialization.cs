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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AutoHealActions : IUtf8JsonSerializable, IJsonModel<AutoHealActions>, IPersistableModel<AutoHealActions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoHealActions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoHealActions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealActions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoHealActions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionType))
            {
                writer.WritePropertyName("actionType"u8);
                writer.WriteStringValue(ActionType.Value.ToSerialString());
            }
            if (Optional.IsDefined(CustomAction))
            {
                writer.WritePropertyName("customAction"u8);
                writer.WriteObjectValue(CustomAction);
            }
            if (Optional.IsDefined(MinProcessExecutionTime))
            {
                writer.WritePropertyName("minProcessExecutionTime"u8);
                writer.WriteStringValue(MinProcessExecutionTime);
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

        AutoHealActions IJsonModel<AutoHealActions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealActions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoHealActions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoHealActions(document.RootElement, options);
        }

        internal static AutoHealActions DeserializeAutoHealActions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutoHealActionType> actionType = default;
            Optional<AutoHealCustomAction> customAction = default;
            Optional<string> minProcessExecutionTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionType = property.Value.GetString().ToAutoHealActionType();
                    continue;
                }
                if (property.NameEquals("customAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customAction = AutoHealCustomAction.DeserializeAutoHealCustomAction(property.Value);
                    continue;
                }
                if (property.NameEquals("minProcessExecutionTime"u8))
                {
                    minProcessExecutionTime = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoHealActions(Optional.ToNullable(actionType), customAction.Value, minProcessExecutionTime.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ActionType))
            {
                builder.Append("  actionType:");
                builder.AppendLine($" '{ActionType.ToString()}'");
            }

            if (Optional.IsDefined(CustomAction))
            {
                builder.Append("  customAction:");
                AppendChildObject(builder, CustomAction, options, 2);
            }

            if (Optional.IsDefined(MinProcessExecutionTime))
            {
                builder.Append("  minProcessExecutionTime:");
                builder.AppendLine($" '{MinProcessExecutionTime}'");
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

        BinaryData IPersistableModel<AutoHealActions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealActions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AutoHealActions)} does not support '{options.Format}' format.");
            }
        }

        AutoHealActions IPersistableModel<AutoHealActions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealActions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoHealActions(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AutoHealActions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoHealActions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
