// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class VirtualNetworksProperties : IUtf8JsonSerializable, IModelJsonSerializable<VirtualNetworksProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualNetworksProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualNetworksProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(InfraVnetProfile))
            {
                writer.WritePropertyName("infraVnetProfile"u8);
                if (InfraVnetProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualNetworksPropertiesInfraVnetProfile>)InfraVnetProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(VipPool))
            {
                writer.WritePropertyName("vipPool"u8);
                writer.WriteStartArray();
                foreach (var item in VipPool)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualNetworksPropertiesVipPoolItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmipPool))
            {
                writer.WritePropertyName("vmipPool"u8);
                writer.WriteStartArray();
                foreach (var item in VmipPool)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualNetworksPropertiesVmipPoolItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Gateway))
            {
                writer.WritePropertyName("gateway"u8);
                writer.WriteStringValue(Gateway);
            }
            if (Optional.IsDefined(IPAddressPrefix))
            {
                writer.WritePropertyName("ipAddressPrefix"u8);
                writer.WriteStringValue(IPAddressPrefix);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static VirtualNetworksProperties DeserializeVirtualNetworksProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualNetworksPropertiesInfraVnetProfile> infraVnetProfile = default;
            Optional<IList<VirtualNetworksPropertiesVipPoolItem>> vipPool = default;
            Optional<IList<VirtualNetworksPropertiesVmipPoolItem>> vmipPool = default;
            Optional<IReadOnlyList<string>> dhcpServers = default;
            Optional<IList<string>> dnsServers = default;
            Optional<string> gateway = default;
            Optional<string> ipAddressPrefix = default;
            Optional<string> vlanId = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<VirtualNetworksPropertiesStatus> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("infraVnetProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infraVnetProfile = VirtualNetworksPropertiesInfraVnetProfile.DeserializeVirtualNetworksPropertiesInfraVnetProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("vipPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualNetworksPropertiesVipPoolItem> array = new List<VirtualNetworksPropertiesVipPoolItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworksPropertiesVipPoolItem.DeserializeVirtualNetworksPropertiesVipPoolItem(item));
                    }
                    vipPool = array;
                    continue;
                }
                if (property.NameEquals("vmipPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualNetworksPropertiesVmipPoolItem> array = new List<VirtualNetworksPropertiesVmipPoolItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworksPropertiesVmipPoolItem.DeserializeVirtualNetworksPropertiesVmipPoolItem(item));
                    }
                    vmipPool = array;
                    continue;
                }
                if (property.NameEquals("dhcpServers"u8))
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
                    dhcpServers = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
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
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("gateway"u8))
                {
                    gateway = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressPrefix"u8))
                {
                    ipAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vlanID"u8))
                {
                    vlanId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = VirtualNetworksPropertiesStatus.DeserializeVirtualNetworksPropertiesStatus(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualNetworksProperties(infraVnetProfile.Value, Optional.ToList(vipPool), Optional.ToList(vmipPool), Optional.ToList(dhcpServers), Optional.ToList(dnsServers), gateway.Value, ipAddressPrefix.Value, vlanId.Value, Optional.ToNullable(provisioningState), status.Value, rawData);
        }

        VirtualNetworksProperties IModelJsonSerializable<VirtualNetworksProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworksProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualNetworksProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualNetworksProperties IModelSerializable<VirtualNetworksProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualNetworksProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualNetworksProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualNetworksProperties"/> to convert. </param>
        public static implicit operator RequestContent(VirtualNetworksProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualNetworksProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualNetworksProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualNetworksProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
