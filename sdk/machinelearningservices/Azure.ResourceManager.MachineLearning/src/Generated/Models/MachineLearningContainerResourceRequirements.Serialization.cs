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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningContainerResourceRequirements : IUtf8JsonSerializable, IJsonModel<MachineLearningContainerResourceRequirements>, IPersistableModel<MachineLearningContainerResourceRequirements>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningContainerResourceRequirements>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningContainerResourceRequirements>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningContainerResourceRequirements)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerResourceLimits))
            {
                if (ContainerResourceLimits != null)
                {
                    writer.WritePropertyName("containerResourceLimits"u8);
                    writer.WriteObjectValue(ContainerResourceLimits);
                }
                else
                {
                    writer.WriteNull("containerResourceLimits");
                }
            }
            if (Optional.IsDefined(ContainerResourceRequests))
            {
                if (ContainerResourceRequests != null)
                {
                    writer.WritePropertyName("containerResourceRequests"u8);
                    writer.WriteObjectValue(ContainerResourceRequests);
                }
                else
                {
                    writer.WriteNull("containerResourceRequests");
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

        MachineLearningContainerResourceRequirements IJsonModel<MachineLearningContainerResourceRequirements>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningContainerResourceRequirements)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningContainerResourceRequirements(document.RootElement, options);
        }

        internal static MachineLearningContainerResourceRequirements DeserializeMachineLearningContainerResourceRequirements(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningContainerResourceSettings> containerResourceLimits = default;
            Optional<MachineLearningContainerResourceSettings> containerResourceRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerResourceLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containerResourceLimits = null;
                        continue;
                    }
                    containerResourceLimits = MachineLearningContainerResourceSettings.DeserializeMachineLearningContainerResourceSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("containerResourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containerResourceRequests = null;
                        continue;
                    }
                    containerResourceRequests = MachineLearningContainerResourceSettings.DeserializeMachineLearningContainerResourceSettings(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningContainerResourceRequirements(containerResourceLimits.Value, containerResourceRequests.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ContainerResourceLimits))
            {
                builder.Append("  containerResourceLimits:");
                AppendChildObject(builder, ContainerResourceLimits, options, 2);
            }

            if (Optional.IsDefined(ContainerResourceRequests))
            {
                builder.Append("  containerResourceRequests:");
                AppendChildObject(builder, ContainerResourceRequests, options, 2);
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

        BinaryData IPersistableModel<MachineLearningContainerResourceRequirements>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningContainerResourceRequirements)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningContainerResourceRequirements IPersistableModel<MachineLearningContainerResourceRequirements>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningContainerResourceRequirements(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningContainerResourceRequirements)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningContainerResourceRequirements>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
