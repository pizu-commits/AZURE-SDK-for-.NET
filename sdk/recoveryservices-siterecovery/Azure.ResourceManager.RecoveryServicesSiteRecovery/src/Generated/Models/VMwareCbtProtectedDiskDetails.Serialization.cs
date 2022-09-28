// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtProtectedDiskDetails
    {
        internal static VMwareCbtProtectedDiskDetails DeserializeVMwareCbtProtectedDiskDetails(JsonElement element)
        {
            Optional<string> diskId = default;
            Optional<string> diskName = default;
            Optional<DiskAccountType> diskType = default;
            Optional<string> diskPath = default;
            Optional<string> isOSDisk = default;
            Optional<long> capacityInBytes = default;
            Optional<string> logStorageAccountId = default;
            Optional<string> logStorageAccountSasSecretName = default;
            Optional<string> diskEncryptionSetId = default;
            Optional<string> seedManagedDiskId = default;
            Optional<Uri> seedBlobUri = default;
            Optional<string> targetManagedDiskId = default;
            Optional<Uri> targetBlobUri = default;
            Optional<string> targetDiskName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskType = new DiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskPath"))
                {
                    diskPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"))
                {
                    logStorageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStorageAccountSasSecretName"))
                {
                    logStorageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"))
                {
                    diskEncryptionSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedBlobUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        seedBlobUri = null;
                        continue;
                    }
                    seedBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetManagedDiskId"))
                {
                    targetManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBlobUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetBlobUri = null;
                        continue;
                    }
                    targetBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDiskName"))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
            }
            return new VMwareCbtProtectedDiskDetails(diskId.Value, diskName.Value, Optional.ToNullable(diskType), diskPath.Value, isOSDisk.Value, Optional.ToNullable(capacityInBytes), logStorageAccountId.Value, logStorageAccountSasSecretName.Value, diskEncryptionSetId.Value, seedManagedDiskId.Value, seedBlobUri.Value, targetManagedDiskId.Value, targetBlobUri.Value, targetDiskName.Value);
        }
    }
}
