// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupRestoreWithRehydrationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rehydrationPriority"u8);
            writer.WriteStringValue(RehydrationPriority.ToString());
            writer.WritePropertyName("rehydrationRetentionDuration"u8);
            writer.WriteStringValue(RehydrationRetentionDuration, "P");
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("restoreTargetInfo"u8);
            writer.WriteObjectValue(RestoreTargetInfo);
            writer.WritePropertyName("sourceDataStoreType"u8);
            writer.WriteStringValue(SourceDataStoreType.ToString());
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(IdentityDetails))
            {
                writer.WritePropertyName("identityDetails"u8);
                writer.WriteObjectValue(IdentityDetails);
            }
            writer.WriteEndObject();
        }
    }
}
