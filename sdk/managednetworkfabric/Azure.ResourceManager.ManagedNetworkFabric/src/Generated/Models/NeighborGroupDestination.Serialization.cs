// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NeighborGroupDestination : IUtf8JsonSerializable, IModelJsonSerializable<NeighborGroupDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NeighborGroupDestination>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NeighborGroupDestination>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NeighborGroupDestination>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPv4Addresses))
            {
                writer.WritePropertyName("ipv4Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4Addresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6Addresses))
            {
                writer.WritePropertyName("ipv6Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6Addresses)
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

        internal static NeighborGroupDestination DeserializeNeighborGroupDestination(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<IPAddress>> ipv4Addresses = default;
            Optional<IList<string>> ipv6Addresses = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipv4Addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NeighborGroupDestination(Optional.ToList(ipv4Addresses), Optional.ToList(ipv6Addresses), rawData);
        }

        NeighborGroupDestination IModelJsonSerializable<NeighborGroupDestination>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NeighborGroupDestination>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNeighborGroupDestination(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NeighborGroupDestination>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NeighborGroupDestination>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NeighborGroupDestination IModelSerializable<NeighborGroupDestination>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NeighborGroupDestination>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNeighborGroupDestination(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NeighborGroupDestination"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NeighborGroupDestination"/> to convert. </param>
        public static implicit operator RequestContent(NeighborGroupDestination model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NeighborGroupDestination"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NeighborGroupDestination(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNeighborGroupDestination(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
