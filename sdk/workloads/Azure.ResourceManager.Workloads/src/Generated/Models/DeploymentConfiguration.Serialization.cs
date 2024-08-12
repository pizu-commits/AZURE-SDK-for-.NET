// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DeploymentConfiguration : IUtf8JsonSerializable, IJsonModel<DeploymentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation.Value);
            }
            if (Optional.IsDefined(InfrastructureConfiguration))
            {
                writer.WritePropertyName("infrastructureConfiguration"u8);
                writer.WriteObjectValue(InfrastructureConfiguration, options);
            }
            if (Optional.IsDefined(SoftwareConfiguration))
            {
                writer.WritePropertyName("softwareConfiguration"u8);
                writer.WriteObjectValue(SoftwareConfiguration, options);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        DeploymentConfiguration IJsonModel<DeploymentConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentConfiguration(document.RootElement, options);
        }

        internal static DeploymentConfiguration DeserializeDeploymentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? appLocation = default;
            InfrastructureConfiguration infrastructureConfiguration = default;
            SapSoftwareConfiguration softwareConfiguration = default;
            SapConfigurationType configurationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureConfiguration = InfrastructureConfiguration.DeserializeInfrastructureConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("softwareConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softwareConfiguration = SapSoftwareConfiguration.DeserializeSapSoftwareConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new SapConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentConfiguration(configurationType, serializedAdditionalRawData, appLocation, infrastructureConfiguration, softwareConfiguration);
        }

        BinaryData IPersistableModel<DeploymentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentConfiguration IPersistableModel<DeploymentConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeploymentConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
