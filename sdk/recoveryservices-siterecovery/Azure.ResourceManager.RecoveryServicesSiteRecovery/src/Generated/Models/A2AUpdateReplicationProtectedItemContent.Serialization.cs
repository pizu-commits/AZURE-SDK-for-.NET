// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AUpdateReplicationProtectedItemContent : IUtf8JsonSerializable, IJsonModel<A2AUpdateReplicationProtectedItemContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AUpdateReplicationProtectedItemContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<A2AUpdateReplicationProtectedItemContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AUpdateReplicationProtectedItemContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(RecoveryCloudServiceId))
            {
                writer.WritePropertyName("recoveryCloudServiceId"u8);
                writer.WriteStringValue(RecoveryCloudServiceId);
            }
            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (Optional.IsCollectionDefined(ManagedDiskUpdateDetails))
            {
                writer.WritePropertyName("managedDiskUpdateDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedDiskUpdateDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryBootDiagStorageAccountId))
            {
                writer.WritePropertyName("recoveryBootDiagStorageAccountId"u8);
                writer.WriteStringValue(RecoveryBootDiagStorageAccountId);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo, options);
            }
            if (Optional.IsDefined(TfoAzureVmName))
            {
                writer.WritePropertyName("tfoAzureVMName"u8);
                writer.WriteStringValue(TfoAzureVmName);
            }
            if (Optional.IsDefined(RecoveryProximityPlacementGroupId))
            {
                writer.WritePropertyName("recoveryProximityPlacementGroupId"u8);
                writer.WriteStringValue(RecoveryProximityPlacementGroupId);
            }
            if (Optional.IsDefined(RecoveryVirtualMachineScaleSetId))
            {
                writer.WritePropertyName("recoveryVirtualMachineScaleSetId"u8);
                writer.WriteStringValue(RecoveryVirtualMachineScaleSetId);
            }
            if (Optional.IsDefined(RecoveryCapacityReservationGroupId))
            {
                writer.WritePropertyName("recoveryCapacityReservationGroupId"u8);
                writer.WriteStringValue(RecoveryCapacityReservationGroupId);
            }
        }

        A2AUpdateReplicationProtectedItemContent IJsonModel<A2AUpdateReplicationProtectedItemContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AUpdateReplicationProtectedItemContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AUpdateReplicationProtectedItemContent(document.RootElement, options);
        }

        internal static A2AUpdateReplicationProtectedItemContent DeserializeA2AUpdateReplicationProtectedItemContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recoveryCloudServiceId = default;
            ResourceIdentifier recoveryResourceGroupId = default;
            IList<A2AVmManagedDiskUpdateDetails> managedDiskUpdateDetails = default;
            ResourceIdentifier recoveryBootDiagStorageAccountId = default;
            SiteRecoveryDiskEncryptionInfo diskEncryptionInfo = default;
            string tfoAzureVmName = default;
            ResourceIdentifier recoveryProximityPlacementGroupId = default;
            ResourceIdentifier recoveryVirtualMachineScaleSetId = default;
            ResourceIdentifier recoveryCapacityReservationGroupId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryCloudServiceId"u8))
                {
                    recoveryCloudServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedDiskUpdateDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AVmManagedDiskUpdateDetails> array = new List<A2AVmManagedDiskUpdateDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AVmManagedDiskUpdateDetails.DeserializeA2AVmManagedDiskUpdateDetails(item, options));
                    }
                    managedDiskUpdateDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryBootDiagStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryBootDiagStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionInfo = SiteRecoveryDiskEncryptionInfo.DeserializeSiteRecoveryDiskEncryptionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tfoAzureVMName"u8))
                {
                    tfoAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryVirtualMachineScaleSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryVirtualMachineScaleSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryCapacityReservationGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryCapacityReservationGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new A2AUpdateReplicationProtectedItemContent(
                instanceType,
                serializedAdditionalRawData,
                recoveryCloudServiceId,
                recoveryResourceGroupId,
                managedDiskUpdateDetails ?? new ChangeTrackingList<A2AVmManagedDiskUpdateDetails>(),
                recoveryBootDiagStorageAccountId,
                diskEncryptionInfo,
                tfoAzureVmName,
                recoveryProximityPlacementGroupId,
                recoveryVirtualMachineScaleSetId,
                recoveryCapacityReservationGroupId);
        }

        BinaryData IPersistableModel<A2AUpdateReplicationProtectedItemContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AUpdateReplicationProtectedItemContent)} does not support writing '{options.Format}' format.");
            }
        }

        A2AUpdateReplicationProtectedItemContent IPersistableModel<A2AUpdateReplicationProtectedItemContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AUpdateReplicationProtectedItemContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AUpdateReplicationProtectedItemContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AUpdateReplicationProtectedItemContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
