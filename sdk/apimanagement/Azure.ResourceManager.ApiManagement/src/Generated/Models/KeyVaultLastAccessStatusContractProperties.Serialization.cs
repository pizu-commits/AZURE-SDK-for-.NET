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
    public partial class KeyVaultLastAccessStatusContractProperties : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultLastAccessStatusContractProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyVaultLastAccessStatusContractProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyVaultLastAccessStatusContractProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultLastAccessStatusContractProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(TimeStampUtc))
            {
                writer.WritePropertyName("timeStampUtc"u8);
                writer.WriteStringValue(TimeStampUtc.Value, "O");
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

        internal static KeyVaultLastAccessStatusContractProperties DeserializeKeyVaultLastAccessStatusContractProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> timeStampUtc = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeStampUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeStampUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyVaultLastAccessStatusContractProperties(code.Value, message.Value, Optional.ToNullable(timeStampUtc), rawData);
        }

        KeyVaultLastAccessStatusContractProperties IModelJsonSerializable<KeyVaultLastAccessStatusContractProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultLastAccessStatusContractProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultLastAccessStatusContractProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultLastAccessStatusContractProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultLastAccessStatusContractProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyVaultLastAccessStatusContractProperties IModelSerializable<KeyVaultLastAccessStatusContractProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultLastAccessStatusContractProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyVaultLastAccessStatusContractProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyVaultLastAccessStatusContractProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyVaultLastAccessStatusContractProperties"/> to convert. </param>
        public static implicit operator RequestContent(KeyVaultLastAccessStatusContractProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyVaultLastAccessStatusContractProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyVaultLastAccessStatusContractProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyVaultLastAccessStatusContractProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
