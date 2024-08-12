// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerInstance
{
    public partial class ContainerGroupData : IUtf8JsonSerializable, IJsonModel<ContainerGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerGroupData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WritePropertyName("containers"u8);
            writer.WriteStartArray();
            foreach (var item in Containers)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ImageRegistryCredentials))
            {
                writer.WritePropertyName("imageRegistryCredentials"u8);
                writer.WriteStartArray();
                foreach (var item in ImageRegistryCredentials)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RestartPolicy))
            {
                writer.WritePropertyName("restartPolicy"u8);
                writer.WriteStringValue(RestartPolicy.Value.ToString());
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteObjectValue(IPAddress, options);
            }
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceView))
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView, options);
            }
            if (Optional.IsDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteObjectValue(Diagnostics, options);
            }
            if (Optional.IsCollectionDefined(SubnetIds))
            {
                writer.WritePropertyName("subnetIds"u8);
                writer.WriteStartArray();
                foreach (var item in SubnetIds)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DnsConfig))
            {
                writer.WritePropertyName("dnsConfig"u8);
                writer.WriteObjectValue(DnsConfig, options);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku.Value.ToString());
            }
            if (Optional.IsDefined(EncryptionProperties))
            {
                writer.WritePropertyName("encryptionProperties"u8);
                writer.WriteObjectValue(EncryptionProperties, options);
            }
            if (Optional.IsCollectionDefined(InitContainers))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ConfidentialComputeProperties))
            {
                writer.WritePropertyName("confidentialComputeProperties"u8);
                writer.WriteObjectValue(ConfidentialComputeProperties, options);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteStringValue(Priority.Value.ToString());
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

        ContainerGroupData IJsonModel<ContainerGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupData(document.RootElement, options);
        }

        internal static ContainerGroupData DeserializeContainerGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            IList<string> zones = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string provisioningState = default;
            IList<ContainerInstanceContainer> containers = default;
            IList<ContainerGroupImageRegistryCredential> imageRegistryCredentials = default;
            ContainerGroupRestartPolicy? restartPolicy = default;
            ContainerGroupIPAddress ipAddress = default;
            ContainerInstanceOperatingSystemType osType = default;
            IList<ContainerVolume> volumes = default;
            ContainerGroupInstanceView instanceView = default;
            ContainerGroupDiagnostics diagnostics = default;
            IList<ContainerGroupSubnetId> subnetIds = default;
            ContainerGroupDnsConfiguration dnsConfig = default;
            ContainerGroupSku? sku = default;
            ContainerGroupEncryptionProperties encryptionProperties = default;
            IList<InitContainerDefinitionContent> initContainers = default;
            IList<DeploymentExtensionSpec> extensions = default;
            ConfidentialComputeProperties confidentialComputeProperties = default;
            ContainerGroupPriority? priority = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containers"u8))
                        {
                            List<ContainerInstanceContainer> array = new List<ContainerInstanceContainer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerInstanceContainer.DeserializeContainerInstanceContainer(item, options));
                            }
                            containers = array;
                            continue;
                        }
                        if (property0.NameEquals("imageRegistryCredentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerGroupImageRegistryCredential> array = new List<ContainerGroupImageRegistryCredential>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerGroupImageRegistryCredential.DeserializeContainerGroupImageRegistryCredential(item, options));
                            }
                            imageRegistryCredentials = array;
                            continue;
                        }
                        if (property0.NameEquals("restartPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restartPolicy = new ContainerGroupRestartPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipAddress = ContainerGroupIPAddress.DeserializeContainerGroupIPAddress(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = new ContainerInstanceOperatingSystemType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("volumes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerVolume> array = new List<ContainerVolume>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerVolume.DeserializeContainerVolume(item, options));
                            }
                            volumes = array;
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = ContainerGroupInstanceView.DeserializeContainerGroupInstanceView(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("diagnostics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnostics = ContainerGroupDiagnostics.DeserializeContainerGroupDiagnostics(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("subnetIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerGroupSubnetId> array = new List<ContainerGroupSubnetId>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerGroupSubnetId.DeserializeContainerGroupSubnetId(item, options));
                            }
                            subnetIds = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsConfig = ContainerGroupDnsConfiguration.DeserializeContainerGroupDnsConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = new ContainerGroupSku(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionProperties = ContainerGroupEncryptionProperties.DeserializeContainerGroupEncryptionProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("initContainers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<InitContainerDefinitionContent> array = new List<InitContainerDefinitionContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InitContainerDefinitionContent.DeserializeInitContainerDefinitionContent(item, options));
                            }
                            initContainers = array;
                            continue;
                        }
                        if (property0.NameEquals("extensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeploymentExtensionSpec> array = new List<DeploymentExtensionSpec>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeploymentExtensionSpec.DeserializeDeploymentExtensionSpec(item, options));
                            }
                            extensions = array;
                            continue;
                        }
                        if (property0.NameEquals("confidentialComputeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidentialComputeProperties = ConfidentialComputeProperties.DeserializeConfidentialComputeProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = new ContainerGroupPriority(property0.Value.GetString());
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
            return new ContainerGroupData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                provisioningState,
                containers,
                imageRegistryCredentials ?? new ChangeTrackingList<ContainerGroupImageRegistryCredential>(),
                restartPolicy,
                ipAddress,
                osType,
                volumes ?? new ChangeTrackingList<ContainerVolume>(),
                instanceView,
                diagnostics,
                subnetIds ?? new ChangeTrackingList<ContainerGroupSubnetId>(),
                dnsConfig,
                sku,
                encryptionProperties,
                initContainers ?? new ChangeTrackingList<InitContainerDefinitionContent>(),
                extensions ?? new ChangeTrackingList<DeploymentExtensionSpec>(),
                confidentialComputeProperties,
                priority,
                zones ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupData)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerGroupData IPersistableModel<ContainerGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
