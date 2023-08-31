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
    public partial class NetworkProfile : IUtf8JsonSerializable, IModelJsonSerializable<NetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LoadBalancerProfile))
            {
                writer.WritePropertyName("loadBalancerProfile"u8);
                if (LoadBalancerProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LoadBalancerProfile>)LoadBalancerProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(LoadBalancerSku))
            {
                writer.WritePropertyName("loadBalancerSku"u8);
                writer.WriteStringValue(LoadBalancerSku.Value.ToString());
            }
            if (Optional.IsDefined(DnsServiceIP))
            {
                writer.WritePropertyName("dnsServiceIP"u8);
                writer.WriteStringValue(DnsServiceIP);
            }
            if (Optional.IsDefined(NetworkPolicy))
            {
                writer.WritePropertyName("networkPolicy"u8);
                writer.WriteStringValue(NetworkPolicy.Value.ToString());
            }
            if (Optional.IsDefined(PodCidr))
            {
                writer.WritePropertyName("podCidr"u8);
                writer.WriteStringValue(PodCidr);
            }
            if (Optional.IsCollectionDefined(PodCidrs))
            {
                writer.WritePropertyName("podCidrs"u8);
                writer.WriteStartArray();
                foreach (var item in PodCidrs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServiceCidr))
            {
                writer.WritePropertyName("serviceCidr"u8);
                writer.WriteStringValue(ServiceCidr);
            }
            if (Optional.IsCollectionDefined(ServiceCidrs))
            {
                writer.WritePropertyName("serviceCidrs"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceCidrs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static NetworkProfile DeserializeNetworkProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LoadBalancerProfile> loadBalancerProfile = default;
            Optional<LoadBalancerSku> loadBalancerSku = default;
            Optional<string> dnsServiceIP = default;
            Optional<NetworkPolicy> networkPolicy = default;
            Optional<string> podCidr = default;
            Optional<IList<string>> podCidrs = default;
            Optional<string> serviceCidr = default;
            Optional<IList<string>> serviceCidrs = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loadBalancerProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancerProfile = LoadBalancerProfile.DeserializeLoadBalancerProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("loadBalancerSku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancerSku = new LoadBalancerSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsServiceIP"u8))
                {
                    dnsServiceIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkPolicy = new NetworkPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("podCidr"u8))
                {
                    podCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("podCidrs"u8))
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
                    podCidrs = array;
                    continue;
                }
                if (property.NameEquals("serviceCidr"u8))
                {
                    serviceCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceCidrs"u8))
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
                    serviceCidrs = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkProfile(loadBalancerProfile.Value, Optional.ToNullable(loadBalancerSku), dnsServiceIP.Value, Optional.ToNullable(networkPolicy), podCidr.Value, Optional.ToList(podCidrs), serviceCidr.Value, Optional.ToList(serviceCidrs), rawData);
        }

        NetworkProfile IModelJsonSerializable<NetworkProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkProfile IModelSerializable<NetworkProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkProfile"/> to convert. </param>
        public static implicit operator RequestContent(NetworkProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
