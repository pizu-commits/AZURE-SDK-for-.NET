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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class NetworkStatusContract : IUtf8JsonSerializable, IModelJsonSerializable<NetworkStatusContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkStatusContract>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkStatusContract>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkStatusContract>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("dnsServers"u8);
            writer.WriteStartArray();
            foreach (var item in DnsServers)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("connectivityStatus"u8);
            writer.WriteStartArray();
            foreach (var item in ConnectivityStatus)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConnectivityStatusContract>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static NetworkStatusContract DeserializeNetworkStatusContract(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> dnsServers = default;
            IReadOnlyList<ConnectivityStatusContract> connectivityStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("connectivityStatus"u8))
                {
                    List<ConnectivityStatusContract> array = new List<ConnectivityStatusContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityStatusContract.DeserializeConnectivityStatusContract(item));
                    }
                    connectivityStatus = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkStatusContract(dnsServers, connectivityStatus, rawData);
        }

        NetworkStatusContract IModelJsonSerializable<NetworkStatusContract>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkStatusContract>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkStatusContract(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkStatusContract>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkStatusContract>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkStatusContract IModelSerializable<NetworkStatusContract>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkStatusContract>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkStatusContract(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkStatusContract"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkStatusContract"/> to convert. </param>
        public static implicit operator RequestContent(NetworkStatusContract model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkStatusContract"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkStatusContract(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkStatusContract(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
