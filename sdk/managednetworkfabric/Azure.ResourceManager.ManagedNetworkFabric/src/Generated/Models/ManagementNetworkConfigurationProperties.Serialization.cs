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
    public partial class ManagementNetworkConfigurationProperties : IUtf8JsonSerializable, IModelJsonSerializable<ManagementNetworkConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagementNetworkConfigurationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagementNetworkConfigurationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementNetworkConfigurationProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("infrastructureVpnConfiguration"u8);
            if (InfrastructureVpnConfiguration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<VpnConfigurationProperties>)InfrastructureVpnConfiguration).Serialize(writer, options);
            }
            writer.WritePropertyName("workloadVpnConfiguration"u8);
            if (WorkloadVpnConfiguration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<VpnConfigurationProperties>)WorkloadVpnConfiguration).Serialize(writer, options);
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

        internal static ManagementNetworkConfigurationProperties DeserializeManagementNetworkConfigurationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VpnConfigurationProperties infrastructureVpnConfiguration = default;
            VpnConfigurationProperties workloadVpnConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("infrastructureVpnConfiguration"u8))
                {
                    infrastructureVpnConfiguration = VpnConfigurationProperties.DeserializeVpnConfigurationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("workloadVpnConfiguration"u8))
                {
                    workloadVpnConfiguration = VpnConfigurationProperties.DeserializeVpnConfigurationProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagementNetworkConfigurationProperties(infrastructureVpnConfiguration, workloadVpnConfiguration, rawData);
        }

        ManagementNetworkConfigurationProperties IModelJsonSerializable<ManagementNetworkConfigurationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementNetworkConfigurationProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementNetworkConfigurationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagementNetworkConfigurationProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementNetworkConfigurationProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagementNetworkConfigurationProperties IModelSerializable<ManagementNetworkConfigurationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementNetworkConfigurationProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagementNetworkConfigurationProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagementNetworkConfigurationProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagementNetworkConfigurationProperties"/> to convert. </param>
        public static implicit operator RequestContent(ManagementNetworkConfigurationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagementNetworkConfigurationProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagementNetworkConfigurationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagementNetworkConfigurationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
