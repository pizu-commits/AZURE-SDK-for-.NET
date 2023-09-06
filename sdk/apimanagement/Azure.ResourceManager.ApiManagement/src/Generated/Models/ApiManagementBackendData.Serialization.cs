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
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementBackendData : IUtf8JsonSerializable, IModelJsonSerializable<ApiManagementBackendData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApiManagementBackendData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApiManagementBackendData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementBackendData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackendProperties>)Properties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                if (Credentials is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackendCredentialsContract>)Credentials).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Proxy))
            {
                writer.WritePropertyName("proxy"u8);
                if (Proxy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackendProxyContract>)Proxy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls"u8);
                if (Tls is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackendTlsProperties>)Tls).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
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

        internal static ApiManagementBackendData DeserializeApiManagementBackendData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> title = default;
            Optional<string> description = default;
            Optional<Uri> resourceId = default;
            Optional<BackendProperties> properties = default;
            Optional<BackendCredentialsContract> credentials = default;
            Optional<BackendProxyContract> proxy = default;
            Optional<BackendTlsProperties> tls = default;
            Optional<Uri> uri = default;
            Optional<BackendProtocol> protocol = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("properties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            properties = BackendProperties.DeserializeBackendProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("credentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credentials = BackendCredentialsContract.DeserializeBackendCredentialsContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("proxy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proxy = BackendProxyContract.DeserializeBackendProxyContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tls = BackendTlsProperties.DeserializeBackendTlsProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new BackendProtocol(property0.Value.GetString());
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
            return new ApiManagementBackendData(id, name, type, systemData.Value, title.Value, description.Value, resourceId.Value, properties.Value, credentials.Value, proxy.Value, tls.Value, uri.Value, Optional.ToNullable(protocol), rawData);
        }

        ApiManagementBackendData IModelJsonSerializable<ApiManagementBackendData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementBackendData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementBackendData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApiManagementBackendData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementBackendData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApiManagementBackendData IModelSerializable<ApiManagementBackendData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementBackendData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApiManagementBackendData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApiManagementBackendData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApiManagementBackendData"/> to convert. </param>
        public static implicit operator RequestContent(ApiManagementBackendData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApiManagementBackendData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApiManagementBackendData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApiManagementBackendData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
