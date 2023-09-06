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

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class SystemService : IUtf8JsonSerializable, IModelJsonSerializable<SystemService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SystemService>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SystemService>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SystemService>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("systemServiceType"u8);
            writer.WriteStringValue(SystemServiceType.ToString());
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

        internal static SystemService DeserializeSystemService(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SystemServiceType systemServiceType = default;
            Optional<string> publicIPAddress = default;
            Optional<string> version = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemServiceType"u8))
                {
                    systemServiceType = new SystemServiceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIpAddress"u8))
                {
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SystemService(systemServiceType, publicIPAddress.Value, version.Value, rawData);
        }

        SystemService IModelJsonSerializable<SystemService>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SystemService>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSystemService(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SystemService>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SystemService>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SystemService IModelSerializable<SystemService>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SystemService>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSystemService(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SystemService"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SystemService"/> to convert. </param>
        public static implicit operator RequestContent(SystemService model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SystemService"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SystemService(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSystemService(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
