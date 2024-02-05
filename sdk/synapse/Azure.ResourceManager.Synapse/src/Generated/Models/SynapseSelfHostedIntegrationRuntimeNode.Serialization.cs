// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSelfHostedIntegrationRuntimeNode : IUtf8JsonSerializable, IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(NodeName))
            {
                writer.WritePropertyName("nodeName"u8);
                writer.WriteStringValue(NodeName);
            }
            if (options.Format != "W" && Optional.IsDefined(MachineName))
            {
                writer.WritePropertyName("machineName"u8);
                writer.WriteStringValue(MachineName);
            }
            if (options.Format != "W" && Optional.IsDefined(HostServiceUri))
            {
                writer.WritePropertyName("hostServiceUri"u8);
                writer.WriteStringValue(HostServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(VersionStatus))
            {
                writer.WritePropertyName("versionStatus"u8);
                writer.WriteStringValue(VersionStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(RegisterOn))
            {
                writer.WritePropertyName("registerTime"u8);
                writer.WriteStringValue(RegisterOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastConnectedOn))
            {
                writer.WritePropertyName("lastConnectTime"u8);
                writer.WriteStringValue(LastConnectedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastStartedOn))
            {
                writer.WritePropertyName("lastStartTime"u8);
                writer.WriteStringValue(LastStartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastStopOn))
            {
                writer.WritePropertyName("lastStopTime"u8);
                writer.WriteStringValue(LastStopOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdateResult))
            {
                writer.WritePropertyName("lastUpdateResult"u8);
                writer.WriteStringValue(LastUpdateResult.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastStartUpdateOn))
            {
                writer.WritePropertyName("lastStartUpdateTime"u8);
                writer.WriteStringValue(LastStartUpdateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastEndUpdateOn))
            {
                writer.WritePropertyName("lastEndUpdateTime"u8);
                writer.WriteStringValue(LastEndUpdateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsActiveDispatcher))
            {
                writer.WritePropertyName("isActiveDispatcher"u8);
                writer.WriteBooleanValue(IsActiveDispatcher.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConcurrentJobsLimit))
            {
                writer.WritePropertyName("concurrentJobsLimit"u8);
                writer.WriteNumberValue(ConcurrentJobsLimit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxConcurrentJobs))
            {
                writer.WritePropertyName("maxConcurrentJobs"u8);
                writer.WriteNumberValue(MaxConcurrentJobs.Value);
            }
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

        SynapseSelfHostedIntegrationRuntimeNode IJsonModel<SynapseSelfHostedIntegrationRuntimeNode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement, options);
        }

        internal static SynapseSelfHostedIntegrationRuntimeNode DeserializeSynapseSelfHostedIntegrationRuntimeNode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodeName = default;
            Optional<string> machineName = default;
            Optional<Uri> hostServiceUri = default;
            Optional<SynapseSelfHostedIntegrationRuntimeNodeStatus> status = default;
            Optional<IReadOnlyDictionary<string, string>> capabilities = default;
            Optional<string> versionStatus = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> registerTime = default;
            Optional<DateTimeOffset> lastConnectTime = default;
            Optional<DateTimeOffset> expiryTime = default;
            Optional<DateTimeOffset> lastStartTime = default;
            Optional<DateTimeOffset> lastStopTime = default;
            Optional<SynapseIntegrationRuntimeUpdateResult> lastUpdateResult = default;
            Optional<DateTimeOffset> lastStartUpdateTime = default;
            Optional<DateTimeOffset> lastEndUpdateTime = default;
            Optional<bool> isActiveDispatcher = default;
            Optional<int> concurrentJobsLimit = default;
            Optional<int> maxConcurrentJobs = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SynapseSelfHostedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    capabilities = dictionary;
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConnectTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConnectTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStopTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateResult = new SynapseIntegrationRuntimeUpdateResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStartUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEndUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEndUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isActiveDispatcher"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isActiveDispatcher = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSelfHostedIntegrationRuntimeNode(nodeName.Value, machineName.Value, hostServiceUri.Value, Optional.ToNullable(status), Optional.ToDictionary(capabilities), versionStatus.Value, version.Value, Optional.ToNullable(registerTime), Optional.ToNullable(lastConnectTime), Optional.ToNullable(expiryTime), Optional.ToNullable(lastStartTime), Optional.ToNullable(lastStopTime), Optional.ToNullable(lastUpdateResult), Optional.ToNullable(lastStartUpdateTime), Optional.ToNullable(lastEndUpdateTime), Optional.ToNullable(isActiveDispatcher), Optional.ToNullable(concurrentJobsLimit), Optional.ToNullable(maxConcurrentJobs), additionalProperties);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(NodeName))
            {
                builder.Append("  nodeName:");
                builder.AppendLine($" '{NodeName}'");
            }

            if (Optional.IsDefined(MachineName))
            {
                builder.Append("  machineName:");
                builder.AppendLine($" '{MachineName}'");
            }

            if (Optional.IsDefined(HostServiceUri))
            {
                builder.Append("  hostServiceUri:");
                builder.AppendLine($" '{HostServiceUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Capabilities))
            {
                if (Capabilities.Any())
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
            }

            if (Optional.IsDefined(VersionStatus))
            {
                builder.Append("  versionStatus:");
                builder.AppendLine($" '{VersionStatus}'");
            }

            if (Optional.IsDefined(Version))
            {
                builder.Append("  version:");
                builder.AppendLine($" '{Version}'");
            }

            if (Optional.IsDefined(RegisterOn))
            {
                builder.Append("  registerTime:");
                var formattedDateTimeString = TypeFormatters.ToString(RegisterOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastConnectedOn))
            {
                builder.Append("  lastConnectTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastConnectedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ExpireOn))
            {
                builder.Append("  expiryTime:");
                var formattedDateTimeString = TypeFormatters.ToString(ExpireOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastStartedOn))
            {
                builder.Append("  lastStartTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastStartedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastStopOn))
            {
                builder.Append("  lastStopTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastStopOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastUpdateResult))
            {
                builder.Append("  lastUpdateResult:");
                builder.AppendLine($" '{LastUpdateResult.ToString()}'");
            }

            if (Optional.IsDefined(LastStartUpdateOn))
            {
                builder.Append("  lastStartUpdateTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastStartUpdateOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastEndUpdateOn))
            {
                builder.Append("  lastEndUpdateTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastEndUpdateOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(IsActiveDispatcher))
            {
                builder.Append("  isActiveDispatcher:");
                var boolValue = IsActiveDispatcher.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ConcurrentJobsLimit))
            {
                builder.Append("  concurrentJobsLimit:");
                builder.AppendLine($" {ConcurrentJobsLimit.Value}");
            }

            if (Optional.IsDefined(MaxConcurrentJobs))
            {
                builder.Append("  maxConcurrentJobs:");
                builder.AppendLine($" {MaxConcurrentJobs.Value}");
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

        BinaryData IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support '{options.Format}' format.");
            }
        }

        SynapseSelfHostedIntegrationRuntimeNode IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntimeNode)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSelfHostedIntegrationRuntimeNode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
