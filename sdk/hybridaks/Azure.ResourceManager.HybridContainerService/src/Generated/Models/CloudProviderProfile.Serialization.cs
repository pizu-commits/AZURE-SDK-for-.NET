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
    public partial class CloudProviderProfile : IUtf8JsonSerializable, IModelJsonSerializable<CloudProviderProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudProviderProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudProviderProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(InfraNetworkProfile))
            {
                writer.WritePropertyName("infraNetworkProfile"u8);
                if (InfraNetworkProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudProviderProfileInfraNetworkProfile>)InfraNetworkProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(InfraStorageProfile))
            {
                writer.WritePropertyName("infraStorageProfile"u8);
                if (InfraStorageProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudProviderProfileInfraStorageProfile>)InfraStorageProfile).Serialize(writer, options);
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

        internal static CloudProviderProfile DeserializeCloudProviderProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CloudProviderProfileInfraNetworkProfile> infraNetworkProfile = default;
            Optional<CloudProviderProfileInfraStorageProfile> infraStorageProfile = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("infraNetworkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infraNetworkProfile = CloudProviderProfileInfraNetworkProfile.DeserializeCloudProviderProfileInfraNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("infraStorageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infraStorageProfile = CloudProviderProfileInfraStorageProfile.DeserializeCloudProviderProfileInfraStorageProfile(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudProviderProfile(infraNetworkProfile.Value, infraStorageProfile.Value, rawData);
        }

        CloudProviderProfile IModelJsonSerializable<CloudProviderProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudProviderProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudProviderProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudProviderProfile IModelSerializable<CloudProviderProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudProviderProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CloudProviderProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CloudProviderProfile"/> to convert. </param>
        public static implicit operator RequestContent(CloudProviderProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CloudProviderProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CloudProviderProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudProviderProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
