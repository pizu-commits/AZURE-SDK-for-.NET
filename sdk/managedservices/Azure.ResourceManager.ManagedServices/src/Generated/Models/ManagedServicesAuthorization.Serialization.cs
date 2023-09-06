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

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesAuthorization : IUtf8JsonSerializable, IModelJsonSerializable<ManagedServicesAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedServicesAuthorization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedServicesAuthorization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesAuthorization>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            if (Optional.IsDefined(PrincipalIdDisplayName))
            {
                writer.WritePropertyName("principalIdDisplayName"u8);
                writer.WriteStringValue(PrincipalIdDisplayName);
            }
            writer.WritePropertyName("roleDefinitionId"u8);
            writer.WriteStringValue(RoleDefinitionId);
            if (Optional.IsCollectionDefined(DelegatedRoleDefinitionIds))
            {
                writer.WritePropertyName("delegatedRoleDefinitionIds"u8);
                writer.WriteStartArray();
                foreach (var item in DelegatedRoleDefinitionIds)
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

        internal static ManagedServicesAuthorization DeserializeManagedServicesAuthorization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid principalId = default;
            Optional<string> principalIdDisplayName = default;
            string roleDefinitionId = default;
            Optional<IList<Guid>> delegatedRoleDefinitionIds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalIdDisplayName"u8))
                {
                    principalIdDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"u8))
                {
                    roleDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delegatedRoleDefinitionIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    delegatedRoleDefinitionIds = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedServicesAuthorization(principalId, principalIdDisplayName.Value, roleDefinitionId, Optional.ToList(delegatedRoleDefinitionIds), rawData);
        }

        ManagedServicesAuthorization IModelJsonSerializable<ManagedServicesAuthorization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesAuthorization>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesAuthorization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedServicesAuthorization>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesAuthorization>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedServicesAuthorization IModelSerializable<ManagedServicesAuthorization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesAuthorization>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedServicesAuthorization(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedServicesAuthorization"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedServicesAuthorization"/> to convert. </param>
        public static implicit operator RequestContent(ManagedServicesAuthorization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedServicesAuthorization"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedServicesAuthorization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedServicesAuthorization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
