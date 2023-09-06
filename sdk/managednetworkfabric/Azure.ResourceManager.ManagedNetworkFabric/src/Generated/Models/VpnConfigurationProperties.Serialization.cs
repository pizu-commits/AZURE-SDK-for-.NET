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
    public partial class VpnConfigurationProperties : IUtf8JsonSerializable, IModelJsonSerializable<VpnConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VpnConfigurationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VpnConfigurationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VpnConfigurationProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkToNetworkInterconnectId))
            {
                writer.WritePropertyName("networkToNetworkInterconnectId"u8);
                writer.WriteStringValue(NetworkToNetworkInterconnectId);
            }
            writer.WritePropertyName("peeringOption"u8);
            writer.WriteStringValue(PeeringOption.ToString());
            if (Optional.IsDefined(OptionBProperties))
            {
                writer.WritePropertyName("optionBProperties"u8);
                if (OptionBProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OptionBProperties>)OptionBProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OptionAProperties))
            {
                writer.WritePropertyName("optionAProperties"u8);
                if (OptionAProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VpnConfigurationOptionAProperties>)OptionAProperties).Serialize(writer, options);
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

        internal static VpnConfigurationProperties DeserializeVpnConfigurationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> networkToNetworkInterconnectId = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
            PeeringOption peeringOption = default;
            Optional<OptionBProperties> optionBProperties = default;
            Optional<VpnConfigurationOptionAProperties> optionAProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkToNetworkInterconnectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkToNetworkInterconnectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("administrativeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administrativeState = new NetworkFabricAdministrativeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peeringOption"u8))
                {
                    peeringOption = new PeeringOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optionBProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionBProperties = OptionBProperties.DeserializeOptionBProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("optionAProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionAProperties = VpnConfigurationOptionAProperties.DeserializeVpnConfigurationOptionAProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VpnConfigurationProperties(networkToNetworkInterconnectId.Value, Optional.ToNullable(administrativeState), peeringOption, optionBProperties.Value, optionAProperties.Value, rawData);
        }

        VpnConfigurationProperties IModelJsonSerializable<VpnConfigurationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VpnConfigurationProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnConfigurationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VpnConfigurationProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VpnConfigurationProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VpnConfigurationProperties IModelSerializable<VpnConfigurationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VpnConfigurationProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVpnConfigurationProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VpnConfigurationProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VpnConfigurationProperties"/> to convert. </param>
        public static implicit operator RequestContent(VpnConfigurationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VpnConfigurationProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VpnConfigurationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVpnConfigurationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
