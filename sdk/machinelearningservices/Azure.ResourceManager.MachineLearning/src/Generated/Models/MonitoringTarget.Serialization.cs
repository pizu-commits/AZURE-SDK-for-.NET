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
    public partial class MonitoringTarget : IUtf8JsonSerializable, IJsonModel<MonitoringTarget>, IPersistableModel<MonitoringTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoringTarget>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitoringTarget>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringTarget)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DeploymentId))
            {
                if (DeploymentId != null)
                {
                    writer.WritePropertyName("deploymentId"u8);
                    writer.WriteStringValue(DeploymentId);
                }
                else
                {
                    writer.WriteNull("deploymentId");
                }
            }
            if (Optional.IsDefined(ModelId))
            {
                if (ModelId != null)
                {
                    writer.WritePropertyName("modelId"u8);
                    writer.WriteStringValue(ModelId);
                }
                else
                {
                    writer.WriteNull("modelId");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
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

        MonitoringTarget IJsonModel<MonitoringTarget>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringTarget)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitoringTarget(document.RootElement, options);
        }

        internal static MonitoringTarget DeserializeMonitoringTarget(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deploymentId = default;
            Optional<string> modelId = default;
            ModelTaskType taskType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deploymentId = null;
                        continue;
                    }
                    deploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelId = null;
                        continue;
                    }
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new ModelTaskType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitoringTarget(deploymentId.Value, modelId.Value, taskType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(DeploymentId))
            {
                builder.Append("  deploymentId:");
                builder.AppendLine($" '{DeploymentId}'");
            }

            if (Optional.IsDefined(ModelId))
            {
                builder.Append("  modelId:");
                builder.AppendLine($" '{ModelId}'");
            }

            if (Optional.IsDefined(TaskType))
            {
                builder.Append("  taskType:");
                builder.AppendLine($" '{TaskType.ToString()}'");
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

        BinaryData IPersistableModel<MonitoringTarget>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MonitoringTarget)} does not support '{options.Format}' format.");
            }
        }

        MonitoringTarget IPersistableModel<MonitoringTarget>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitoringTarget(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MonitoringTarget)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoringTarget>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
