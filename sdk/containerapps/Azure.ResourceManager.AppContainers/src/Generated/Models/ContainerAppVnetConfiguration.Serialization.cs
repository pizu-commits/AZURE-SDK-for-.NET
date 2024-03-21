// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppVnetConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppVnetConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppVnetConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppVnetConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsInternal))
            {
                writer.WritePropertyName("internal"u8);
                writer.WriteBooleanValue(IsInternal.Value);
            }
            if (Optional.IsDefined(InfrastructureSubnetId))
            {
                writer.WritePropertyName("infrastructureSubnetId"u8);
                writer.WriteStringValue(InfrastructureSubnetId);
            }
            if (Optional.IsDefined(DockerBridgeCidr))
            {
                writer.WritePropertyName("dockerBridgeCidr"u8);
                writer.WriteStringValue(DockerBridgeCidr);
            }
            if (Optional.IsDefined(PlatformReservedCidr))
            {
                writer.WritePropertyName("platformReservedCidr"u8);
                writer.WriteStringValue(PlatformReservedCidr);
            }
            if (Optional.IsDefined(PlatformReservedDnsIP))
            {
                writer.WritePropertyName("platformReservedDnsIP"u8);
                writer.WriteStringValue(PlatformReservedDnsIP);
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

        ContainerAppVnetConfiguration IJsonModel<ContainerAppVnetConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppVnetConfiguration(document.RootElement, options);
        }

        internal static ContainerAppVnetConfiguration DeserializeContainerAppVnetConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? @internal = default;
            ResourceIdentifier infrastructureSubnetId = default;
            string dockerBridgeCidr = default;
            string platformReservedCidr = default;
            string platformReservedDnsIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("internal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @internal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("infrastructureSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dockerBridgeCidr"u8))
                {
                    dockerBridgeCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("platformReservedCidr"u8))
                {
                    platformReservedCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("platformReservedDnsIP"u8))
                {
                    platformReservedDnsIP = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppVnetConfiguration(
                @internal,
                infrastructureSubnetId,
                dockerBridgeCidr,
                platformReservedCidr,
                platformReservedDnsIP,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppVnetConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppVnetConfiguration IPersistableModel<ContainerAppVnetConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppVnetConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppVnetConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppVnetConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
