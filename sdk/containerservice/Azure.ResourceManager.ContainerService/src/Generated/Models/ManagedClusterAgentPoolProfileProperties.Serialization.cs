// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAgentPoolProfileProperties : IUtf8JsonSerializable, IJsonModel<ManagedClusterAgentPoolProfileProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterAgentPoolProfileProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterAgentPoolProfileProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAgentPoolProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAgentPoolProfileProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(OSDiskSizeInGB))
            {
                writer.WritePropertyName("osDiskSizeGB"u8);
                writer.WriteNumberValue(OSDiskSizeInGB.Value);
            }
            if (Optional.IsDefined(OSDiskType))
            {
                writer.WritePropertyName("osDiskType"u8);
                writer.WriteStringValue(OSDiskType.Value.ToString());
            }
            if (Optional.IsDefined(KubeletDiskType))
            {
                writer.WritePropertyName("kubeletDiskType"u8);
                writer.WriteStringValue(KubeletDiskType.Value.ToString());
            }
            if (Optional.IsDefined(WorkloadRuntime))
            {
                writer.WritePropertyName("workloadRuntime"u8);
                writer.WriteStringValue(WorkloadRuntime.Value.ToString());
            }
            if (Optional.IsDefined(VnetSubnetId))
            {
                writer.WritePropertyName("vnetSubnetID"u8);
                writer.WriteStringValue(VnetSubnetId);
            }
            if (Optional.IsDefined(PodSubnetId))
            {
                writer.WritePropertyName("podSubnetID"u8);
                writer.WriteStringValue(PodSubnetId);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods"u8);
                writer.WriteNumberValue(MaxPods.Value);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(OSSku))
            {
                writer.WritePropertyName("osSKU"u8);
                writer.WriteStringValue(OSSku.Value.ToString());
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount"u8);
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(EnableAutoScaling))
            {
                writer.WritePropertyName("enableAutoScaling"u8);
                writer.WriteBooleanValue(EnableAutoScaling.Value);
            }
            if (Optional.IsDefined(ScaleDownMode))
            {
                writer.WritePropertyName("scaleDownMode"u8);
                writer.WriteStringValue(ScaleDownMode.Value.ToString());
            }
            if (Optional.IsDefined(AgentPoolType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AgentPoolType.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(OrchestratorVersion))
            {
                writer.WritePropertyName("orchestratorVersion"u8);
                writer.WriteStringValue(OrchestratorVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentOrchestratorVersion))
            {
                writer.WritePropertyName("currentOrchestratorVersion"u8);
                writer.WriteStringValue(CurrentOrchestratorVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeImageVersion))
            {
                writer.WritePropertyName("nodeImageVersion"u8);
                writer.WriteStringValue(NodeImageVersion);
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(PowerState))
            {
                writer.WritePropertyName("powerState"u8);
                writer.WriteObjectValue(PowerState);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableNodePublicIP))
            {
                writer.WritePropertyName("enableNodePublicIP"u8);
                writer.WriteBooleanValue(EnableNodePublicIP.Value);
            }
            if (Optional.IsDefined(NodePublicIPPrefixId))
            {
                writer.WritePropertyName("nodePublicIPPrefixID"u8);
                writer.WriteStringValue(NodePublicIPPrefixId);
            }
            if (Optional.IsDefined(ScaleSetPriority))
            {
                writer.WritePropertyName("scaleSetPriority"u8);
                writer.WriteStringValue(ScaleSetPriority.Value.ToString());
            }
            if (Optional.IsDefined(ScaleSetEvictionPolicy))
            {
                writer.WritePropertyName("scaleSetEvictionPolicy"u8);
                writer.WriteStringValue(ScaleSetEvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SpotMaxPrice))
            {
                writer.WritePropertyName("spotMaxPrice"u8);
                writer.WriteNumberValue(SpotMaxPrice.Value);
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
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels"u8);
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProximityPlacementGroupId))
            {
                writer.WritePropertyName("proximityPlacementGroupID"u8);
                writer.WriteStringValue(ProximityPlacementGroupId);
            }
            if (Optional.IsDefined(KubeletConfig))
            {
                writer.WritePropertyName("kubeletConfig"u8);
                writer.WriteObjectValue(KubeletConfig);
            }
            if (Optional.IsDefined(LinuxOSConfig))
            {
                writer.WritePropertyName("linuxOSConfig"u8);
                writer.WriteObjectValue(LinuxOSConfig);
            }
            if (Optional.IsDefined(EnableEncryptionAtHost))
            {
                writer.WritePropertyName("enableEncryptionAtHost"u8);
                writer.WriteBooleanValue(EnableEncryptionAtHost.Value);
            }
            if (Optional.IsDefined(EnableUltraSsd))
            {
                writer.WritePropertyName("enableUltraSSD"u8);
                writer.WriteBooleanValue(EnableUltraSsd.Value);
            }
            if (Optional.IsDefined(EnableFips))
            {
                writer.WritePropertyName("enableFIPS"u8);
                writer.WriteBooleanValue(EnableFips.Value);
            }
            if (Optional.IsDefined(GpuInstanceProfile))
            {
                writer.WritePropertyName("gpuInstanceProfile"u8);
                writer.WriteStringValue(GpuInstanceProfile.Value.ToString());
            }
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData"u8);
                writer.WriteObjectValue(CreationData);
            }
            if (Optional.IsDefined(CapacityReservationGroupId))
            {
                writer.WritePropertyName("capacityReservationGroupID"u8);
                writer.WriteStringValue(CapacityReservationGroupId);
            }
            if (Optional.IsDefined(HostGroupId))
            {
                writer.WritePropertyName("hostGroupID"u8);
                writer.WriteStringValue(HostGroupId);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
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

        ManagedClusterAgentPoolProfileProperties IJsonModel<ManagedClusterAgentPoolProfileProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAgentPoolProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAgentPoolProfileProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterAgentPoolProfileProperties(document.RootElement, options);
        }

        internal static ManagedClusterAgentPoolProfileProperties DeserializeManagedClusterAgentPoolProfileProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? count = default;
            string vmSize = default;
            int? osDiskSizeGB = default;
            ContainerServiceOSDiskType? osDiskType = default;
            KubeletDiskType? kubeletDiskType = default;
            WorkloadRuntime? workloadRuntime = default;
            ResourceIdentifier vnetSubnetId = default;
            ResourceIdentifier podSubnetId = default;
            int? maxPods = default;
            ContainerServiceOSType? osType = default;
            ContainerServiceOSSku? osSku = default;
            int? maxCount = default;
            int? minCount = default;
            bool? enableAutoScaling = default;
            ScaleDownMode? scaleDownMode = default;
            AgentPoolType? type = default;
            AgentPoolMode? mode = default;
            string orchestratorVersion = default;
            string currentOrchestratorVersion = default;
            string nodeImageVersion = default;
            AgentPoolUpgradeSettings upgradeSettings = default;
            string provisioningState = default;
            ContainerServicePowerState powerState = default;
            IList<string> availabilityZones = default;
            bool? enableNodePublicIP = default;
            ResourceIdentifier nodePublicIPPrefixId = default;
            ScaleSetPriority? scaleSetPriority = default;
            ScaleSetEvictionPolicy? scaleSetEvictionPolicy = default;
            float? spotMaxPrice = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, string> nodeLabels = default;
            IList<string> nodeTaints = default;
            ResourceIdentifier proximityPlacementGroupId = default;
            KubeletConfig kubeletConfig = default;
            LinuxOSConfig linuxOSConfig = default;
            bool? enableEncryptionAtHost = default;
            bool? enableUltraSsd = default;
            bool? enableFIPS = default;
            GpuInstanceProfile? gpuInstanceProfile = default;
            ContainerServiceCreationData creationData = default;
            ResourceIdentifier capacityReservationGroupId = default;
            ResourceIdentifier hostGroupId = default;
            AgentPoolNetworkProfile networkProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDiskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDiskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osDiskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDiskType = new ContainerServiceOSDiskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kubeletDiskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kubeletDiskType = new KubeletDiskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workloadRuntime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadRuntime = new WorkloadRuntime(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetSubnetID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("podSubnetID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    podSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxPods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPods = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new ContainerServiceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osSKU"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osSku = new ContainerServiceOSSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableAutoScaling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutoScaling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scaleDownMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleDownMode = new ScaleDownMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AgentPoolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new AgentPoolMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orchestratorVersion"u8))
                {
                    orchestratorVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentOrchestratorVersion"u8))
                {
                    currentOrchestratorVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeImageVersion"u8))
                {
                    nodeImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    powerState = ContainerServicePowerState.DeserializeContainerServicePowerState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("availabilityZones"u8))
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
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("enableNodePublicIP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableNodePublicIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nodePublicIPPrefixID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodePublicIPPrefixId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scaleSetPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleSetPriority = new ScaleSetPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scaleSetEvictionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleSetEvictionPolicy = new ScaleSetEvictionPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("spotMaxPrice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spotMaxPrice = property.Value.GetSingle();
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
                if (property.NameEquals("nodeLabels"u8))
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
                    nodeLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeTaints"u8))
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
                    nodeTaints = array;
                    continue;
                }
                if (property.NameEquals("proximityPlacementGroupID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    proximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kubeletConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kubeletConfig = KubeletConfig.DeserializeKubeletConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxOSConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxOSConfig = LinuxOSConfig.DeserializeLinuxOSConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableEncryptionAtHost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableEncryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableUltraSSD"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableUltraSsd = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableFIPS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableFIPS = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gpuInstanceProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gpuInstanceProfile = new GpuInstanceProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("creationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationData = ContainerServiceCreationData.DeserializeContainerServiceCreationData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("capacityReservationGroupID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityReservationGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostGroupID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = AgentPoolNetworkProfile.DeserializeAgentPoolNetworkProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterAgentPoolProfileProperties(
                count,
                vmSize,
                osDiskSizeGB,
                osDiskType,
                kubeletDiskType,
                workloadRuntime,
                vnetSubnetId,
                podSubnetId,
                maxPods,
                osType,
                osSku,
                maxCount,
                minCount,
                enableAutoScaling,
                scaleDownMode,
                type,
                mode,
                orchestratorVersion,
                currentOrchestratorVersion,
                nodeImageVersion,
                upgradeSettings,
                provisioningState,
                powerState,
                availabilityZones ?? new ChangeTrackingList<string>(),
                enableNodePublicIP,
                nodePublicIPPrefixId,
                scaleSetPriority,
                scaleSetEvictionPolicy,
                spotMaxPrice,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                nodeLabels ?? new ChangeTrackingDictionary<string, string>(),
                nodeTaints ?? new ChangeTrackingList<string>(),
                proximityPlacementGroupId,
                kubeletConfig,
                linuxOSConfig,
                enableEncryptionAtHost,
                enableUltraSsd,
                enableFIPS,
                gpuInstanceProfile,
                creationData,
                capacityReservationGroupId,
                hostGroupId,
                networkProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterAgentPoolProfileProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAgentPoolProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAgentPoolProfileProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterAgentPoolProfileProperties IPersistableModel<ManagedClusterAgentPoolProfileProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAgentPoolProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterAgentPoolProfileProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAgentPoolProfileProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterAgentPoolProfileProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
