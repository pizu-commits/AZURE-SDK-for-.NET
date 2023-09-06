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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountApiProperties : IUtf8JsonSerializable, IModelJsonSerializable<ServiceAccountApiProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceAccountApiProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceAccountApiProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAccountApiProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(QnaRuntimeEndpoint))
            {
                writer.WritePropertyName("qnaRuntimeEndpoint"u8);
                writer.WriteStringValue(QnaRuntimeEndpoint);
            }
            if (Optional.IsDefined(QnaAzureSearchEndpointKey))
            {
                writer.WritePropertyName("qnaAzureSearchEndpointKey"u8);
                writer.WriteStringValue(QnaAzureSearchEndpointKey);
            }
            if (Optional.IsDefined(QnaAzureSearchEndpointId))
            {
                writer.WritePropertyName("qnaAzureSearchEndpointId"u8);
                writer.WriteStringValue(QnaAzureSearchEndpointId);
            }
            if (Optional.IsDefined(EnableStatistics))
            {
                writer.WritePropertyName("statisticsEnabled"u8);
                writer.WriteBooleanValue(EnableStatistics.Value);
            }
            if (Optional.IsDefined(EventHubConnectionString))
            {
                writer.WritePropertyName("eventHubConnectionString"u8);
                writer.WriteStringValue(EventHubConnectionString);
            }
            if (Optional.IsDefined(StorageAccountConnectionString))
            {
                writer.WritePropertyName("storageAccountConnectionString"u8);
                writer.WriteStringValue(StorageAccountConnectionString);
            }
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId"u8);
                writer.WriteStringValue(AadClientId.Value);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(SuperUser))
            {
                writer.WritePropertyName("superUser"u8);
                writer.WriteStringValue(SuperUser);
            }
            if (Optional.IsDefined(WebsiteName))
            {
                writer.WritePropertyName("websiteName"u8);
                writer.WriteStringValue(WebsiteName);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ServiceAccountApiProperties DeserializeServiceAccountApiProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> qnaRuntimeEndpoint = default;
            Optional<string> qnaAzureSearchEndpointKey = default;
            Optional<ResourceIdentifier> qnaAzureSearchEndpointId = default;
            Optional<bool> statisticsEnabled = default;
            Optional<string> eventHubConnectionString = default;
            Optional<string> storageAccountConnectionString = default;
            Optional<Guid> aadClientId = default;
            Optional<Guid> aadTenantId = default;
            Optional<string> superUser = default;
            Optional<string> websiteName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("qnaRuntimeEndpoint"u8))
                {
                    qnaRuntimeEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qnaAzureSearchEndpointKey"u8))
                {
                    qnaAzureSearchEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qnaAzureSearchEndpointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    qnaAzureSearchEndpointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statisticsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statisticsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eventHubConnectionString"u8))
                {
                    eventHubConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountConnectionString"u8))
                {
                    storageAccountConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadClientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadClientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("aadTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("superUser"u8))
                {
                    superUser = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("websiteName"u8))
                {
                    websiteName = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ServiceAccountApiProperties(qnaRuntimeEndpoint.Value, qnaAzureSearchEndpointKey.Value, qnaAzureSearchEndpointId.Value, Optional.ToNullable(statisticsEnabled), eventHubConnectionString.Value, storageAccountConnectionString.Value, Optional.ToNullable(aadClientId), Optional.ToNullable(aadTenantId), superUser.Value, websiteName.Value, additionalProperties);
        }

        ServiceAccountApiProperties IModelJsonSerializable<ServiceAccountApiProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAccountApiProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAccountApiProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceAccountApiProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAccountApiProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceAccountApiProperties IModelSerializable<ServiceAccountApiProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceAccountApiProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceAccountApiProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceAccountApiProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceAccountApiProperties"/> to convert. </param>
        public static implicit operator RequestContent(ServiceAccountApiProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceAccountApiProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceAccountApiProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceAccountApiProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
