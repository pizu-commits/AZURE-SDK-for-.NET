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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicTreeParameterInfo : IUtf8JsonSerializable, IModelJsonSerializable<SwaggerCustomDynamicTreeParameterInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SwaggerCustomDynamicTreeParameterInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SwaggerCustomDynamicTreeParameterInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeParameterInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SelectedItemValuePath))
            {
                writer.WritePropertyName("selectedItemValuePath"u8);
                writer.WriteStringValue(SelectedItemValuePath);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Value.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ParameterReference))
            {
                writer.WritePropertyName("parameterReference"u8);
                writer.WriteStringValue(ParameterReference);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("required"u8);
                writer.WriteBooleanValue(IsRequired.Value);
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

        internal static SwaggerCustomDynamicTreeParameterInfo DeserializeSwaggerCustomDynamicTreeParameterInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> selectedItemValuePath = default;
            Optional<BinaryData> value = default;
            Optional<string> parameterReference = default;
            Optional<bool> required = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedItemValuePath"u8))
                {
                    selectedItemValuePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parameterReference"u8))
                {
                    parameterReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SwaggerCustomDynamicTreeParameterInfo(selectedItemValuePath.Value, value.Value, parameterReference.Value, Optional.ToNullable(required), rawData);
        }

        SwaggerCustomDynamicTreeParameterInfo IModelJsonSerializable<SwaggerCustomDynamicTreeParameterInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeParameterInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicTreeParameterInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SwaggerCustomDynamicTreeParameterInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeParameterInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SwaggerCustomDynamicTreeParameterInfo IModelSerializable<SwaggerCustomDynamicTreeParameterInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SwaggerCustomDynamicTreeParameterInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSwaggerCustomDynamicTreeParameterInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SwaggerCustomDynamicTreeParameterInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SwaggerCustomDynamicTreeParameterInfo"/> to convert. </param>
        public static implicit operator RequestContent(SwaggerCustomDynamicTreeParameterInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SwaggerCustomDynamicTreeParameterInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SwaggerCustomDynamicTreeParameterInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSwaggerCustomDynamicTreeParameterInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
