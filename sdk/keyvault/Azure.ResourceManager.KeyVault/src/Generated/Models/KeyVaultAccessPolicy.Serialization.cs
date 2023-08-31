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

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultAccessPolicy : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultAccessPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyVaultAccessPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyVaultAccessPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("objectId"u8);
            writer.WriteStringValue(ObjectId);
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId.Value);
            }
            writer.WritePropertyName("permissions"u8);
            if (Permissions is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<IdentityAccessPermissions>)Permissions).Serialize(writer, options);
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

        internal static KeyVaultAccessPolicy DeserializeKeyVaultAccessPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid tenantId = default;
            string objectId = default;
            Optional<Guid> applicationId = default;
            IdentityAccessPermissions permissions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("permissions"u8))
                {
                    permissions = IdentityAccessPermissions.DeserializeIdentityAccessPermissions(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyVaultAccessPolicy(tenantId, objectId, Optional.ToNullable(applicationId), permissions, rawData);
        }

        KeyVaultAccessPolicy IModelJsonSerializable<KeyVaultAccessPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultAccessPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultAccessPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyVaultAccessPolicy IModelSerializable<KeyVaultAccessPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyVaultAccessPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyVaultAccessPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyVaultAccessPolicy"/> to convert. </param>
        public static implicit operator RequestContent(KeyVaultAccessPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyVaultAccessPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyVaultAccessPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyVaultAccessPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
