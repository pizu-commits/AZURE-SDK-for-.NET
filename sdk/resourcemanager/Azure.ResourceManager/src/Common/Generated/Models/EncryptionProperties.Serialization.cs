// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(EncryptionPropertiesConverter))]
    public partial class EncryptionProperties : IUtf8JsonSerializable, IModelJsonSerializable<EncryptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EncryptionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EncryptionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                if (KeyVaultProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<KeyVaultProperties>)KeyVaultProperties).Serialize(writer, options);
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static EncryptionProperties DeserializeEncryptionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EncryptionStatus> status = default;
            Optional<KeyVaultProperties> keyVaultProperties = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new EncryptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultProperties = KeyVaultProperties.DeserializeKeyVaultProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EncryptionProperties(Optional.ToNullable(status), keyVaultProperties.Value, serializedAdditionalRawData);
        }

        EncryptionProperties IModelJsonSerializable<EncryptionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EncryptionProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EncryptionProperties IModelSerializable<EncryptionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEncryptionProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EncryptionProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EncryptionProperties"/> to convert. </param>
        public static implicit operator RequestContent(EncryptionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EncryptionProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EncryptionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEncryptionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class EncryptionPropertiesConverter : JsonConverter<EncryptionProperties>
        {
            public override void Write(Utf8JsonWriter writer, EncryptionProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EncryptionProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEncryptionProperties(document.RootElement);
            }
        }
    }
}
