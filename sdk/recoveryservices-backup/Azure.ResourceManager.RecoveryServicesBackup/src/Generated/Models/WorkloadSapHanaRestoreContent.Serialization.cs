// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadSapHanaRestoreContent : IUtf8JsonSerializable, IJsonModel<WorkloadSapHanaRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadSapHanaRestoreContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadSapHanaRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSapHanaRestoreContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryType))
            {
                writer.WritePropertyName("recoveryType"u8);
                writer.WriteStringValue(RecoveryType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TargetInfo))
            {
                writer.WritePropertyName("targetInfo"u8);
                writer.WriteObjectValue(TargetInfo);
            }
            if (Optional.IsDefined(RecoveryMode))
            {
                writer.WritePropertyName("recoveryMode"u8);
                writer.WriteStringValue(RecoveryMode.Value.ToString());
            }
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
            }
            if (Optional.IsDefined(UserAssignedManagedIdentityDetails))
            {
                writer.WritePropertyName("userAssignedManagedIdentityDetails"u8);
                writer.WriteObjectValue(UserAssignedManagedIdentityDetails);
            }
            if (Optional.IsDefined(SnapshotRestoreParameters))
            {
                writer.WritePropertyName("snapshotRestoreParameters"u8);
                writer.WriteObjectValue(SnapshotRestoreParameters);
            }
            if (Optional.IsDefined(TargetVirtualMachineId))
            {
                writer.WritePropertyName("targetVirtualMachineId"u8);
                writer.WriteStringValue(TargetVirtualMachineId);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        WorkloadSapHanaRestoreContent IJsonModel<WorkloadSapHanaRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSapHanaRestoreContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSapHanaRestoreContent(document.RootElement, options);
        }

        internal static WorkloadSapHanaRestoreContent DeserializeWorkloadSapHanaRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadSAPHanaPointInTimeRestoreRequest": return WorkloadSapHanaPointInTimeRestoreContent.DeserializeWorkloadSapHanaPointInTimeRestoreContent(element, options);
                    case "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest": return WorkloadSapHanaPointInTimeRestoreWithRehydrateContent.DeserializeWorkloadSapHanaPointInTimeRestoreWithRehydrateContent(element, options);
                    case "AzureWorkloadSAPHanaRestoreWithRehydrateRequest": return WorkloadSapHanaRestoreWithRehydrateContent.DeserializeWorkloadSapHanaRestoreWithRehydrateContent(element, options);
                }
            }
            FileShareRecoveryType? recoveryType = default;
            ResourceIdentifier sourceResourceId = default;
            IDictionary<string, string> propertyBag = default;
            TargetRestoreInfo targetInfo = default;
            RecoveryMode? recoveryMode = default;
            string targetResourceGroupName = default;
            UserAssignedManagedIdentityDetails userAssignedManagedIdentityDetails = default;
            SnapshotRestoreContent snapshotRestoreParameters = default;
            ResourceIdentifier targetVirtualMachineId = default;
            string objectType = "AzureWorkloadSAPHanaRestoreRequest";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryType = new FileShareRecoveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
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
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("targetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetInfo = TargetRestoreInfo.DeserializeTargetRestoreInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryMode = new RecoveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssignedManagedIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedManagedIdentityDetails = UserAssignedManagedIdentityDetails.DeserializeUserAssignedManagedIdentityDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("snapshotRestoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotRestoreParameters = SnapshotRestoreContent.DeserializeSnapshotRestoreContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkloadSapHanaRestoreContent(
                objectType,
                serializedAdditionalRawData,
                recoveryType,
                sourceResourceId,
                propertyBag ?? new ChangeTrackingDictionary<string, string>(),
                targetInfo,
                recoveryMode,
                targetResourceGroupName,
                userAssignedManagedIdentityDetails,
                snapshotRestoreParameters,
                targetVirtualMachineId);
        }

        BinaryData IPersistableModel<WorkloadSapHanaRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadSapHanaRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        WorkloadSapHanaRestoreContent IPersistableModel<WorkloadSapHanaRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadSapHanaRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadSapHanaRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadSapHanaRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
