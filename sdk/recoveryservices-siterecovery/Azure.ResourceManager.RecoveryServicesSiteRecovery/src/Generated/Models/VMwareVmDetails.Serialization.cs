// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareVmDetails : IUtf8JsonSerializable, IJsonModel<VMwareVmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareVmDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareVmDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AgentGeneratedId))
            {
                writer.WritePropertyName("agentGeneratedId"u8);
                writer.WriteStringValue(AgentGeneratedId);
            }
            if (Optional.IsDefined(AgentInstalled))
            {
                writer.WritePropertyName("agentInstalled"u8);
                writer.WriteStringValue(AgentInstalled);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (Optional.IsDefined(PoweredOn))
            {
                writer.WritePropertyName("poweredOn"u8);
                writer.WriteStringValue(PoweredOn);
            }
            if (Optional.IsDefined(VCenterInfrastructureId))
            {
                writer.WritePropertyName("vCenterInfrastructureId"u8);
                writer.WriteStringValue(VCenterInfrastructureId);
            }
            if (Optional.IsDefined(DiscoveryType))
            {
                writer.WritePropertyName("discoveryType"u8);
                writer.WriteStringValue(DiscoveryType);
            }
            if (Optional.IsCollectionDefined(DiskDetails))
            {
                writer.WritePropertyName("diskDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DiskDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VMwareVmDetails IJsonModel<VMwareVmDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareVmDetails(document.RootElement, options);
        }

        internal static VMwareVmDetails DeserializeVMwareVmDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string agentGeneratedId = default;
            string agentInstalled = default;
            string osType = default;
            string agentVersion = default;
            IPAddress ipAddress = default;
            string poweredOn = default;
            string vCenterInfrastructureId = default;
            string discoveryType = default;
            IReadOnlyList<InMageDiskDetails> diskDetails = default;
            IReadOnlyList<SiteRecoveryHealthError> validationErrors = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentGeneratedId"u8))
                {
                    agentGeneratedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentInstalled"u8))
                {
                    agentInstalled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("poweredOn"u8))
                {
                    poweredOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCenterInfrastructureId"u8))
                {
                    vCenterInfrastructureId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveryType"u8))
                {
                    discoveryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageDiskDetails> array = new List<InMageDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageDiskDetails.DeserializeInMageDiskDetails(item, options));
                    }
                    diskDetails = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareVmDetails(
                instanceType,
                serializedAdditionalRawData,
                agentGeneratedId,
                agentInstalled,
                osType,
                agentVersion,
                ipAddress,
                poweredOn,
                vCenterInfrastructureId,
                discoveryType,
                diskDetails ?? new ChangeTrackingList<InMageDiskDetails>(),
                validationErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>());
        }

        BinaryData IPersistableModel<VMwareVmDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{options.Format}' format.");
            }
        }

        VMwareVmDetails IPersistableModel<VMwareVmDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareVmDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareVmDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
