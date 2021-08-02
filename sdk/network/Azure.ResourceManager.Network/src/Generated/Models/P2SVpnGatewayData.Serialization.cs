// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class P2SVpnGatewayData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
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
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                writer.WriteObjectValue(VirtualHub);
            }
            if (Optional.IsCollectionDefined(P2SConnectionConfigurations))
            {
                writer.WritePropertyName("p2SConnectionConfigurations");
                writer.WriteStartArray();
                foreach (var item in P2SConnectionConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VpnGatewayScaleUnit))
            {
                writer.WritePropertyName("vpnGatewayScaleUnit");
                writer.WriteNumberValue(VpnGatewayScaleUnit.Value);
            }
            if (Optional.IsDefined(VpnServerConfiguration))
            {
                writer.WritePropertyName("vpnServerConfiguration");
                writer.WriteObjectValue(VpnServerConfiguration);
            }
            if (Optional.IsCollectionDefined(CustomDnsServers))
            {
                writer.WritePropertyName("customDnsServers");
                writer.WriteStartArray();
                foreach (var item in CustomDnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsRoutingPreferenceInternet))
            {
                writer.WritePropertyName("isRoutingPreferenceInternet");
                writer.WriteBooleanValue(IsRoutingPreferenceInternet.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static P2SVpnGatewayData DeserializeP2SVpnGatewayData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            Optional<SubResource> virtualHub = default;
            Optional<IList<P2SConnectionConfiguration>> p2SConnectionConfigurations = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<int> vpnGatewayScaleUnit = default;
            Optional<SubResource> vpnServerConfiguration = default;
            Optional<VpnClientConnectionHealth> vpnClientConnectionHealth = default;
            Optional<IList<string>> customDnsServers = default;
            Optional<bool> isRoutingPreferenceInternet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("virtualHub"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualHub = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("p2SConnectionConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<P2SConnectionConfiguration> array = new List<P2SConnectionConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(P2SConnectionConfiguration.DeserializeP2SConnectionConfiguration(item));
                            }
                            p2SConnectionConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayScaleUnit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnGatewayScaleUnit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vpnServerConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnServerConfiguration = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vpnClientConnectionHealth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnClientConnectionHealth = VpnClientConnectionHealth.DeserializeVpnClientConnectionHealth(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customDnsServers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            customDnsServers = array;
                            continue;
                        }
                        if (property0.NameEquals("isRoutingPreferenceInternet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isRoutingPreferenceInternet = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new P2SVpnGatewayData(id, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, virtualHub.Value, Optional.ToList(p2SConnectionConfigurations), Optional.ToNullable(provisioningState), Optional.ToNullable(vpnGatewayScaleUnit), vpnServerConfiguration.Value, vpnClientConnectionHealth.Value, Optional.ToList(customDnsServers), Optional.ToNullable(isRoutingPreferenceInternet));
        }
    }
}
