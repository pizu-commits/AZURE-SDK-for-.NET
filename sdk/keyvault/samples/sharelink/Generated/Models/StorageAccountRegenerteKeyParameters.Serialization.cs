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

namespace Azure.Security.KeyVault.Storage.Models
{
    internal partial class StorageAccountRegenerteKeyParameters : IUtf8JsonSerializable, IModelJsonSerializable<StorageAccountRegenerteKeyParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageAccountRegenerteKeyParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageAccountRegenerteKeyParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountRegenerteKeyParameters>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
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

        internal static StorageAccountRegenerteKeyParameters DeserializeStorageAccountRegenerteKeyParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageAccountRegenerteKeyParameters(keyName, rawData);
        }

        StorageAccountRegenerteKeyParameters IModelJsonSerializable<StorageAccountRegenerteKeyParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountRegenerteKeyParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountRegenerteKeyParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageAccountRegenerteKeyParameters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountRegenerteKeyParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageAccountRegenerteKeyParameters IModelSerializable<StorageAccountRegenerteKeyParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountRegenerteKeyParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageAccountRegenerteKeyParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageAccountRegenerteKeyParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageAccountRegenerteKeyParameters"/> to convert. </param>
        public static implicit operator RequestContent(StorageAccountRegenerteKeyParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageAccountRegenerteKeyParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageAccountRegenerteKeyParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageAccountRegenerteKeyParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
