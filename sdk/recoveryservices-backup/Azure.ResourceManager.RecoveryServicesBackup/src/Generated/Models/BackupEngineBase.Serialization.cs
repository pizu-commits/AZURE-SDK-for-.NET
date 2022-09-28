// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupEngineBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType");
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus");
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(BackupEngineState))
            {
                writer.WritePropertyName("backupEngineState");
                writer.WriteStringValue(BackupEngineState);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus");
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("backupEngineType");
            writer.WriteStringValue(BackupEngineType.ToString());
            if (Optional.IsDefined(CanReRegister))
            {
                writer.WritePropertyName("canReRegister");
                writer.WriteBooleanValue(CanReRegister.Value);
            }
            if (Optional.IsDefined(BackupEngineId))
            {
                writer.WritePropertyName("backupEngineId");
                writer.WriteStringValue(BackupEngineId);
            }
            if (Optional.IsDefined(DpmVersion))
            {
                writer.WritePropertyName("dpmVersion");
                writer.WriteStringValue(DpmVersion);
            }
            if (Optional.IsDefined(AzureBackupAgentVersion))
            {
                writer.WritePropertyName("azureBackupAgentVersion");
                writer.WriteStringValue(AzureBackupAgentVersion);
            }
            if (Optional.IsDefined(IsAzureBackupAgentUpgradeAvailable))
            {
                writer.WritePropertyName("isAzureBackupAgentUpgradeAvailable");
                writer.WriteBooleanValue(IsAzureBackupAgentUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(IsDpmUpgradeAvailable))
            {
                writer.WritePropertyName("isDpmUpgradeAvailable");
                writer.WriteBooleanValue(IsDpmUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo");
                writer.WriteObjectValue(ExtendedInfo);
            }
            writer.WriteEndObject();
        }

        internal static BackupEngineBase DeserializeBackupEngineBase(JsonElement element)
        {
            if (element.TryGetProperty("backupEngineType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupServerEngine": return AzureBackupServerEngine.DeserializeAzureBackupServerEngine(element);
                    case "DpmBackupEngine": return DpmBackupEngine.DeserializeDpmBackupEngine(element);
                }
            }
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> backupEngineState = default;
            Optional<string> healthStatus = default;
            BackupEngineType backupEngineType = default;
            Optional<bool> canReRegister = default;
            Optional<string> backupEngineId = default;
            Optional<string> dpmVersion = default;
            Optional<string> azureBackupAgentVersion = default;
            Optional<bool> isAzureBackupAgentUpgradeAvailable = default;
            Optional<bool> isDpmUpgradeAvailable = default;
            Optional<BackupEngineExtendedInfo> extendedInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
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
                if (property.NameEquals("registrationStatus"))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupEngineState"))
                {
                    backupEngineState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupEngineType"))
                {
                    backupEngineType = new BackupEngineType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("canReRegister"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupEngineId"))
                {
                    backupEngineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dpmVersion"))
                {
                    dpmVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureBackupAgentVersion"))
                {
                    azureBackupAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAzureBackupAgentUpgradeAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAzureBackupAgentUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDpmUpgradeAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDpmUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("extendedInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedInfo = BackupEngineExtendedInfo.DeserializeBackupEngineExtendedInfo(property.Value);
                    continue;
                }
            }
            return new UnknownBackupEngineBase(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, backupEngineState.Value, healthStatus.Value, backupEngineType, Optional.ToNullable(canReRegister), backupEngineId.Value, dpmVersion.Value, azureBackupAgentVersion.Value, Optional.ToNullable(isAzureBackupAgentUpgradeAvailable), Optional.ToNullable(isDpmUpgradeAvailable), extendedInfo.Value);
        }
    }
}
