// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchAccountPoolData : IUtf8JsonSerializable, IModelJsonSerializable<BatchAccountPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchAccountPoolData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchAccountPoolData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountPoolData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(DeploymentConfiguration))
            {
                writer.WritePropertyName("deploymentConfiguration"u8);
                if (DeploymentConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchDeploymentConfiguration>)DeploymentConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings"u8);
                if (ScaleSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchAccountPoolScaleSettings>)ScaleSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(InterNodeCommunication))
            {
                writer.WritePropertyName("interNodeCommunication"u8);
                writer.WriteStringValue(InterNodeCommunication.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                if (NetworkConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchNetworkConfiguration>)NetworkConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TaskSlotsPerNode))
            {
                writer.WritePropertyName("taskSlotsPerNode"u8);
                writer.WriteNumberValue(TaskSlotsPerNode.Value);
            }
            if (Optional.IsDefined(TaskSchedulingPolicy))
            {
                writer.WritePropertyName("taskSchedulingPolicy"u8);
                if (TaskSchedulingPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TaskSchedulingPolicy>)TaskSchedulingPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(UserAccounts))
            {
                writer.WritePropertyName("userAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in UserAccounts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchUserAccount>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchAccountPoolMetadataItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StartTask))
            {
                writer.WritePropertyName("startTask"u8);
                if (StartTask is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchAccountPoolStartTask>)StartTask).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchCertificateReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationPackages))
            {
                writer.WritePropertyName("applicationPackages"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationPackages)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchApplicationPackageReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationLicenses))
            {
                writer.WritePropertyName("applicationLicenses"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationLicenses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MountConfiguration))
            {
                writer.WritePropertyName("mountConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in MountConfiguration)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchMountConfiguration>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetNodeCommunicationMode))
            {
                writer.WritePropertyName("targetNodeCommunicationMode"u8);
                writer.WriteStringValue(TargetNodeCommunicationMode.Value.ToSerialString());
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static BatchAccountPoolData DeserializeBatchAccountPoolData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<BatchAccountPoolProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> provisioningStateTransitionTime = default;
            Optional<BatchAccountPoolAllocationState> allocationState = default;
            Optional<DateTimeOffset> allocationStateTransitionTime = default;
            Optional<string> vmSize = default;
            Optional<BatchDeploymentConfiguration> deploymentConfiguration = default;
            Optional<int> currentDedicatedNodes = default;
            Optional<int> currentLowPriorityNodes = default;
            Optional<BatchAccountPoolScaleSettings> scaleSettings = default;
            Optional<BatchAccountPoolAutoScaleRun> autoScaleRun = default;
            Optional<InterNodeCommunicationState> interNodeCommunication = default;
            Optional<BatchNetworkConfiguration> networkConfiguration = default;
            Optional<int> taskSlotsPerNode = default;
            Optional<TaskSchedulingPolicy> taskSchedulingPolicy = default;
            Optional<IList<BatchUserAccount>> userAccounts = default;
            Optional<IList<BatchAccountPoolMetadataItem>> metadata = default;
            Optional<BatchAccountPoolStartTask> startTask = default;
            Optional<IList<BatchCertificateReference>> certificates = default;
            Optional<IList<BatchApplicationPackageReference>> applicationPackages = default;
            Optional<IList<string>> applicationLicenses = default;
            Optional<BatchResizeOperationStatus> resizeOperationStatus = default;
            Optional<IList<BatchMountConfiguration>> mountConfiguration = default;
            Optional<NodeCommunicationMode> targetNodeCommunicationMode = default;
            Optional<NodeCommunicationMode?> currentNodeCommunicationMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchAccountPoolData(id, name, type, systemData.Value, identity, displayName.Value, Optional.ToNullable(lastModified), Optional.ToNullable(creationTime), Optional.ToNullable(provisioningState), Optional.ToNullable(provisioningStateTransitionTime), Optional.ToNullable(allocationState), Optional.ToNullable(allocationStateTransitionTime), vmSize.Value, deploymentConfiguration.Value, Optional.ToNullable(currentDedicatedNodes), Optional.ToNullable(currentLowPriorityNodes), scaleSettings.Value, autoScaleRun.Value, Optional.ToNullable(interNodeCommunication), networkConfiguration.Value, Optional.ToNullable(taskSlotsPerNode), taskSchedulingPolicy.Value, Optional.ToList(userAccounts), Optional.ToList(metadata), startTask.Value, Optional.ToList(certificates), Optional.ToList(applicationPackages), Optional.ToList(applicationLicenses), resizeOperationStatus.Value, Optional.ToList(mountConfiguration), Optional.ToNullable(targetNodeCommunicationMode), Optional.ToNullable(currentNodeCommunicationMode), Optional.ToNullable(etag), rawData);
        }

        BatchAccountPoolData IModelJsonSerializable<BatchAccountPoolData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountPoolData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPoolData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchAccountPoolData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountPoolData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchAccountPoolData IModelSerializable<BatchAccountPoolData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountPoolData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchAccountPoolData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchAccountPoolData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchAccountPoolData"/> to convert. </param>
        public static implicit operator RequestContent(BatchAccountPoolData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchAccountPoolData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchAccountPoolData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchAccountPoolData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
