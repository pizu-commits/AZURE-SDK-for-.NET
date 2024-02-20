// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudKubernetesClusterData : IUtf8JsonSerializable, IJsonModel<NetworkCloudKubernetesClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudKubernetesClusterData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudKubernetesClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
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
            if (Optional.IsDefined(AadConfiguration))
            {
                writer.WritePropertyName("aadConfiguration"u8);
                writer.WriteObjectValue(AadConfiguration);
            }
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                writer.WriteObjectValue(AdministratorConfiguration);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AttachedNetworkIds))
            {
                writer.WritePropertyName("attachedNetworkIds"u8);
                writer.WriteStartArray();
                foreach (var item in AttachedNetworkIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AvailableUpgrades))
            {
                writer.WritePropertyName("availableUpgrades"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableUpgrades)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectedClusterId))
            {
                writer.WritePropertyName("connectedClusterId"u8);
                writer.WriteStringValue(ConnectedClusterId);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlPlaneKubernetesVersion))
            {
                writer.WritePropertyName("controlPlaneKubernetesVersion"u8);
                writer.WriteStringValue(ControlPlaneKubernetesVersion);
            }
            writer.WritePropertyName("controlPlaneNodeConfiguration"u8);
            writer.WriteObjectValue(ControlPlaneNodeConfiguration);
            if (options.Format != "W" && Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatusMessage))
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FeatureStatuses))
            {
                writer.WritePropertyName("featureStatuses"u8);
                writer.WriteStartArray();
                foreach (var item in FeatureStatuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("initialAgentPoolConfigurations"u8);
            writer.WriteStartArray();
            foreach (var item in InitialAgentPoolConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kubernetesVersion"u8);
            writer.WriteStringValue(KubernetesVersion);
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            writer.WritePropertyName("networkConfiguration"u8);
            writer.WriteObjectValue(NetworkConfiguration);
            if (options.Format != "W" && Optional.IsCollectionDefined(Nodes))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        NetworkCloudKubernetesClusterData IJsonModel<NetworkCloudKubernetesClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudKubernetesClusterData(document.RootElement, options);
        }

        internal static NetworkCloudKubernetesClusterData DeserializeNetworkCloudKubernetesClusterData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NetworkCloudAadConfiguration> aadConfiguration = default;
            Optional<AdministratorConfiguration> administratorConfiguration = default;
            Optional<IReadOnlyList<ResourceIdentifier>> attachedNetworkIds = default;
            Optional<IReadOnlyList<AvailableUpgrade>> availableUpgrades = default;
            Optional<ResourceIdentifier> clusterId = default;
            Optional<ResourceIdentifier> connectedClusterId = default;
            Optional<string> controlPlaneKubernetesVersion = default;
            ControlPlaneNodeConfiguration controlPlaneNodeConfiguration = default;
            Optional<KubernetesClusterDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<IReadOnlyList<FeatureStatus>> featureStatuses = default;
            IList<InitialAgentPoolConfiguration> initialAgentPoolConfigurations = default;
            string kubernetesVersion = default;
            Optional<ManagedResourceGroupConfiguration> managedResourceGroupConfiguration = default;
            KubernetesClusterNetworkConfiguration networkConfiguration = default;
            Optional<IReadOnlyList<KubernetesClusterNode>> nodes = default;
            Optional<KubernetesClusterProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value, options);
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
                        if (property0.NameEquals("aadConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadConfiguration = NetworkCloudAadConfiguration.DeserializeNetworkCloudAadConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("administratorConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administratorConfiguration = AdministratorConfiguration.DeserializeAdministratorConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("attachedNetworkIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            attachedNetworkIds = array;
                            continue;
                        }
                        if (property0.NameEquals("availableUpgrades"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AvailableUpgrade> array = new List<AvailableUpgrade>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AvailableUpgrade.DeserializeAvailableUpgrade(item, options));
                            }
                            availableUpgrades = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectedClusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectedClusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("controlPlaneKubernetesVersion"u8))
                        {
                            controlPlaneKubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("controlPlaneNodeConfiguration"u8))
                        {
                            controlPlaneNodeConfiguration = ControlPlaneNodeConfiguration.DeserializeControlPlaneNodeConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new KubernetesClusterDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("featureStatuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FeatureStatus> array = new List<FeatureStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FeatureStatus.DeserializeFeatureStatus(item, options));
                            }
                            featureStatuses = array;
                            continue;
                        }
                        if (property0.NameEquals("initialAgentPoolConfigurations"u8))
                        {
                            List<InitialAgentPoolConfiguration> array = new List<InitialAgentPoolConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InitialAgentPoolConfiguration.DeserializeInitialAgentPoolConfiguration(item, options));
                            }
                            initialAgentPoolConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkConfiguration"u8))
                        {
                            networkConfiguration = KubernetesClusterNetworkConfiguration.DeserializeKubernetesClusterNetworkConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KubernetesClusterNode> array = new List<KubernetesClusterNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KubernetesClusterNode.DeserializeKubernetesClusterNode(item, options));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KubernetesClusterProvisioningState(property0.Value.GetString());
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
            return new NetworkCloudKubernetesClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, aadConfiguration.Value, administratorConfiguration.Value, Optional.ToList(attachedNetworkIds), Optional.ToList(availableUpgrades), clusterId.Value, connectedClusterId.Value, controlPlaneKubernetesVersion.Value, controlPlaneNodeConfiguration, Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, Optional.ToList(featureStatuses), initialAgentPoolConfigurations, kubernetesVersion, managedResourceGroupConfiguration.Value, networkConfiguration, Optional.ToList(nodes), Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudKubernetesClusterData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterData)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudKubernetesClusterData IPersistableModel<NetworkCloudKubernetesClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudKubernetesClusterData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudKubernetesClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
