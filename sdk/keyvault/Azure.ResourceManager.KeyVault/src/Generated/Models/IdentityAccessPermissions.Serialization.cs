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
    public partial class IdentityAccessPermissions : IUtf8JsonSerializable, IModelJsonSerializable<IdentityAccessPermissions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IdentityAccessPermissions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IdentityAccessPermissions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                writer.WriteStartArray();
                foreach (var item in Keys)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteStartArray();
                foreach (var item in Storage)
                {
                    writer.WriteStringValue(item.ToString());
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

        internal static IdentityAccessPermissions DeserializeIdentityAccessPermissions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<IdentityAccessKeyPermission>> keys = default;
            Optional<IList<IdentityAccessSecretPermission>> secrets = default;
            Optional<IList<IdentityAccessCertificatePermission>> certificates = default;
            Optional<IList<IdentityAccessStoragePermission>> storage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessKeyPermission> array = new List<IdentityAccessKeyPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessKeyPermission(item.GetString()));
                    }
                    keys = array;
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessSecretPermission> array = new List<IdentityAccessSecretPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessSecretPermission(item.GetString()));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("certificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessCertificatePermission> array = new List<IdentityAccessCertificatePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessCertificatePermission(item.GetString()));
                    }
                    certificates = array;
                    continue;
                }
                if (property.NameEquals("storage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessStoragePermission> array = new List<IdentityAccessStoragePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessStoragePermission(item.GetString()));
                    }
                    storage = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IdentityAccessPermissions(Optional.ToList(keys), Optional.ToList(secrets), Optional.ToList(certificates), Optional.ToList(storage), rawData);
        }

        IdentityAccessPermissions IModelJsonSerializable<IdentityAccessPermissions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIdentityAccessPermissions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IdentityAccessPermissions>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IdentityAccessPermissions IModelSerializable<IdentityAccessPermissions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIdentityAccessPermissions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IdentityAccessPermissions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IdentityAccessPermissions"/> to convert. </param>
        public static implicit operator RequestContent(IdentityAccessPermissions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IdentityAccessPermissions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IdentityAccessPermissions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIdentityAccessPermissions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
