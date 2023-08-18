// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class NetworkInterfaces : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (Core.Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteStringValue(VirtualNetworkId);
            }
            if (Core.Optional.IsDefined(IPv4AddressType))
            {
                writer.WritePropertyName("ipv4AddressType"u8);
                writer.WriteStringValue(IPv4AddressType.Value.ToString());
            }
            if (Core.Optional.IsDefined(IPv6AddressType))
            {
                writer.WritePropertyName("ipv6AddressType"u8);
                writer.WriteStringValue(IPv6AddressType.Value.ToString());
            }
            if (Core.Optional.IsDefined(MacAddressType))
            {
                writer.WritePropertyName("macAddressType"u8);
                writer.WriteStringValue(MacAddressType.Value.ToString());
            }
            if (Core.Optional.IsDefined(NicId))
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
            }
            writer.WriteEndObject();
        }

        internal static NetworkInterfaces DeserializeNetworkInterfaces(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> displayName = default;
            Core.Optional<IReadOnlyList<string>> ipv4Addresses = default;
            Core.Optional<IReadOnlyList<string>> ipv6Addresses = default;
            Core.Optional<string> macAddress = default;
            Core.Optional<string> virtualNetworkId = default;
            Core.Optional<string> networkName = default;
            Core.Optional<AllocationMethod> ipv4AddressType = default;
            Core.Optional<AllocationMethod> ipv6AddressType = default;
            Core.Optional<AllocationMethod> macAddressType = default;
            Core.Optional<string> nicId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv4Addresses = array;
                    continue;
                }
                if (property.NameEquals("ipv6Addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv6Addresses = array;
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualNetworkId"u8))
                {
                    virtualNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4AddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv4AddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv6AddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv6AddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("macAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    macAddressType = new AllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkInterfaces(name.Value, displayName.Value, Core.Optional.ToList(ipv4Addresses), Core.Optional.ToList(ipv6Addresses), macAddress.Value, virtualNetworkId.Value, networkName.Value, Core.Optional.ToNullable(ipv4AddressType), Core.Optional.ToNullable(ipv6AddressType), Core.Optional.ToNullable(macAddressType), nicId.Value);
        }
    }
}
