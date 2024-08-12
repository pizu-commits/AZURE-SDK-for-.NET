// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MigrationDiscoverySap.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    public partial class SapDiscoveryServerInstanceData : IUtf8JsonSerializable, IJsonModel<SapDiscoveryServerInstanceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapDiscoveryServerInstanceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SapDiscoveryServerInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiscoveryServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapDiscoveryServerInstanceData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(SapInstanceType))
            {
                writer.WritePropertyName("sapInstanceType"u8);
                writer.WriteStringValue(SapInstanceType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceSid))
            {
                writer.WritePropertyName("instanceSid"u8);
                writer.WriteStringValue(InstanceSid);
            }
            if (options.Format != "W" && Optional.IsDefined(SapProduct))
            {
                writer.WritePropertyName("sapProduct"u8);
                writer.WriteStringValue(SapProduct);
            }
            if (options.Format != "W" && Optional.IsDefined(SapProductVersion))
            {
                writer.WritePropertyName("sapProductVersion"u8);
                writer.WriteStringValue(SapProductVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(OperatingSystem))
            {
                writer.WritePropertyName("operatingSystem"u8);
                writer.WriteStringValue(OperatingSystem.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationData))
            {
                writer.WritePropertyName("configurationData"u8);
                writer.WriteObjectValue(ConfigurationData, options);
            }
            if (options.Format != "W" && Optional.IsDefined(PerformanceData))
            {
                writer.WritePropertyName("performanceData"u8);
                writer.WriteObjectValue(PerformanceData, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteObjectValue(Errors, options);
            }
            writer.WriteEndObject();
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

        SapDiscoveryServerInstanceData IJsonModel<SapDiscoveryServerInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiscoveryServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapDiscoveryServerInstanceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapDiscoveryServerInstanceData(document.RootElement, options);
        }

        internal static SapDiscoveryServerInstanceData DeserializeSapDiscoveryServerInstanceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string serverName = default;
            SapInstanceType? sapInstanceType = default;
            string instanceSid = default;
            string sapProduct = default;
            string sapProductVersion = default;
            SapDiscoveryOperatingSystem? operatingSystem = default;
            ConfigurationDetail configurationData = default;
            PerformanceDetail performanceData = default;
            SapDiscoveryProvisioningState? provisioningState = default;
            SapMigrateError errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sapInstanceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sapInstanceType = new SapInstanceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("instanceSid"u8))
                        {
                            instanceSid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sapProduct"u8))
                        {
                            sapProduct = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sapProductVersion"u8))
                        {
                            sapProductVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatingSystem"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operatingSystem = new SapDiscoveryOperatingSystem(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("configurationData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationData = ConfigurationDetail.DeserializeConfigurationDetail(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("performanceData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            performanceData = PerformanceDetail.DeserializePerformanceDetail(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SapDiscoveryProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errors = SapMigrateError.DeserializeSapMigrateError(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SapDiscoveryServerInstanceData(
                id,
                name,
                type,
                systemData,
                serverName,
                sapInstanceType,
                instanceSid,
                sapProduct,
                sapProductVersion,
                operatingSystem,
                configurationData,
                performanceData,
                provisioningState,
                errors,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapDiscoveryServerInstanceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiscoveryServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapDiscoveryServerInstanceData)} does not support writing '{options.Format}' format.");
            }
        }

        SapDiscoveryServerInstanceData IPersistableModel<SapDiscoveryServerInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiscoveryServerInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapDiscoveryServerInstanceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapDiscoveryServerInstanceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapDiscoveryServerInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
