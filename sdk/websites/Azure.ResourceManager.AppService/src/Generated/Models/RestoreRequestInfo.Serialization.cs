// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class RestoreRequestInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountUri))
            {
                writer.WritePropertyName("storageAccountUrl");
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BlobName))
            {
                writer.WritePropertyName("blobName");
                writer.WriteStringValue(BlobName);
            }
            if (Optional.IsDefined(CanOverwrite))
            {
                writer.WritePropertyName("overwrite");
                writer.WriteBooleanValue(CanOverwrite.Value);
            }
            if (Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName");
                writer.WriteStringValue(SiteName);
            }
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases");
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IgnoreConflictingHostNames))
            {
                writer.WritePropertyName("ignoreConflictingHostNames");
                writer.WriteBooleanValue(IgnoreConflictingHostNames.Value);
            }
            if (Optional.IsDefined(IgnoreDatabases))
            {
                writer.WritePropertyName("ignoreDatabases");
                writer.WriteBooleanValue(IgnoreDatabases.Value);
            }
            if (Optional.IsDefined(AppServicePlan))
            {
                writer.WritePropertyName("appServicePlan");
                writer.WriteStringValue(AppServicePlan);
            }
            if (Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType");
                writer.WriteStringValue(OperationType.Value.ToSerialString());
            }
            if (Optional.IsDefined(AdjustConnectionStrings))
            {
                writer.WritePropertyName("adjustConnectionStrings");
                writer.WriteBooleanValue(AdjustConnectionStrings.Value);
            }
            if (Optional.IsDefined(HostingEnvironment))
            {
                writer.WritePropertyName("hostingEnvironment");
                writer.WriteStringValue(HostingEnvironment);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RestoreRequestInfo DeserializeRestoreRequestInfo(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> storageAccountUrl = default;
            Optional<string> blobName = default;
            Optional<bool> overwrite = default;
            Optional<string> siteName = default;
            Optional<IList<DatabaseBackupSetting>> databases = default;
            Optional<bool> ignoreConflictingHostNames = default;
            Optional<bool> ignoreDatabases = default;
            Optional<string> appServicePlan = default;
            Optional<BackupRestoreOperationType> operationType = default;
            Optional<bool> adjustConnectionStrings = default;
            Optional<string> hostingEnvironment = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("storageAccountUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                storageAccountUrl = null;
                                continue;
                            }
                            storageAccountUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobName"))
                        {
                            blobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overwrite"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            overwrite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("siteName"))
                        {
                            siteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databases"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DatabaseBackupSetting> array = new List<DatabaseBackupSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseBackupSetting.DeserializeDatabaseBackupSetting(item));
                            }
                            databases = array;
                            continue;
                        }
                        if (property0.NameEquals("ignoreConflictingHostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ignoreConflictingHostNames = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ignoreDatabases"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ignoreDatabases = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appServicePlan"))
                        {
                            appServicePlan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            operationType = property0.Value.GetString().ToBackupRestoreOperationType();
                            continue;
                        }
                        if (property0.NameEquals("adjustConnectionStrings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            adjustConnectionStrings = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironment"))
                        {
                            hostingEnvironment = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RestoreRequestInfo(id, name, type, systemData.Value, storageAccountUrl.Value, blobName.Value, Optional.ToNullable(overwrite), siteName.Value, Optional.ToList(databases), Optional.ToNullable(ignoreConflictingHostNames), Optional.ToNullable(ignoreDatabases), appServicePlan.Value, Optional.ToNullable(operationType), Optional.ToNullable(adjustConnectionStrings), hostingEnvironment.Value, kind.Value);
        }
    }
}
