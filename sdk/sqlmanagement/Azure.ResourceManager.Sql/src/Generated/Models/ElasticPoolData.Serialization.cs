// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ElasticPoolData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
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
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes");
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(PerDatabaseSettings))
            {
                writer.WritePropertyName("perDatabaseSettings");
                writer.WriteObjectValue(PerDatabaseSettings);
            }
            if (Optional.IsDefined(ZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(ZoneRedundant.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId");
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(HighAvailabilityReplicaCount))
            {
                writer.WritePropertyName("highAvailabilityReplicaCount");
                writer.WriteNumberValue(HighAvailabilityReplicaCount.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ElasticPoolData DeserializeElasticPoolData(JsonElement element)
        {
            Optional<SqlSku> sku = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ElasticPoolState> state = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<long> maxSizeBytes = default;
            Optional<ElasticPoolPerDatabaseSettings> perDatabaseSettings = default;
            Optional<bool> zoneRedundant = default;
            Optional<ElasticPoolLicenseType> licenseType = default;
            Optional<string> maintenanceConfigurationId = default;
            Optional<int> highAvailabilityReplicaCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new ElasticPoolState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maxSizeBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("perDatabaseSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            perDatabaseSettings = ElasticPoolPerDatabaseSettings.DeserializeElasticPoolPerDatabaseSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            licenseType = new ElasticPoolLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"))
                        {
                            maintenanceConfigurationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("highAvailabilityReplicaCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            highAvailabilityReplicaCount = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ElasticPoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, kind.Value, Optional.ToNullable(state), Optional.ToNullable(creationDate), Optional.ToNullable(maxSizeBytes), perDatabaseSettings.Value, Optional.ToNullable(zoneRedundant), Optional.ToNullable(licenseType), maintenanceConfigurationId.Value, Optional.ToNullable(highAvailabilityReplicaCount));
        }
    }
}
