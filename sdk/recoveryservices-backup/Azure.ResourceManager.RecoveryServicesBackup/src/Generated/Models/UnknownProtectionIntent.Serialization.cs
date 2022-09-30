// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal partial class UnknownProtectionIntent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("protectionIntentItemType");
            writer.WriteStringValue(ProtectionIntentItemType.ToString());
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType");
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId");
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(ItemId))
            {
                writer.WritePropertyName("itemId");
                writer.WriteStringValue(ItemId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId");
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState");
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static UnknownProtectionIntent DeserializeUnknownProtectionIntent(JsonElement element)
        {
            ProtectionIntentItemType protectionIntentItemType = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> sourceResourceId = default;
            Optional<string> itemId = default;
            Optional<string> policyId = default;
            Optional<ProtectionStatus> protectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionIntentItemType"))
                {
                    protectionIntentItemType = new ProtectionIntentItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupManagementType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"))
                {
                    sourceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemId"))
                {
                    itemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyId"))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectionState = new ProtectionStatus(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownProtectionIntent(protectionIntentItemType, Optional.ToNullable(backupManagementType), sourceResourceId.Value, itemId.Value, policyId.Value, Optional.ToNullable(protectionState));
        }
    }
}
