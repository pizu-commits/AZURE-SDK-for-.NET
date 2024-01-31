// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevCenterNetworkConnectionData : IUtf8JsonSerializable, IJsonModel<DevCenterNetworkConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterNetworkConnectionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevCenterNetworkConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterNetworkConnectionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsDefined(OrganizationUnit))
            {
                writer.WritePropertyName("organizationUnit"u8);
                writer.WriteStringValue(OrganizationUnit);
            }
            if (Optional.IsDefined(DomainUsername))
            {
                writer.WritePropertyName("domainUsername"u8);
                writer.WriteStringValue(DomainUsername);
            }
            if (Optional.IsDefined(DomainPassword))
            {
                writer.WritePropertyName("domainPassword"u8);
                writer.WriteStringValue(DomainPassword);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(HealthCheckStatus))
            {
                writer.WritePropertyName("healthCheckStatus"u8);
                writer.WriteStringValue(HealthCheckStatus.Value.ToString());
            }
            if (Optional.IsDefined(NetworkingResourceGroupName))
            {
                writer.WritePropertyName("networkingResourceGroupName"u8);
                writer.WriteStringValue(NetworkingResourceGroupName);
            }
            if (Optional.IsDefined(DomainJoinType))
            {
                writer.WritePropertyName("domainJoinType"u8);
                writer.WriteStringValue(DomainJoinType.Value.ToString());
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

        DevCenterNetworkConnectionData IJsonModel<DevCenterNetworkConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterNetworkConnectionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterNetworkConnectionData(document.RootElement, options);
        }

        internal static DevCenterNetworkConnectionData DeserializeDevCenterNetworkConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<string> domainName = default;
            Optional<string> organizationUnit = default;
            Optional<string> domainUsername = default;
            Optional<string> domainPassword = default;
            Optional<DevCenterProvisioningState> provisioningState = default;
            Optional<DevCenterHealthCheckStatus> healthCheckStatus = default;
            Optional<string> networkingResourceGroupName = default;
            Optional<DomainJoinType> domainJoinType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("subnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("domainName"u8))
                        {
                            domainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("organizationUnit"u8))
                        {
                            organizationUnit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainUsername"u8))
                        {
                            domainUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainPassword"u8))
                        {
                            domainPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DevCenterProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthCheckStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthCheckStatus = new DevCenterHealthCheckStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkingResourceGroupName"u8))
                        {
                            networkingResourceGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainJoinType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            domainJoinType = new DomainJoinType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevCenterNetworkConnectionData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, subnetId.Value, domainName.Value, organizationUnit.Value, domainUsername.Value, domainPassword.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(healthCheckStatus), networkingResourceGroupName.Value, Optional.ToNullable(domainJoinType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevCenterNetworkConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevCenterNetworkConnectionData)} does not support '{options.Format}' format.");
            }
        }

        DevCenterNetworkConnectionData IPersistableModel<DevCenterNetworkConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevCenterNetworkConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterNetworkConnectionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterNetworkConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
