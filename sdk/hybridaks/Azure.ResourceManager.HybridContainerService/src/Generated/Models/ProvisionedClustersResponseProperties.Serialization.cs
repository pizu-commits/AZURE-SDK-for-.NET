// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClustersResponseProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(EnableRbac))
            {
                writer.WritePropertyName("enableRbac"u8);
                writer.WriteBooleanValue(EnableRbac.Value);
            }
            if (Core.Optional.IsDefined(LinuxProfile))
            {
                writer.WritePropertyName("linuxProfile"u8);
                writer.WriteObjectValue(LinuxProfile);
            }
            if (Core.Optional.IsDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteObjectValue(Features);
            }
            if (Core.Optional.IsCollectionDefined(AddonProfiles))
            {
                writer.WritePropertyName("addonProfiles"u8);
                writer.WriteStartObject();
                foreach (var item in AddonProfiles)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(ControlPlane))
            {
                writer.WritePropertyName("controlPlane"u8);
                writer.WriteObjectValue(ControlPlane);
            }
            if (Core.Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            if (Core.Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Core.Optional.IsDefined(NodeResourceGroup))
            {
                writer.WritePropertyName("nodeResourceGroup"u8);
                writer.WriteStringValue(NodeResourceGroup);
            }
            if (Core.Optional.IsCollectionDefined(AgentPoolProfiles))
            {
                writer.WritePropertyName("agentPoolProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in AgentPoolProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(CloudProviderProfile))
            {
                writer.WritePropertyName("cloudProviderProfile"u8);
                writer.WriteObjectValue(CloudProviderProfile);
            }
            if (Core.Optional.IsDefined(AadProfile))
            {
                writer.WritePropertyName("aadProfile"u8);
                writer.WriteObjectValue(AadProfile);
            }
            if (Core.Optional.IsDefined(WindowsProfile))
            {
                writer.WritePropertyName("windowsProfile"u8);
                writer.WriteObjectValue(WindowsProfile);
            }
            if (Core.Optional.IsDefined(HttpProxyConfig))
            {
                writer.WritePropertyName("httpProxyConfig"u8);
                writer.WriteObjectValue(HttpProxyConfig);
            }
            writer.WriteEndObject();
        }

        internal static ProvisionedClustersResponseProperties DeserializeProvisionedClustersResponseProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> enableRbac = default;
            Core.Optional<LinuxProfileProperties> linuxProfile = default;
            Core.Optional<ProvisionedClustersCommonPropertiesFeatures> features = default;
            Core.Optional<IDictionary<string, AddonProfiles>> addonProfiles = default;
            Core.Optional<ControlPlaneProfile> controlPlane = default;
            Core.Optional<string> kubernetesVersion = default;
            Core.Optional<NetworkProfile> networkProfile = default;
            Core.Optional<string> nodeResourceGroup = default;
            Core.Optional<IList<NamedAgentPoolProfile>> agentPoolProfiles = default;
            Core.Optional<CloudProviderProfile> cloudProviderProfile = default;
            Core.Optional<ProvisioningState> provisioningState = default;
            Core.Optional<ProvisionedClustersCommonPropertiesStatus> status = default;
            Core.Optional<AADProfileResponse> aadProfile = default;
            Core.Optional<WindowsProfileResponse> windowsProfile = default;
            Core.Optional<HttpProxyConfigResponse> httpProxyConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableRbac"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableRbac = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linuxProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxProfile = LinuxProfileProperties.DeserializeLinuxProfileProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    features = ProvisionedClustersCommonPropertiesFeatures.DeserializeProvisionedClustersCommonPropertiesFeatures(property.Value);
                    continue;
                }
                if (property.NameEquals("addonProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, AddonProfiles> dictionary = new Dictionary<string, AddonProfiles>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.AddonProfiles.DeserializeAddonProfiles(property0.Value));
                    }
                    addonProfiles = dictionary;
                    continue;
                }
                if (property.NameEquals("controlPlane"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlPlane = ControlPlaneProfile.DeserializeControlPlaneProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = NetworkProfile.DeserializeNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeResourceGroup"u8))
                {
                    nodeResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentPoolProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NamedAgentPoolProfile> array = new List<NamedAgentPoolProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NamedAgentPoolProfile.DeserializeNamedAgentPoolProfile(item));
                    }
                    agentPoolProfiles = array;
                    continue;
                }
                if (property.NameEquals("cloudProviderProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudProviderProfile = CloudProviderProfile.DeserializeCloudProviderProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ProvisionedClustersCommonPropertiesStatus.DeserializeProvisionedClustersCommonPropertiesStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("aadProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadProfile = AADProfileResponse.DeserializeAADProfileResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("windowsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsProfile = WindowsProfileResponse.DeserializeWindowsProfileResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("httpProxyConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpProxyConfig = HttpProxyConfigResponse.DeserializeHttpProxyConfigResponse(property.Value);
                    continue;
                }
            }
            return new ProvisionedClustersResponseProperties(aadProfile.Value, windowsProfile.Value, httpProxyConfig.Value, Core.Optional.ToNullable(enableRbac), linuxProfile.Value, features.Value, Core.Optional.ToDictionary(addonProfiles), controlPlane.Value, kubernetesVersion.Value, networkProfile.Value, nodeResourceGroup.Value, Core.Optional.ToList(agentPoolProfiles), cloudProviderProfile.Value, Core.Optional.ToNullable(provisioningState), status.Value);
        }
    }
}
