// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistrySourceTriggerDescriptor : IUtf8JsonSerializable, IJsonModel<ContainerRegistrySourceTriggerDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistrySourceTriggerDescriptor>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistrySourceTriggerDescriptor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerDescriptor)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (Optional.IsDefined(CommitId))
            {
                writer.WritePropertyName("commitId"u8);
                writer.WriteStringValue(CommitId);
            }
            if (Optional.IsDefined(PullRequestId))
            {
                writer.WritePropertyName("pullRequestId"u8);
                writer.WriteStringValue(PullRequestId);
            }
            if (Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl"u8);
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BranchName))
            {
                writer.WritePropertyName("branchName"u8);
                writer.WriteStringValue(BranchName);
            }
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType);
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

        ContainerRegistrySourceTriggerDescriptor IJsonModel<ContainerRegistrySourceTriggerDescriptor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerDescriptor)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistrySourceTriggerDescriptor(document.RootElement, options);
        }

        internal static ContainerRegistrySourceTriggerDescriptor DeserializeContainerRegistrySourceTriggerDescriptor(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? id = default;
            string eventType = default;
            string commitId = default;
            string pullRequestId = default;
            Uri repositoryUrl = default;
            string branchName = default;
            string providerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitId"u8))
                {
                    commitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pullRequestId"u8))
                {
                    pullRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("branchName"u8))
                {
                    branchName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistrySourceTriggerDescriptor(
                id,
                eventType,
                commitId,
                pullRequestId,
                repositoryUrl,
                branchName,
                providerType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistrySourceTriggerDescriptor>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerDescriptor)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistrySourceTriggerDescriptor IPersistableModel<ContainerRegistrySourceTriggerDescriptor>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistrySourceTriggerDescriptor(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerDescriptor)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistrySourceTriggerDescriptor>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
