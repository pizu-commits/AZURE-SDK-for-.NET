// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppVolumeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("creationToken");
            writer.WriteStringValue(CreationToken);
            if (Optional.IsDefined(ServiceLevel))
            {
                writer.WritePropertyName("serviceLevel");
                writer.WriteStringValue(ServiceLevel.Value.ToString());
            }
            writer.WritePropertyName("usageThreshold");
            writer.WriteNumberValue(UsageThreshold);
            if (Optional.IsDefined(ExportPolicy))
            {
                writer.WritePropertyName("exportPolicy");
                writer.WriteObjectValue(ExportPolicy);
            }
            if (Optional.IsCollectionDefined(ProtocolTypes))
            {
                writer.WritePropertyName("protocolTypes");
                writer.WriteStartArray();
                foreach (var item in ProtocolTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SnapshotId))
            {
                if (SnapshotId != null)
                {
                    writer.WritePropertyName("snapshotId");
                    writer.WriteStringValue(SnapshotId.Value);
                }
                else
                {
                    writer.WriteNull("snapshotId");
                }
            }
            if (Optional.IsDefined(BackupId))
            {
                if (BackupId != null)
                {
                    writer.WritePropertyName("backupId");
                    writer.WriteStringValue(BackupId.Value);
                }
                else
                {
                    writer.WriteNull("backupId");
                }
            }
            writer.WritePropertyName("subnetId");
            writer.WriteStringValue(SubnetId);
            if (Optional.IsDefined(NetworkFeatures))
            {
                writer.WritePropertyName("networkFeatures");
                writer.WriteStringValue(NetworkFeatures.Value.ToString());
            }
            if (Optional.IsDefined(VolumeType))
            {
                writer.WritePropertyName("volumeType");
                writer.WriteStringValue(VolumeType);
            }
            if (Optional.IsDefined(DataProtection))
            {
                writer.WritePropertyName("dataProtection");
                writer.WriteObjectValue(DataProtection);
            }
            if (Optional.IsDefined(IsRestoring))
            {
                writer.WritePropertyName("isRestoring");
                writer.WriteBooleanValue(IsRestoring.Value);
            }
            if (Optional.IsDefined(IsSnapshotDirectoryVisible))
            {
                writer.WritePropertyName("snapshotDirectoryVisible");
                writer.WriteBooleanValue(IsSnapshotDirectoryVisible.Value);
            }
            if (Optional.IsDefined(IsKerberosEnabled))
            {
                writer.WritePropertyName("kerberosEnabled");
                writer.WriteBooleanValue(IsKerberosEnabled.Value);
            }
            if (Optional.IsDefined(SecurityStyle))
            {
                writer.WritePropertyName("securityStyle");
                writer.WriteStringValue(SecurityStyle.Value.ToString());
            }
            if (Optional.IsDefined(IsSmbEncryptionEnabled))
            {
                writer.WritePropertyName("smbEncryption");
                writer.WriteBooleanValue(IsSmbEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(IsSmbContinuouslyAvailable))
            {
                writer.WritePropertyName("smbContinuouslyAvailable");
                writer.WriteBooleanValue(IsSmbContinuouslyAvailable.Value);
            }
            if (Optional.IsDefined(ThroughputMibps))
            {
                writer.WritePropertyName("throughputMibps");
                writer.WriteNumberValue(ThroughputMibps.Value);
            }
            if (Optional.IsDefined(EncryptionKeySource))
            {
                writer.WritePropertyName("encryptionKeySource");
                writer.WriteStringValue(EncryptionKeySource.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultPrivateEndpointResourceId))
            {
                writer.WritePropertyName("keyVaultPrivateEndpointResourceId");
                writer.WriteStringValue(KeyVaultPrivateEndpointResourceId);
            }
            if (Optional.IsDefined(IsLdapEnabled))
            {
                writer.WritePropertyName("ldapEnabled");
                writer.WriteBooleanValue(IsLdapEnabled.Value);
            }
            if (Optional.IsDefined(IsCoolAccessEnabled))
            {
                writer.WritePropertyName("coolAccess");
                writer.WriteBooleanValue(IsCoolAccessEnabled.Value);
            }
            if (Optional.IsDefined(CoolnessPeriod))
            {
                writer.WritePropertyName("coolnessPeriod");
                writer.WriteNumberValue(CoolnessPeriod.Value);
            }
            if (Optional.IsDefined(UnixPermissions))
            {
                if (UnixPermissions != null)
                {
                    writer.WritePropertyName("unixPermissions");
                    writer.WriteStringValue(UnixPermissions);
                }
                else
                {
                    writer.WriteNull("unixPermissions");
                }
            }
            if (Optional.IsDefined(AvsDataStore))
            {
                writer.WritePropertyName("avsDataStore");
                writer.WriteStringValue(AvsDataStore.Value.ToString());
            }
            if (Optional.IsDefined(IsDefaultQuotaEnabled))
            {
                writer.WritePropertyName("isDefaultQuotaEnabled");
                writer.WriteBooleanValue(IsDefaultQuotaEnabled.Value);
            }
            if (Optional.IsDefined(DefaultUserQuotaInKiBs))
            {
                writer.WritePropertyName("defaultUserQuotaInKiBs");
                writer.WriteNumberValue(DefaultUserQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(DefaultGroupQuotaInKiBs))
            {
                writer.WritePropertyName("defaultGroupQuotaInKiBs");
                writer.WriteNumberValue(DefaultGroupQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(CapacityPoolResourceId))
            {
                writer.WritePropertyName("capacityPoolResourceId");
                writer.WriteStringValue(CapacityPoolResourceId);
            }
            if (Optional.IsDefined(ProximityPlacementGroupId))
            {
                writer.WritePropertyName("proximityPlacementGroup");
                writer.WriteStringValue(ProximityPlacementGroupId);
            }
            if (Optional.IsDefined(VolumeSpecName))
            {
                writer.WritePropertyName("volumeSpecName");
                writer.WriteStringValue(VolumeSpecName);
            }
            if (Optional.IsCollectionDefined(PlacementRules))
            {
                writer.WritePropertyName("placementRules");
                writer.WriteStartArray();
                foreach (var item in PlacementRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableSubvolumes))
            {
                writer.WritePropertyName("enableSubvolumes");
                writer.WriteStringValue(EnableSubvolumes.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetAppVolumeData DeserializeNetAppVolumeData(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<IList<string>> zones = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> fileSystemId = default;
            string creationToken = default;
            Optional<NetAppFileServiceLevel> serviceLevel = default;
            long usageThreshold = default;
            Optional<VolumePropertiesExportPolicy> exportPolicy = default;
            Optional<IList<string>> protocolTypes = default;
            Optional<string> provisioningState = default;
            Optional<Guid?> snapshotId = default;
            Optional<Guid?> backupId = default;
            Optional<string> baremetalTenantId = default;
            ResourceIdentifier subnetId = default;
            Optional<NetAppNetworkFeature> networkFeatures = default;
            Optional<Guid> networkSiblingSetId = default;
            Optional<NetAppVolumeStorageToNetworkProximity> storageToNetworkProximity = default;
            Optional<IReadOnlyList<NetAppVolumeMountTarget>> mountTargets = default;
            Optional<string> volumeType = default;
            Optional<NetAppVolumeDataProtection> dataProtection = default;
            Optional<bool> isRestoring = default;
            Optional<bool> snapshotDirectoryVisible = default;
            Optional<bool> kerberosEnabled = default;
            Optional<NetAppVolumeSecurityStyle> securityStyle = default;
            Optional<bool> smbEncryption = default;
            Optional<bool> smbContinuouslyAvailable = default;
            Optional<float> throughputMibps = default;
            Optional<NetAppEncryptionKeySource> encryptionKeySource = default;
            Optional<ResourceIdentifier> keyVaultPrivateEndpointResourceId = default;
            Optional<bool> ldapEnabled = default;
            Optional<bool> coolAccess = default;
            Optional<int> coolnessPeriod = default;
            Optional<string> unixPermissions = default;
            Optional<int?> cloneProgress = default;
            Optional<NetAppAvsDataStore> avsDataStore = default;
            Optional<bool> isDefaultQuotaEnabled = default;
            Optional<long> defaultUserQuotaInKiBs = default;
            Optional<long> defaultGroupQuotaInKiBs = default;
            Optional<long> maximumNumberOfFiles = default;
            Optional<string> volumeGroupName = default;
            Optional<ResourceIdentifier> capacityPoolResourceId = default;
            Optional<ResourceIdentifier> proximityPlacementGroup = default;
            Optional<string> t2Network = default;
            Optional<string> volumeSpecName = default;
            Optional<bool> encrypted = default;
            Optional<IList<NetAppVolumePlacementRule>> placementRules = default;
            Optional<EnableNetAppSubvolume> enableSubvolumes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("fileSystemId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            fileSystemId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("creationToken"))
                        {
                            creationToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serviceLevel = new NetAppFileServiceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usageThreshold"))
                        {
                            usageThreshold = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("exportPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            exportPolicy = VolumePropertiesExportPolicy.DeserializeVolumePropertiesExportPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocolTypes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            protocolTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("snapshotId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                snapshotId = null;
                                continue;
                            }
                            snapshotId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("backupId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                backupId = null;
                                continue;
                            }
                            backupId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("baremetalTenantId"))
                        {
                            baremetalTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetId"))
                        {
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkFeatures"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkFeatures = new NetAppNetworkFeature(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkSiblingSetId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkSiblingSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageToNetworkProximity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageToNetworkProximity = new NetAppVolumeStorageToNetworkProximity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mountTargets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NetAppVolumeMountTarget> array = new List<NetAppVolumeMountTarget>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetAppVolumeMountTarget.DeserializeNetAppVolumeMountTarget(item));
                            }
                            mountTargets = array;
                            continue;
                        }
                        if (property0.NameEquals("volumeType"))
                        {
                            volumeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataProtection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataProtection = NetAppVolumeDataProtection.DeserializeNetAppVolumeDataProtection(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isRestoring"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isRestoring = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("snapshotDirectoryVisible"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            snapshotDirectoryVisible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("kerberosEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kerberosEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("securityStyle"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            securityStyle = new NetAppVolumeSecurityStyle(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("smbEncryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            smbEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("smbContinuouslyAvailable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            smbContinuouslyAvailable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("throughputMibps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            throughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKeySource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptionKeySource = new NetAppEncryptionKeySource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("keyVaultPrivateEndpointResourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyVaultPrivateEndpointResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ldapEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ldapEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coolAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            coolAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coolnessPeriod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            coolnessPeriod = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unixPermissions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                unixPermissions = null;
                                continue;
                            }
                            unixPermissions = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloneProgress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cloneProgress = null;
                                continue;
                            }
                            cloneProgress = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("avsDataStore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            avsDataStore = new NetAppAvsDataStore(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isDefaultQuotaEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDefaultQuotaEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultUserQuotaInKiBs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultUserQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("defaultGroupQuotaInKiBs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultGroupQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfFiles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maximumNumberOfFiles = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("volumeGroupName"))
                        {
                            volumeGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("capacityPoolResourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            capacityPoolResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            proximityPlacementGroup = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("t2Network"))
                        {
                            t2Network = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("volumeSpecName"))
                        {
                            volumeSpecName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encrypted"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encrypted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("placementRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NetAppVolumePlacementRule> array = new List<NetAppVolumePlacementRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetAppVolumePlacementRule.DeserializeNetAppVolumePlacementRule(item));
                            }
                            placementRules = array;
                            continue;
                        }
                        if (property0.NameEquals("enableSubvolumes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableSubvolumes = new EnableNetAppSubvolume(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetAppVolumeData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), Optional.ToList(zones), Optional.ToNullable(fileSystemId), creationToken, Optional.ToNullable(serviceLevel), usageThreshold, exportPolicy.Value, Optional.ToList(protocolTypes), provisioningState.Value, Optional.ToNullable(snapshotId), Optional.ToNullable(backupId), baremetalTenantId.Value, subnetId, Optional.ToNullable(networkFeatures), Optional.ToNullable(networkSiblingSetId), Optional.ToNullable(storageToNetworkProximity), Optional.ToList(mountTargets), volumeType.Value, dataProtection.Value, Optional.ToNullable(isRestoring), Optional.ToNullable(snapshotDirectoryVisible), Optional.ToNullable(kerberosEnabled), Optional.ToNullable(securityStyle), Optional.ToNullable(smbEncryption), Optional.ToNullable(smbContinuouslyAvailable), Optional.ToNullable(throughputMibps), Optional.ToNullable(encryptionKeySource), keyVaultPrivateEndpointResourceId.Value, Optional.ToNullable(ldapEnabled), Optional.ToNullable(coolAccess), Optional.ToNullable(coolnessPeriod), unixPermissions.Value, Optional.ToNullable(cloneProgress), Optional.ToNullable(avsDataStore), Optional.ToNullable(isDefaultQuotaEnabled), Optional.ToNullable(defaultUserQuotaInKiBs), Optional.ToNullable(defaultGroupQuotaInKiBs), Optional.ToNullable(maximumNumberOfFiles), volumeGroupName.Value, capacityPoolResourceId.Value, proximityPlacementGroup.Value, t2Network.Value, volumeSpecName.Value, Optional.ToNullable(encrypted), Optional.ToList(placementRules), Optional.ToNullable(enableSubvolumes));
        }
    }
}
