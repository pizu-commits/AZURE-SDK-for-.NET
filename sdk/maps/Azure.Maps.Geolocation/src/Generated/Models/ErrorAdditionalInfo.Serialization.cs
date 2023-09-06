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

namespace Azure.Maps.Geolocation
{
    internal partial class ErrorAdditionalInfo : IUtf8JsonSerializable, IModelJsonSerializable<ErrorAdditionalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ErrorAdditionalInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ErrorAdditionalInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ErrorAdditionalInfo>(this, options.Format);

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

        internal static ErrorAdditionalInfo DeserializeErrorAdditionalInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<object> info = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    info = property.Value.GetObject();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ErrorAdditionalInfo(type.Value, info.Value, rawData);
        }

        ErrorAdditionalInfo IModelJsonSerializable<ErrorAdditionalInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ErrorAdditionalInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeErrorAdditionalInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ErrorAdditionalInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ErrorAdditionalInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ErrorAdditionalInfo IModelSerializable<ErrorAdditionalInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ErrorAdditionalInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeErrorAdditionalInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ErrorAdditionalInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ErrorAdditionalInfo"/> to convert. </param>
        public static implicit operator RequestContent(ErrorAdditionalInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ErrorAdditionalInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ErrorAdditionalInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeErrorAdditionalInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
