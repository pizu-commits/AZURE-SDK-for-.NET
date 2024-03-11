// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryDockerBuildContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryDockerBuildContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryDockerBuildContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryDockerBuildContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ImageNames))
            {
                writer.WritePropertyName("imageNames"u8);
                writer.WriteStartArray();
                foreach (var item in ImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPushEnabled))
            {
                writer.WritePropertyName("isPushEnabled"u8);
                writer.WriteBooleanValue(IsPushEnabled.Value);
            }
            if (Optional.IsDefined(NoCache))
            {
                writer.WritePropertyName("noCache"u8);
                writer.WriteBooleanValue(NoCache.Value);
            }
            writer.WritePropertyName("dockerFilePath"u8);
            writer.WriteStringValue(DockerFilePath);
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            writer.WritePropertyName("platform"u8);
            writer.WriteObjectValue(Platform);
            if (Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration);
            }
            if (Optional.IsDefined(SourceLocation))
            {
                writer.WritePropertyName("sourceLocation"u8);
                writer.WriteStringValue(SourceLocation);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
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

        ContainerRegistryDockerBuildContent IJsonModel<ContainerRegistryDockerBuildContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryDockerBuildContent(document.RootElement, options);
        }

        internal static ContainerRegistryDockerBuildContent DeserializeContainerRegistryDockerBuildContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> imageNames = default;
            bool? isPushEnabled = default;
            bool? noCache = default;
            string dockerFilePath = default;
            string target = default;
            IList<ContainerRegistryRunArgument> arguments = default;
            int? timeout = default;
            ContainerRegistryPlatformProperties platform = default;
            ContainerRegistryAgentProperties agentConfiguration = default;
            string sourceLocation = default;
            ContainerRegistryCredentials credentials = default;
            string type = default;
            bool? isArchiveEnabled = default;
            string agentPoolName = default;
            string logTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    imageNames = array;
                    continue;
                }
                if (property.NameEquals("isPushEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPushEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("noCache"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noCache = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dockerFilePath"u8))
                {
                    dockerFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryRunArgument> array = new List<ContainerRegistryRunArgument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryRunArgument.DeserializeContainerRegistryRunArgument(item, options));
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    platform = ContainerRegistryPlatformProperties.DeserializeContainerRegistryPlatformProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("agentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentConfiguration = ContainerRegistryAgentProperties.DeserializeContainerRegistryAgentProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceLocation"u8))
                {
                    sourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = ContainerRegistryCredentials.DeserializeContainerRegistryCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("agentPoolName"u8))
                {
                    agentPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logTemplate"u8))
                {
                    logTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryDockerBuildContent(
                type,
                isArchiveEnabled,
                agentPoolName,
                logTemplate,
                serializedAdditionalRawData,
                imageNames ?? new ChangeTrackingList<string>(),
                isPushEnabled,
                noCache,
                dockerFilePath,
                target,
                arguments ?? new ChangeTrackingList<ContainerRegistryRunArgument>(),
                timeout,
                platform,
                agentConfiguration,
                sourceLocation,
                credentials);
        }

        BinaryData IPersistableModel<ContainerRegistryDockerBuildContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryDockerBuildContent IPersistableModel<ContainerRegistryDockerBuildContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryDockerBuildContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryDockerBuildContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
