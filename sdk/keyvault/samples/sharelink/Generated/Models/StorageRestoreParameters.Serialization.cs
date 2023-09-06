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
    internal partial class StorageRestoreParameters : IUtf8JsonSerializable, IModelJsonSerializable<StorageRestoreParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageRestoreParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageRestoreParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageRestoreParameters>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteBase64StringValue(StorageBundleBackup, "U");
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

        internal static StorageRestoreParameters DeserializeStorageRestoreParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            byte[] value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetBytesFromBase64("U");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageRestoreParameters(value, rawData);
        }

        StorageRestoreParameters IModelJsonSerializable<StorageRestoreParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageRestoreParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageRestoreParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageRestoreParameters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageRestoreParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageRestoreParameters IModelSerializable<StorageRestoreParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageRestoreParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageRestoreParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageRestoreParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageRestoreParameters"/> to convert. </param>
        public static implicit operator RequestContent(StorageRestoreParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageRestoreParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageRestoreParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageRestoreParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
