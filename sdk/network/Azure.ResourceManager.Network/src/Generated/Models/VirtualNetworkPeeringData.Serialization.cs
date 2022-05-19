// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkPeeringData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ResourceType);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowVirtualNetworkAccess))
            {
                writer.WritePropertyName("allowVirtualNetworkAccess");
                writer.WriteBooleanValue(AllowVirtualNetworkAccess.Value);
            }
            if (Optional.IsDefined(AllowForwardedTraffic))
            {
                writer.WritePropertyName("allowForwardedTraffic");
                writer.WriteBooleanValue(AllowForwardedTraffic.Value);
            }
            if (Optional.IsDefined(AllowGatewayTransit))
            {
                writer.WritePropertyName("allowGatewayTransit");
                writer.WriteBooleanValue(AllowGatewayTransit.Value);
            }
            if (Optional.IsDefined(UseRemoteGateways))
            {
                writer.WritePropertyName("useRemoteGateways");
                writer.WriteBooleanValue(UseRemoteGateways.Value);
            }
            if (Optional.IsDefined(RemoteVirtualNetwork))
            {
                writer.WritePropertyName("remoteVirtualNetwork");
                JsonSerializer.Serialize(writer, RemoteVirtualNetwork);
            }
            if (Optional.IsDefined(RemoteAddressSpace))
            {
                writer.WritePropertyName("remoteAddressSpace");
                writer.WriteObjectValue(RemoteAddressSpace);
            }
            if (Optional.IsDefined(RemoteVirtualNetworkAddressSpace))
            {
                writer.WritePropertyName("remoteVirtualNetworkAddressSpace");
                writer.WriteObjectValue(RemoteVirtualNetworkAddressSpace);
            }
            if (Optional.IsDefined(RemoteBgpCommunities))
            {
                writer.WritePropertyName("remoteBgpCommunities");
                writer.WriteObjectValue(RemoteBgpCommunities);
            }
            if (Optional.IsDefined(PeeringState))
            {
                writer.WritePropertyName("peeringState");
                writer.WriteStringValue(PeeringState.Value.ToString());
            }
            if (Optional.IsDefined(PeeringSyncLevel))
            {
                writer.WritePropertyName("peeringSyncLevel");
                writer.WriteStringValue(PeeringSyncLevel.Value.ToString());
            }
            if (Optional.IsDefined(DoNotVerifyRemoteGateways))
            {
                writer.WritePropertyName("doNotVerifyRemoteGateways");
                writer.WriteBooleanValue(DoNotVerifyRemoteGateways.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkPeeringData DeserializeVirtualNetworkPeeringData(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<ResourceIdentifier> id = default;
            Optional<bool> allowVirtualNetworkAccess = default;
            Optional<bool> allowForwardedTraffic = default;
            Optional<bool> allowGatewayTransit = default;
            Optional<bool> useRemoteGateways = default;
            Optional<WritableSubResource> remoteVirtualNetwork = default;
            Optional<AddressSpace> remoteAddressSpace = default;
            Optional<AddressSpace> remoteVirtualNetworkAddressSpace = default;
            Optional<VirtualNetworkBgpCommunities> remoteBgpCommunities = default;
            Optional<VirtualNetworkPeeringState> peeringState = default;
            Optional<VirtualNetworkPeeringLevel> peeringSyncLevel = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<bool> doNotVerifyRemoteGateways = default;
            Optional<Guid> resourceGuid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("allowVirtualNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowVirtualNetworkAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowForwardedTraffic"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowForwardedTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowGatewayTransit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowGatewayTransit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useRemoteGateways"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useRemoteGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("remoteVirtualNetwork"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remoteVirtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("remoteAddressSpace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remoteAddressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("remoteVirtualNetworkAddressSpace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remoteVirtualNetworkAddressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("remoteBgpCommunities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remoteBgpCommunities = VirtualNetworkBgpCommunities.DeserializeVirtualNetworkBgpCommunities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peeringState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            peeringState = new VirtualNetworkPeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peeringSyncLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            peeringSyncLevel = new VirtualNetworkPeeringLevel(property0.Value.GetString());
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
                        if (property0.NameEquals("doNotVerifyRemoteGateways"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            doNotVerifyRemoteGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkPeeringData(id.Value, name.Value, etag.Value, type.Value, Optional.ToNullable(allowVirtualNetworkAccess), Optional.ToNullable(allowForwardedTraffic), Optional.ToNullable(allowGatewayTransit), Optional.ToNullable(useRemoteGateways), remoteVirtualNetwork, remoteAddressSpace.Value, remoteVirtualNetworkAddressSpace.Value, remoteBgpCommunities.Value, Optional.ToNullable(peeringState), Optional.ToNullable(peeringSyncLevel), Optional.ToNullable(provisioningState), Optional.ToNullable(doNotVerifyRemoteGateways), Optional.ToNullable(resourceGuid));
        }
    }
}
