// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricRoutePolicyData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Core.Optional.IsCollectionDefined(Statements))
            {
                writer.WritePropertyName("statements"u8);
                writer.WriteStartArray();
                foreach (var item in Statements)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("networkFabricId"u8);
            writer.WriteStringValue(NetworkFabricId);
            if (Core.Optional.IsDefined(AddressFamilyType))
            {
                writer.WritePropertyName("addressFamilyType"u8);
                writer.WriteStringValue(AddressFamilyType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkFabricRoutePolicyData DeserializeNetworkFabricRoutePolicyData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> annotation = default;
            Core.Optional<IList<RoutePolicyStatementProperties>> statements = default;
            ResourceIdentifier networkFabricId = default;
            Core.Optional<AddressFamilyType> addressFamilyType = default;
            Core.Optional<NetworkFabricConfigurationState> configurationState = default;
            Core.Optional<NetworkFabricProvisioningState> provisioningState = default;
            Core.Optional<NetworkFabricAdministrativeState> administrativeState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statements"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RoutePolicyStatementProperties> array = new List<RoutePolicyStatementProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoutePolicyStatementProperties.DeserializeRoutePolicyStatementProperties(item));
                            }
                            statements = array;
                            continue;
                        }
                        if (property0.NameEquals("networkFabricId"u8))
                        {
                            networkFabricId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("addressFamilyType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressFamilyType = new AddressFamilyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkFabricRoutePolicyData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, annotation.Value, Core.Optional.ToList(statements), networkFabricId, Core.Optional.ToNullable(addressFamilyType), Core.Optional.ToNullable(configurationState), Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(administrativeState));
        }
    }
}
