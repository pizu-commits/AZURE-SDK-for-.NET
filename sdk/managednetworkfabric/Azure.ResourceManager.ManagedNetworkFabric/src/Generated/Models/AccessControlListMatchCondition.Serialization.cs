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
    public partial class AccessControlListMatchCondition : IUtf8JsonSerializable, IModelJsonSerializable<AccessControlListMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AccessControlListMatchCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AccessControlListMatchCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchCondition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(EtherTypes))
            {
                writer.WritePropertyName("etherTypes"u8);
                writer.WriteStartArray();
                foreach (var item in EtherTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Fragments))
            {
                writer.WritePropertyName("fragments"u8);
                writer.WriteStartArray();
                foreach (var item in Fragments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPLengths))
            {
                writer.WritePropertyName("ipLengths"u8);
                writer.WriteStartArray();
                foreach (var item in IPLengths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TtlValues))
            {
                writer.WritePropertyName("ttlValues"u8);
                writer.WriteStartArray();
                foreach (var item in TtlValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DscpMarkings))
            {
                writer.WritePropertyName("dscpMarkings"u8);
                writer.WriteStartArray();
                foreach (var item in DscpMarkings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PortCondition))
            {
                writer.WritePropertyName("portCondition"u8);
                if (PortCondition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AccessControlListPortCondition>)PortCondition).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(ProtocolTypes))
            {
                writer.WritePropertyName("protocolTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ProtocolTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VlanMatchCondition))
            {
                writer.WritePropertyName("vlanMatchCondition"u8);
                if (VlanMatchCondition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VlanMatchCondition>)VlanMatchCondition).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IPCondition))
            {
                writer.WritePropertyName("ipCondition"u8);
                if (IPCondition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IPMatchCondition>)IPCondition).Serialize(writer, options);
                }
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

        internal static AccessControlListMatchCondition DeserializeAccessControlListMatchCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> etherTypes = default;
            Optional<IList<string>> fragments = default;
            Optional<IList<string>> ipLengths = default;
            Optional<IList<string>> ttlValues = default;
            Optional<IList<string>> dscpMarkings = default;
            Optional<AccessControlListPortCondition> portCondition = default;
            Optional<IList<string>> protocolTypes = default;
            Optional<VlanMatchCondition> vlanMatchCondition = default;
            Optional<IPMatchCondition> ipCondition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etherTypes"u8))
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
                    etherTypes = array;
                    continue;
                }
                if (property.NameEquals("fragments"u8))
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
                    fragments = array;
                    continue;
                }
                if (property.NameEquals("ipLengths"u8))
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
                    ipLengths = array;
                    continue;
                }
                if (property.NameEquals("ttlValues"u8))
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
                    ttlValues = array;
                    continue;
                }
                if (property.NameEquals("dscpMarkings"u8))
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
                    dscpMarkings = array;
                    continue;
                }
                if (property.NameEquals("portCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portCondition = AccessControlListPortCondition.DeserializeAccessControlListPortCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("protocolTypes"u8))
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
                    protocolTypes = array;
                    continue;
                }
                if (property.NameEquals("vlanMatchCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanMatchCondition = VlanMatchCondition.DeserializeVlanMatchCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("ipCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipCondition = IPMatchCondition.DeserializeIPMatchCondition(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AccessControlListMatchCondition(Optional.ToList(protocolTypes), vlanMatchCondition.Value, ipCondition.Value, Optional.ToList(etherTypes), Optional.ToList(fragments), Optional.ToList(ipLengths), Optional.ToList(ttlValues), Optional.ToList(dscpMarkings), portCondition.Value, rawData);
        }

        AccessControlListMatchCondition IModelJsonSerializable<AccessControlListMatchCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessControlListMatchCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AccessControlListMatchCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AccessControlListMatchCondition IModelSerializable<AccessControlListMatchCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAccessControlListMatchCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AccessControlListMatchCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AccessControlListMatchCondition"/> to convert. </param>
        public static implicit operator RequestContent(AccessControlListMatchCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AccessControlListMatchCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AccessControlListMatchCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAccessControlListMatchCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
