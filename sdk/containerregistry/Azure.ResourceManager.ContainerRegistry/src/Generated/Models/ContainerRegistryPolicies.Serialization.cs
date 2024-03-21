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
    public partial class ContainerRegistryPolicies : IUtf8JsonSerializable, IJsonModel<ContainerRegistryPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryPolicies>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryPolicies>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryPolicies)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(QuarantinePolicy))
            {
                writer.WritePropertyName("quarantinePolicy"u8);
                writer.WriteObjectValue(QuarantinePolicy);
            }
            if (Optional.IsDefined(TrustPolicy))
            {
                writer.WritePropertyName("trustPolicy"u8);
                writer.WriteObjectValue(TrustPolicy);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsDefined(ExportPolicy))
            {
                writer.WritePropertyName("exportPolicy"u8);
                writer.WriteObjectValue(ExportPolicy);
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

        ContainerRegistryPolicies IJsonModel<ContainerRegistryPolicies>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryPolicies)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryPolicies(document.RootElement, options);
        }

        internal static ContainerRegistryPolicies DeserializeContainerRegistryPolicies(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerRegistryQuarantinePolicy quarantinePolicy = default;
            ContainerRegistryTrustPolicy trustPolicy = default;
            ContainerRegistryRetentionPolicy retentionPolicy = default;
            ContainerRegistryExportPolicy exportPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quarantinePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quarantinePolicy = ContainerRegistryQuarantinePolicy.DeserializeContainerRegistryQuarantinePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trustPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trustPolicy = ContainerRegistryTrustPolicy.DeserializeContainerRegistryTrustPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPolicy = ContainerRegistryRetentionPolicy.DeserializeContainerRegistryRetentionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("exportPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportPolicy = ContainerRegistryExportPolicy.DeserializeContainerRegistryExportPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryPolicies(quarantinePolicy, trustPolicy, retentionPolicy, exportPolicy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryPolicies>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryPolicies)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryPolicies IPersistableModel<ContainerRegistryPolicies>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryPolicies(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryPolicies)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryPolicies>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
