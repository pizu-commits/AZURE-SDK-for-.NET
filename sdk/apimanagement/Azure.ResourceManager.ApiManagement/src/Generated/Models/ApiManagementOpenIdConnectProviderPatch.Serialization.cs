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
    public partial class ApiManagementOpenIdConnectProviderPatch : IUtf8JsonSerializable, IModelJsonSerializable<ApiManagementOpenIdConnectProviderPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApiManagementOpenIdConnectProviderPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApiManagementOpenIdConnectProviderPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementOpenIdConnectProviderPatch>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(MetadataEndpoint))
            {
                writer.WritePropertyName("metadataEndpoint"u8);
                writer.WriteStringValue(MetadataEndpoint);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            writer.WriteEndObject();
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

        internal static ApiManagementOpenIdConnectProviderPatch DeserializeApiManagementOpenIdConnectProviderPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> metadataEndpoint = default;
            Optional<string> clientId = default;
            Optional<string> clientSecret = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadataEndpoint"u8))
                        {
                            metadataEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApiManagementOpenIdConnectProviderPatch(displayName.Value, description.Value, metadataEndpoint.Value, clientId.Value, clientSecret.Value, rawData);
        }

        ApiManagementOpenIdConnectProviderPatch IModelJsonSerializable<ApiManagementOpenIdConnectProviderPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementOpenIdConnectProviderPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementOpenIdConnectProviderPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApiManagementOpenIdConnectProviderPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementOpenIdConnectProviderPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApiManagementOpenIdConnectProviderPatch IModelSerializable<ApiManagementOpenIdConnectProviderPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementOpenIdConnectProviderPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApiManagementOpenIdConnectProviderPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApiManagementOpenIdConnectProviderPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApiManagementOpenIdConnectProviderPatch"/> to convert. </param>
        public static implicit operator RequestContent(ApiManagementOpenIdConnectProviderPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApiManagementOpenIdConnectProviderPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApiManagementOpenIdConnectProviderPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApiManagementOpenIdConnectProviderPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
