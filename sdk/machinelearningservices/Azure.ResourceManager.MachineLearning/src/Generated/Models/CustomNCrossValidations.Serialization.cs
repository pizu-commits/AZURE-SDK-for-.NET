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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomNCrossValidations : IUtf8JsonSerializable, IModelJsonSerializable<CustomNCrossValidations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomNCrossValidations>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomNCrossValidations>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomNCrossValidations>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
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

        internal static CustomNCrossValidations DeserializeCustomNCrossValidations(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            NCrossValidationsMode mode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = new NCrossValidationsMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CustomNCrossValidations(mode, value, rawData);
        }

        CustomNCrossValidations IModelJsonSerializable<CustomNCrossValidations>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomNCrossValidations>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomNCrossValidations(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomNCrossValidations>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomNCrossValidations>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomNCrossValidations IModelSerializable<CustomNCrossValidations>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomNCrossValidations>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomNCrossValidations(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CustomNCrossValidations"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CustomNCrossValidations"/> to convert. </param>
        public static implicit operator RequestContent(CustomNCrossValidations model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CustomNCrossValidations"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CustomNCrossValidations(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomNCrossValidations(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
