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
    public partial class GatewayKeyRegenerateContent : IUtf8JsonSerializable, IModelJsonSerializable<GatewayKeyRegenerateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GatewayKeyRegenerateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GatewayKeyRegenerateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayKeyRegenerateContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("keyType"u8);
            writer.WriteStringValue(KeyType.ToSerialString());
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

        internal static GatewayKeyRegenerateContent DeserializeGatewayKeyRegenerateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GatewayRegenerateKeyType keyType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyType"u8))
                {
                    keyType = property.Value.GetString().ToGatewayRegenerateKeyType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GatewayKeyRegenerateContent(keyType, rawData);
        }

        GatewayKeyRegenerateContent IModelJsonSerializable<GatewayKeyRegenerateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayKeyRegenerateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayKeyRegenerateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GatewayKeyRegenerateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayKeyRegenerateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GatewayKeyRegenerateContent IModelSerializable<GatewayKeyRegenerateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayKeyRegenerateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGatewayKeyRegenerateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GatewayKeyRegenerateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GatewayKeyRegenerateContent"/> to convert. </param>
        public static implicit operator RequestContent(GatewayKeyRegenerateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GatewayKeyRegenerateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GatewayKeyRegenerateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGatewayKeyRegenerateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
