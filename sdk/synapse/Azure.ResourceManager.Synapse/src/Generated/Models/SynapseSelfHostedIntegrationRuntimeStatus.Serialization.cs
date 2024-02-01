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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSelfHostedIntegrationRuntimeStatus : IUtf8JsonSerializable, IJsonModel<SynapseSelfHostedIntegrationRuntimeStatus>, IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSelfHostedIntegrationRuntimeStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSelfHostedIntegrationRuntimeStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuntimeType.ToString());
            if (options.Format != "W" && Optional.IsDefined(DataFactoryName))
            {
                writer.WritePropertyName("dataFactoryName"u8);
                writer.WriteStringValue(DataFactoryName);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CreateOn))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TaskQueueId))
            {
                writer.WritePropertyName("taskQueueId"u8);
                writer.WriteStringValue(TaskQueueId);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeCommunicationChannelEncryptionMode))
            {
                writer.WritePropertyName("nodeCommunicationChannelEncryptionMode"u8);
                writer.WriteStringValue(NodeCommunicationChannelEncryptionMode);
            }
            if (options.Format != "W" && Optional.IsDefined(InternalChannelEncryption))
            {
                writer.WritePropertyName("internalChannelEncryption"u8);
                writer.WriteStringValue(InternalChannelEncryption.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsCollectionDefined(Nodes))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ScheduledUpdateOn))
            {
                writer.WritePropertyName("scheduledUpdateDate"u8);
                writer.WriteStringValue(ScheduledUpdateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdateDelayOffset))
            {
                writer.WritePropertyName("updateDelayOffset"u8);
                writer.WriteStringValue(UpdateDelayOffset);
            }
            if (options.Format != "W" && Optional.IsDefined(LocalTimeZoneOffset))
            {
                writer.WritePropertyName("localTimeZoneOffset"u8);
                writer.WriteStringValue(LocalTimeZoneOffset);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartObject();
                foreach (var item in Capabilities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ServiceUrls))
            {
                writer.WritePropertyName("serviceUrls"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(AutoUpdate))
            {
                writer.WritePropertyName("autoUpdate"u8);
                writer.WriteStringValue(AutoUpdate.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(VersionStatus))
            {
                writer.WritePropertyName("versionStatus"u8);
                writer.WriteStringValue(VersionStatus);
            }
            if (Optional.IsCollectionDefined(Links))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(PushedVersion))
            {
                writer.WritePropertyName("pushedVersion"u8);
                writer.WriteStringValue(PushedVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(LatestVersion))
            {
                writer.WritePropertyName("latestVersion"u8);
                writer.WriteStringValue(LatestVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(AutoUpdateEta))
            {
                writer.WritePropertyName("autoUpdateETA"u8);
                writer.WriteStringValue(AutoUpdateEta.Value, "O");
            }
            if (Optional.IsDefined(ServiceRegion))
            {
                writer.WritePropertyName("serviceRegion"u8);
                writer.WriteStringValue(ServiceRegion);
            }
            if (Optional.IsCollectionDefined(NewerVersions))
            {
                writer.WritePropertyName("newerVersions"u8);
                writer.WriteStartArray();
                foreach (var item in NewerVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseSelfHostedIntegrationRuntimeStatus IJsonModel<SynapseSelfHostedIntegrationRuntimeStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSelfHostedIntegrationRuntimeStatus(document.RootElement, options);
        }

        internal static SynapseSelfHostedIntegrationRuntimeStatus DeserializeSynapseSelfHostedIntegrationRuntimeStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Optional<string> dataFactoryName = default;
            Optional<SynapseIntegrationRuntimeState> state = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<string> taskQueueId = default;
            Optional<string> nodeCommunicationChannelEncryptionMode = default;
            Optional<SynapseIntegrationRuntimeInternalChannelEncryptionMode> internalChannelEncryption = default;
            Optional<string> version = default;
            Optional<IReadOnlyList<SynapseSelfHostedIntegrationRuntimeNode>> nodes = default;
            Optional<DateTimeOffset> scheduledUpdateDate = default;
            Optional<string> updateDelayOffset = default;
            Optional<string> localTimeZoneOffset = default;
            Optional<IReadOnlyDictionary<string, string>> capabilities = default;
            Optional<IReadOnlyList<string>> serviceUrls = default;
            Optional<SynapseIntegrationRuntimeAutoUpdate> autoUpdate = default;
            Optional<string> versionStatus = default;
            Optional<IReadOnlyList<SynapseLinkedIntegrationRuntime>> links = default;
            Optional<string> pushedVersion = default;
            Optional<string> latestVersion = default;
            Optional<DateTimeOffset> autoUpdateEta = default;
            Optional<string> serviceRegion = default;
            Optional<IReadOnlyList<string>> newerVersions = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SynapseIntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("taskQueueId"u8))
                        {
                            taskQueueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCommunicationChannelEncryptionMode"u8))
                        {
                            nodeCommunicationChannelEncryptionMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("internalChannelEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalChannelEncryption = new SynapseIntegrationRuntimeInternalChannelEncryptionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseSelfHostedIntegrationRuntimeNode> array = new List<SynapseSelfHostedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseSelfHostedIntegrationRuntimeNode.DeserializeSynapseSelfHostedIntegrationRuntimeNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduledUpdateDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scheduledUpdateDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateDelayOffset"u8))
                        {
                            updateDelayOffset = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localTimeZoneOffset"u8))
                        {
                            localTimeZoneOffset = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            capabilities = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("serviceUrls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            serviceUrls = array;
                            continue;
                        }
                        if (property0.NameEquals("autoUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdate = new SynapseIntegrationRuntimeAutoUpdate(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("versionStatus"u8))
                        {
                            versionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseLinkedIntegrationRuntime> array = new List<SynapseLinkedIntegrationRuntime>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseLinkedIntegrationRuntime.DeserializeSynapseLinkedIntegrationRuntime(item));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("pushedVersion"u8))
                        {
                            pushedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestVersion"u8))
                        {
                            latestVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpdateETA"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdateEta = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceRegion"u8))
                        {
                            serviceRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("newerVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            newerVersions = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSelfHostedIntegrationRuntimeStatus(type, dataFactoryName.Value, Optional.ToNullable(state), additionalProperties, Optional.ToNullable(createTime), taskQueueId.Value, nodeCommunicationChannelEncryptionMode.Value, Optional.ToNullable(internalChannelEncryption), version.Value, Optional.ToList(nodes), Optional.ToNullable(scheduledUpdateDate), updateDelayOffset.Value, localTimeZoneOffset.Value, Optional.ToDictionary(capabilities), Optional.ToList(serviceUrls), Optional.ToNullable(autoUpdate), versionStatus.Value, Optional.ToList(links), pushedVersion.Value, latestVersion.Value, Optional.ToNullable(autoUpdateEta), serviceRegion.Value, Optional.ToList(newerVersions));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CreateOn))
            {
                builder.Append("  createTime:");
                builder.AppendLine($" '{CreateOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(TaskQueueId))
            {
                builder.Append("  taskQueueId:");
                builder.AppendLine($" '{TaskQueueId}'");
            }

            if (Optional.IsDefined(NodeCommunicationChannelEncryptionMode))
            {
                builder.Append("  nodeCommunicationChannelEncryptionMode:");
                builder.AppendLine($" '{NodeCommunicationChannelEncryptionMode}'");
            }

            if (Optional.IsDefined(InternalChannelEncryption))
            {
                builder.Append("  internalChannelEncryption:");
                builder.AppendLine($" '{InternalChannelEncryption.ToString()}'");
            }

            if (Optional.IsDefined(Version))
            {
                builder.Append("  version:");
                builder.AppendLine($" '{Version}'");
            }

            if (Optional.IsCollectionDefined(Nodes))
            {
                builder.Append("  nodes:");
                builder.AppendLine(" [");
                foreach (var item in Nodes)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(ScheduledUpdateOn))
            {
                builder.Append("  scheduledUpdateDate:");
                builder.AppendLine($" '{ScheduledUpdateOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(UpdateDelayOffset))
            {
                builder.Append("  updateDelayOffset:");
                builder.AppendLine($" '{UpdateDelayOffset}'");
            }

            if (Optional.IsDefined(LocalTimeZoneOffset))
            {
                builder.Append("  localTimeZoneOffset:");
                builder.AppendLine($" '{LocalTimeZoneOffset}'");
            }

            if (Optional.IsCollectionDefined(Capabilities))
            {
                builder.Append("  capabilities:");
                builder.AppendLine(" {");
                foreach (var item in Capabilities)
                {
                    builder.Append($"    {item.Key}: ");
                    if (item.Value == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($" '{item.Value}'");
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsCollectionDefined(ServiceUrls))
            {
                builder.Append("  serviceUrls:");
                builder.AppendLine(" [");
                foreach (var item in ServiceUrls)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(AutoUpdate))
            {
                builder.Append("  autoUpdate:");
                builder.AppendLine($" '{AutoUpdate.ToString()}'");
            }

            if (Optional.IsDefined(VersionStatus))
            {
                builder.Append("  versionStatus:");
                builder.AppendLine($" '{VersionStatus}'");
            }

            if (Optional.IsCollectionDefined(Links))
            {
                builder.Append("  links:");
                builder.AppendLine(" [");
                foreach (var item in Links)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(PushedVersion))
            {
                builder.Append("  pushedVersion:");
                builder.AppendLine($" '{PushedVersion}'");
            }

            if (Optional.IsDefined(LatestVersion))
            {
                builder.Append("  latestVersion:");
                builder.AppendLine($" '{LatestVersion}'");
            }

            if (Optional.IsDefined(AutoUpdateEta))
            {
                builder.Append("  autoUpdateETA:");
                builder.AppendLine($" '{AutoUpdateEta.Value.ToString()}'");
            }

            if (Optional.IsDefined(ServiceRegion))
            {
                builder.Append("  serviceRegion:");
                builder.AppendLine($" '{ServiceRegion}'");
            }

            if (Optional.IsCollectionDefined(NewerVersions))
            {
                builder.Append("  newerVersions:");
                builder.AppendLine(" [");
                foreach (var item in NewerVersions)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(RuntimeType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{RuntimeType.ToString()}'");
            }

            if (Optional.IsDefined(DataFactoryName))
            {
                builder.Append("  dataFactoryName:");
                builder.AppendLine($" '{DataFactoryName}'");
            }

            if (Optional.IsDefined(State))
            {
                builder.Append("  state:");
                builder.AppendLine($" '{State.ToString()}'");
            }

            if (Optional.IsCollectionDefined(AdditionalProperties))
            {
                builder.Append("  AdditionalProperties:");
                builder.AppendLine(" {");
                foreach (var item in AdditionalProperties)
                {
                    builder.Append($"    {item.Key}: ");
                    if (item.Value == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($" '{item.Value.ToString()}'");
                }
                builder.AppendLine("  }");
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

        BinaryData IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        SynapseSelfHostedIntegrationRuntimeStatus IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSelfHostedIntegrationRuntimeStatus(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSelfHostedIntegrationRuntimeStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
