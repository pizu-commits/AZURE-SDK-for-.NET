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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    [PersistableModelProxy(typeof(UnknownRunRequest))]
    public partial class ContainerRegistryRunContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryRunContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryRunContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryRunContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryRunContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunRequestType);
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(LogTemplate))
            {
                writer.WritePropertyName("logTemplate"u8);
                writer.WriteStringValue(LogTemplate);
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

        ContainerRegistryRunContent IJsonModel<ContainerRegistryRunContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryRunContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryRunContent(document.RootElement, options);
        }

        internal static ContainerRegistryRunContent DeserializeContainerRegistryRunContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DockerBuildRequest": return ContainerRegistryDockerBuildContent.DeserializeContainerRegistryDockerBuildContent(element, options);
                    case "EncodedTaskRunRequest": return ContainerRegistryEncodedTaskRunContent.DeserializeContainerRegistryEncodedTaskRunContent(element, options);
                    case "FileTaskRunRequest": return ContainerRegistryFileTaskRunContent.DeserializeContainerRegistryFileTaskRunContent(element, options);
                    case "TaskRunRequest": return ContainerRegistryTaskRunContent.DeserializeContainerRegistryTaskRunContent(element, options);
                }
            }
            return UnknownRunRequest.DeserializeUnknownRunRequest(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunRequestType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunRequestType))
                {
                    builder.Append("  type: ");
                    if (RunRequestType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RunRequestType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RunRequestType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsArchiveEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isArchiveEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsArchiveEnabled))
                {
                    builder.Append("  isArchiveEnabled: ");
                    var boolValue = IsArchiveEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgentPoolName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  agentPoolName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgentPoolName))
                {
                    builder.Append("  agentPoolName: ");
                    if (AgentPoolName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgentPoolName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgentPoolName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogTemplate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logTemplate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogTemplate))
                {
                    builder.Append("  logTemplate: ");
                    if (LogTemplate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LogTemplate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LogTemplate}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerRegistryRunContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryRunContent)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryRunContent IPersistableModel<ContainerRegistryRunContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryRunContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryRunContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryRunContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
