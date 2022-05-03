// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusNamespacePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("identity");
            writer.WriteStartObject();
            if (Optional.IsDefined(TypeIdentityType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypeIdentityType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities");
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(ZoneRedundant.Value);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections");
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth");
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            writer.WritePropertyName("encryption");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteStartArray();
                foreach (var item in KeyVaultProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KeySource))
            {
                writer.WritePropertyName("keySource");
                writer.WriteStringValue(KeySource);
            }
            if (Optional.IsDefined(RequireInfrastructureEncryption))
            {
                writer.WritePropertyName("requireInfrastructureEncryption");
                writer.WriteBooleanValue(RequireInfrastructureEncryption.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceBusNamespacePatch DeserializeServiceBusNamespacePatch(JsonElement element)
        {
            Optional<ServiceBusSku> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> principalId = default;
            Optional<string> tenantId = default;
            Optional<ManagedServiceIdentityType> type0 = default;
            Optional<IDictionary<string, UserAssignedIdentity>> userAssignedIdentities = default;
            Optional<string> provisioningState = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<string> serviceBusEndpoint = default;
            Optional<string> metricId = default;
            Optional<bool> zoneRedundant = default;
            Optional<IList<ServiceBusPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<bool> disableLocalAuth = default;
            Optional<IList<KeyVaultProperties>> keyVaultProperties = default;
            Optional<string> keySource = default;
            Optional<bool> requireInfrastructureEncryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ServiceBusSku.DeserializeServiceBusSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
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
                    location = property.Value.GetString();
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
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("principalId"))
                        {
                            principalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"))
                        {
                            tenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            type0 = property0.Value.GetString().ToManagedServiceIdentityType();
                            continue;
                        }
                        if (property0.NameEquals("userAssignedIdentities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, UserAssignedIdentity> dictionary = new Dictionary<string, UserAssignedIdentity>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, JsonSerializer.Deserialize<UserAssignedIdentity>(property1.Value.ToString()));
                            }
                            userAssignedIdentities = dictionary;
                            continue;
                        }
                    }
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceBusEndpoint"))
                        {
                            serviceBusEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricId"))
                        {
                            metricId = property0.Value.GetString();
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
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServiceBusPrivateEndpointConnectionData> array = new List<ServiceBusPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceBusPrivateEndpointConnectionData.DeserializeServiceBusPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("keyVaultProperties"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    List<KeyVaultProperties> array = new List<KeyVaultProperties>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(Models.KeyVaultProperties.DeserializeKeyVaultProperties(item));
                                    }
                                    keyVaultProperties = array;
                                    continue;
                                }
                                if (property1.NameEquals("keySource"))
                                {
                                    keySource = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("requireInfrastructureEncryption"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    requireInfrastructureEncryption = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceBusNamespacePatch(id, name, type, systemData, tags, location, sku.Value, principalId.Value, tenantId.Value, Optional.ToNullable(type0), Optional.ToDictionary(userAssignedIdentities), provisioningState.Value, status.Value, Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), serviceBusEndpoint.Value, metricId.Value, Optional.ToNullable(zoneRedundant), Optional.ToList(privateEndpointConnections), Optional.ToNullable(disableLocalAuth), Optional.ToList(keyVaultProperties), keySource.Value, Optional.ToNullable(requireInfrastructureEncryption));
        }
    }
}
