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

namespace Azure.ResourceManager.Kubernetes.Models
{
    public partial class HybridConnectionConfig : IUtf8JsonSerializable, IModelJsonSerializable<HybridConnectionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HybridConnectionConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HybridConnectionConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridConnectionConfig>(this, options.Format);

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

        internal static HybridConnectionConfig DeserializeHybridConnectionConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> expirationTime = default;
            Optional<string> hybridConnectionName = default;
            Optional<string> relay = default;
            Optional<string> token = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("hybridConnectionName"u8))
                {
                    hybridConnectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relay"u8))
                {
                    relay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HybridConnectionConfig(Optional.ToNullable(expirationTime), hybridConnectionName.Value, relay.Value, token.Value, rawData);
        }

        HybridConnectionConfig IModelJsonSerializable<HybridConnectionConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridConnectionConfig>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridConnectionConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HybridConnectionConfig>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridConnectionConfig>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HybridConnectionConfig IModelSerializable<HybridConnectionConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridConnectionConfig>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHybridConnectionConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HybridConnectionConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HybridConnectionConfig"/> to convert. </param>
        public static implicit operator RequestContent(HybridConnectionConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HybridConnectionConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HybridConnectionConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHybridConnectionConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
