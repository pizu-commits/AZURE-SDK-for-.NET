// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkGatewayNatRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VpnNatRuleType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(VpnNatRuleType.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InternalMappings))
            {
                writer.WritePropertyName("internalMappings");
                writer.WriteStartArray();
                foreach (var item in InternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalMappings))
            {
                writer.WritePropertyName("externalMappings");
                writer.WriteStartArray();
                foreach (var item in ExternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPConfigurationId))
            {
                writer.WritePropertyName("ipConfigurationId");
                writer.WriteStringValue(IPConfigurationId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkGatewayNatRuleData DeserializeVirtualNetworkGatewayNatRuleData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<VpnNatRuleType> type0 = default;
            Optional<VpnNatRuleMode> mode = default;
            Optional<IList<VpnNatRuleMapping>> internalMappings = default;
            Optional<IList<VpnNatRuleMapping>> externalMappings = default;
            Optional<string> ipConfigurationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            type0 = new VpnNatRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mode = new VpnNatRuleMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalMappings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            internalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("externalMappings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            externalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationId"))
                        {
                            ipConfigurationId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkGatewayNatRuleData(id.Value, name.Value, Optional.ToNullable(type), etag.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(type0), Optional.ToNullable(mode), Optional.ToList(internalMappings), Optional.ToList(externalMappings), ipConfigurationId.Value);
        }
    }
}
