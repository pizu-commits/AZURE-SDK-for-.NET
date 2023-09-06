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
    public partial class ApiManagementPortalDelegationSettingData : IUtf8JsonSerializable, IModelJsonSerializable<ApiManagementPortalDelegationSettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApiManagementPortalDelegationSettingData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApiManagementPortalDelegationSettingData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementPortalDelegationSettingData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(ValidationKey))
            {
                writer.WritePropertyName("validationKey"u8);
                writer.WriteStringValue(ValidationKey);
            }
            if (Optional.IsDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                if (Subscriptions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SubscriptionDelegationSettingProperties>)Subscriptions).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(UserRegistration))
            {
                writer.WritePropertyName("userRegistration"u8);
                if (UserRegistration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RegistrationDelegationSettingProperties>)UserRegistration).Serialize(writer, options);
                }
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

        internal static ApiManagementPortalDelegationSettingData DeserializeApiManagementPortalDelegationSettingData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<Uri> uri = default;
            Optional<string> validationKey = default;
            Optional<SubscriptionDelegationSettingProperties> subscriptions = default;
            Optional<RegistrationDelegationSettingProperties> userRegistration = default;
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
                        if (property0.NameEquals("url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("validationKey"u8))
                        {
                            validationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptions = SubscriptionDelegationSettingProperties.DeserializeSubscriptionDelegationSettingProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userRegistration = RegistrationDelegationSettingProperties.DeserializeRegistrationDelegationSettingProperties(property0.Value);
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
            return new ApiManagementPortalDelegationSettingData(id, name, type, systemData.Value, uri.Value, validationKey.Value, subscriptions.Value, userRegistration.Value, rawData);
        }

        ApiManagementPortalDelegationSettingData IModelJsonSerializable<ApiManagementPortalDelegationSettingData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementPortalDelegationSettingData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementPortalDelegationSettingData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApiManagementPortalDelegationSettingData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementPortalDelegationSettingData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApiManagementPortalDelegationSettingData IModelSerializable<ApiManagementPortalDelegationSettingData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementPortalDelegationSettingData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApiManagementPortalDelegationSettingData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApiManagementPortalDelegationSettingData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApiManagementPortalDelegationSettingData"/> to convert. </param>
        public static implicit operator RequestContent(ApiManagementPortalDelegationSettingData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApiManagementPortalDelegationSettingData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApiManagementPortalDelegationSettingData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApiManagementPortalDelegationSettingData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
