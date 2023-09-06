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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class MatchConfigurationIPGroupProperties : IUtf8JsonSerializable, IModelJsonSerializable<MatchConfigurationIPGroupProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MatchConfigurationIPGroupProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MatchConfigurationIPGroupProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MatchConfigurationIPGroupProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPPrefixes))
            {
                writer.WritePropertyName("ipPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPPrefixes)
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

        internal static MatchConfigurationIPGroupProperties DeserializeMatchConfigurationIPGroupProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<NetworkFabricIPAddressType> ipAddressType = default;
            Optional<IList<string>> ipPrefixes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NetworkFabricIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipPrefixes"u8))
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
                    ipPrefixes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MatchConfigurationIPGroupProperties(name.Value, Optional.ToNullable(ipAddressType), Optional.ToList(ipPrefixes), rawData);
        }

        MatchConfigurationIPGroupProperties IModelJsonSerializable<MatchConfigurationIPGroupProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MatchConfigurationIPGroupProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMatchConfigurationIPGroupProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MatchConfigurationIPGroupProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MatchConfigurationIPGroupProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MatchConfigurationIPGroupProperties IModelSerializable<MatchConfigurationIPGroupProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MatchConfigurationIPGroupProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMatchConfigurationIPGroupProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MatchConfigurationIPGroupProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MatchConfigurationIPGroupProperties"/> to convert. </param>
        public static implicit operator RequestContent(MatchConfigurationIPGroupProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MatchConfigurationIPGroupProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MatchConfigurationIPGroupProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMatchConfigurationIPGroupProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
