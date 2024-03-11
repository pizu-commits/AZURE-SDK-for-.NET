// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusNetworkFunctionImageApplication : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactProfile))
            {
                writer.WritePropertyName("artifactProfile"u8);
                writer.WriteObjectValue(ArtifactProfile);
            }
            if (Optional.IsDefined(DeployParametersMappingRuleProfile))
            {
                writer.WritePropertyName("deployParametersMappingRuleProfile"u8);
                writer.WriteObjectValue(DeployParametersMappingRuleProfile);
            }
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
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

        AzureOperatorNexusNetworkFunctionImageApplication IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusNetworkFunctionImageApplication(document.RootElement, options);
        }

        internal static AzureOperatorNexusNetworkFunctionImageApplication DeserializeAzureOperatorNexusNetworkFunctionImageApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureOperatorNexusImageArtifactProfile artifactProfile = default;
            AzureOperatorNexusImageDeployMappingRuleProfile deployParametersMappingRuleProfile = default;
            AzureOperatorNexusArtifactType artifactType = default;
            string name = default;
            DependsOnProfile dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactProfile = AzureOperatorNexusImageArtifactProfile.DeserializeAzureOperatorNexusImageArtifactProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deployParametersMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deployParametersMappingRuleProfile = AzureOperatorNexusImageDeployMappingRuleProfile.DeserializeAzureOperatorNexusImageDeployMappingRuleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureOperatorNexusArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureOperatorNexusNetworkFunctionImageApplication(
                name,
                dependsOnProfile,
                serializedAdditionalRawData,
                artifactType,
                artifactProfile,
                deployParametersMappingRuleProfile);
        }

        BinaryData IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support '{options.Format}' format.");
            }
        }

        AzureOperatorNexusNetworkFunctionImageApplication IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureOperatorNexusNetworkFunctionImageApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
