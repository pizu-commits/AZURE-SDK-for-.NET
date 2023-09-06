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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountKeys : IUtf8JsonSerializable, IModelJsonSerializable<BatchAccountKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchAccountKeys>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchAccountKeys>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountKeys>(this, options.Format);

            writer.WriteStartObject();
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

        internal static BatchAccountKeys DeserializeBatchAccountKeys(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountName = default;
            Optional<string> primary = default;
            Optional<string> secondary = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primary"u8))
                {
                    primary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondary"u8))
                {
                    secondary = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchAccountKeys(accountName.Value, primary.Value, secondary.Value, rawData);
        }

        BatchAccountKeys IModelJsonSerializable<BatchAccountKeys>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountKeys>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountKeys(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchAccountKeys>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountKeys>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchAccountKeys IModelSerializable<BatchAccountKeys>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchAccountKeys>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchAccountKeys(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchAccountKeys"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchAccountKeys"/> to convert. </param>
        public static implicit operator RequestContent(BatchAccountKeys model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchAccountKeys"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchAccountKeys(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchAccountKeys(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
