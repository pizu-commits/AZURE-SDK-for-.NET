// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchAccountPoolData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Core.Optional.IsDefined(DeploymentConfiguration))
            {
                writer.WritePropertyName("deploymentConfiguration"u8);
                writer.WriteObjectValue(DeploymentConfiguration);
            }
            if (Core.Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings"u8);
                writer.WriteObjectValue(ScaleSettings);
            }
            if (Core.Optional.IsDefined(InterNodeCommunication))
            {
                writer.WritePropertyName("interNodeCommunication"u8);
                writer.WriteStringValue(InterNodeCommunication.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration);
            }
            if (Core.Optional.IsDefined(TaskSlotsPerNode))
            {
                writer.WritePropertyName("taskSlotsPerNode"u8);
                writer.WriteNumberValue(TaskSlotsPerNode.Value);
            }
            if (Core.Optional.IsDefined(TaskSchedulingPolicy))
            {
                writer.WritePropertyName("taskSchedulingPolicy"u8);
                writer.WriteObjectValue(TaskSchedulingPolicy);
            }
            if (Core.Optional.IsCollectionDefined(UserAccounts))
            {
                writer.WritePropertyName("userAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in UserAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(StartTask))
            {
                writer.WritePropertyName("startTask"u8);
                writer.WriteObjectValue(StartTask);
            }
            if (Core.Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(ApplicationPackages))
            {
                writer.WritePropertyName("applicationPackages"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationPackages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(ApplicationLicenses))
            {
                writer.WritePropertyName("applicationLicenses"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationLicenses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(MountConfiguration))
            {
                writer.WritePropertyName("mountConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in MountConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(TargetNodeCommunicationMode))
            {
                writer.WritePropertyName("targetNodeCommunicationMode"u8);
                writer.WriteStringValue(TargetNodeCommunicationMode.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BatchAccountPoolData DeserializeBatchAccountPoolData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ManagedServiceIdentity> identity = default;
            Core.Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> displayName = default;
            Core.Optional<DateTimeOffset> lastModified = default;
            Core.Optional<DateTimeOffset> creationTime = default;
            Core.Optional<BatchAccountPoolProvisioningState> provisioningState = default;
            Core.Optional<DateTimeOffset> provisioningStateTransitionTime = default;
            Core.Optional<BatchAccountPoolAllocationState> allocationState = default;
            Core.Optional<DateTimeOffset> allocationStateTransitionTime = default;
            Core.Optional<string> vmSize = default;
            Core.Optional<BatchDeploymentConfiguration> deploymentConfiguration = default;
            Core.Optional<int> currentDedicatedNodes = default;
            Core.Optional<int> currentLowPriorityNodes = default;
            Core.Optional<BatchAccountPoolScaleSettings> scaleSettings = default;
            Core.Optional<BatchAccountPoolAutoScaleRun> autoScaleRun = default;
            Core.Optional<InterNodeCommunicationState> interNodeCommunication = default;
            Core.Optional<BatchNetworkConfiguration> networkConfiguration = default;
            Core.Optional<int> taskSlotsPerNode = default;
            Core.Optional<TaskSchedulingPolicy> taskSchedulingPolicy = default;
            Core.Optional<IList<BatchUserAccount>> userAccounts = default;
            Core.Optional<IList<BatchAccountPoolMetadataItem>> metadata = default;
            Core.Optional<BatchAccountPoolStartTask> startTask = default;
            Core.Optional<IList<BatchCertificateReference>> certificates = default;
            Core.Optional<IList<BatchApplicationPackageReference>> applicationPackages = default;
            Core.Optional<IList<string>> applicationLicenses = default;
            Core.Optional<BatchResizeOperationStatus> resizeOperationStatus = default;
            Core.Optional<IList<BatchMountConfiguration>> mountConfiguration = default;
            Core.Optional<NodeCommunicationMode> targetNodeCommunicationMode = default;
            Core.Optional<NodeCommunicationMode?> currentNodeCommunicationMode = default;
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
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BatchAccountPoolProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("allocationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationState = property0.Value.GetString().ToBatchAccountPoolAllocationState();
                            continue;
                        }
                        if (property0.NameEquals("allocationStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("vmSize"u8))
                        {
                            vmSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deploymentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentConfiguration = BatchDeploymentConfiguration.DeserializeBatchDeploymentConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("currentDedicatedNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentDedicatedNodes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentLowPriorityNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentLowPriorityNodes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("scaleSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleSettings = BatchAccountPoolScaleSettings.DeserializeBatchAccountPoolScaleSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoScaleRun"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoScaleRun = BatchAccountPoolAutoScaleRun.DeserializeBatchAccountPoolAutoScaleRun(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("interNodeCommunication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interNodeCommunication = property0.Value.GetString().ToInterNodeCommunicationState();
                            continue;
                        }
                        if (property0.NameEquals("networkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkConfiguration = BatchNetworkConfiguration.DeserializeBatchNetworkConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("taskSlotsPerNode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskSlotsPerNode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("taskSchedulingPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskSchedulingPolicy = TaskSchedulingPolicy.DeserializeTaskSchedulingPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchUserAccount> array = new List<BatchUserAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchUserAccount.DeserializeBatchUserAccount(item));
                            }
                            userAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchAccountPoolMetadataItem> array = new List<BatchAccountPoolMetadataItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchAccountPoolMetadataItem.DeserializeBatchAccountPoolMetadataItem(item));
                            }
                            metadata = array;
                            continue;
                        }
                        if (property0.NameEquals("startTask"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTask = BatchAccountPoolStartTask.DeserializeBatchAccountPoolStartTask(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("certificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchCertificateReference> array = new List<BatchCertificateReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchCertificateReference.DeserializeBatchCertificateReference(item));
                            }
                            certificates = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationPackages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchApplicationPackageReference> array = new List<BatchApplicationPackageReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchApplicationPackageReference.DeserializeBatchApplicationPackageReference(item));
                            }
                            applicationPackages = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationLicenses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            applicationLicenses = array;
                            continue;
                        }
                        if (property0.NameEquals("resizeOperationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resizeOperationStatus = BatchResizeOperationStatus.DeserializeBatchResizeOperationStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("mountConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchMountConfiguration> array = new List<BatchMountConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchMountConfiguration.DeserializeBatchMountConfiguration(item));
                            }
                            mountConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("targetNodeCommunicationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetNodeCommunicationMode = property0.Value.GetString().ToNodeCommunicationMode();
                            continue;
                        }
                        if (property0.NameEquals("currentNodeCommunicationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                currentNodeCommunicationMode = null;
                                continue;
                            }
                            currentNodeCommunicationMode = property0.Value.GetString().ToNodeCommunicationMode();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BatchAccountPoolData(id, name, type, systemData.Value, identity, displayName.Value, Core.Optional.ToNullable(lastModified), Core.Optional.ToNullable(creationTime), Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(provisioningStateTransitionTime), Core.Optional.ToNullable(allocationState), Core.Optional.ToNullable(allocationStateTransitionTime), vmSize.Value, deploymentConfiguration.Value, Core.Optional.ToNullable(currentDedicatedNodes), Core.Optional.ToNullable(currentLowPriorityNodes), scaleSettings.Value, autoScaleRun.Value, Core.Optional.ToNullable(interNodeCommunication), networkConfiguration.Value, Core.Optional.ToNullable(taskSlotsPerNode), taskSchedulingPolicy.Value, Core.Optional.ToList(userAccounts), Core.Optional.ToList(metadata), startTask.Value, Core.Optional.ToList(certificates), Core.Optional.ToList(applicationPackages), Core.Optional.ToList(applicationLicenses), resizeOperationStatus.Value, Core.Optional.ToList(mountConfiguration), Core.Optional.ToNullable(targetNodeCommunicationMode), Core.Optional.ToNullable(currentNodeCommunicationMode), Core.Optional.ToNullable(etag));
        }
    }
}
