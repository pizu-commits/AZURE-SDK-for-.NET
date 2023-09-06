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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformApiPortalProperties : IUtf8JsonSerializable, IModelJsonSerializable<AppPlatformApiPortalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppPlatformApiPortalProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppPlatformApiPortalProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformApiPortalProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsPublic))
            {
                writer.WritePropertyName("public"u8);
                writer.WriteBooleanValue(IsPublic.Value);
            }
            if (Optional.IsDefined(IsHttpsOnly))
            {
                writer.WritePropertyName("httpsOnly"u8);
                writer.WriteBooleanValue(IsHttpsOnly.Value);
            }
            if (Optional.IsCollectionDefined(GatewayIds))
            {
                writer.WritePropertyName("gatewayIds"u8);
                writer.WriteStartArray();
                foreach (var item in GatewayIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceUris))
            {
                writer.WritePropertyName("sourceUrls"u8);
                writer.WriteStartArray();
                foreach (var item in SourceUris)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SsoProperties))
            {
                writer.WritePropertyName("ssoProperties"u8);
                if (SsoProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppPlatformSsoProperties>)SsoProperties).Serialize(writer, options);
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

        internal static AppPlatformApiPortalProperties DeserializeAppPlatformApiPortalProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformApiPortalProvisioningState> provisioningState = default;
            Optional<bool> @public = default;
            Optional<Uri> uri = default;
            Optional<bool> httpsOnly = default;
            Optional<IList<ResourceIdentifier>> gatewayIds = default;
            Optional<IList<Uri>> sourceUris = default;
            Optional<AppPlatformSsoProperties> ssoProperties = default;
            Optional<AppPlatformApiPortalResourceRequirements> resourceRequests = default;
            Optional<IReadOnlyList<AppPlatformApiPortalInstance>> instances = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformApiPortalProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("public"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @public = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpsOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpsOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gatewayIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    gatewayIds = array;
                    continue;
                }
                if (property.NameEquals("sourceUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    sourceUris = array;
                    continue;
                }
                if (property.NameEquals("ssoProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssoProperties = AppPlatformSsoProperties.DeserializeAppPlatformSsoProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformApiPortalResourceRequirements.DeserializeAppPlatformApiPortalResourceRequirements(property.Value);
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformApiPortalInstance> array = new List<AppPlatformApiPortalInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformApiPortalInstance.DeserializeAppPlatformApiPortalInstance(item));
                    }
                    instances = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppPlatformApiPortalProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(@public), uri.Value, Optional.ToNullable(httpsOnly), Optional.ToList(gatewayIds), Optional.ToList(sourceUris), ssoProperties.Value, resourceRequests.Value, Optional.ToList(instances), rawData);
        }

        AppPlatformApiPortalProperties IModelJsonSerializable<AppPlatformApiPortalProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformApiPortalProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformApiPortalProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppPlatformApiPortalProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformApiPortalProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppPlatformApiPortalProperties IModelSerializable<AppPlatformApiPortalProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformApiPortalProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppPlatformApiPortalProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppPlatformApiPortalProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppPlatformApiPortalProperties"/> to convert. </param>
        public static implicit operator RequestContent(AppPlatformApiPortalProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppPlatformApiPortalProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppPlatformApiPortalProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppPlatformApiPortalProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
