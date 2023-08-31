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
    public partial class X12ValidationOverride : IUtf8JsonSerializable, IModelJsonSerializable<X12ValidationOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<X12ValidationOverride>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<X12ValidationOverride>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("messageId"u8);
            writer.WriteStringValue(MessageId);
            writer.WritePropertyName("validateEDITypes"u8);
            writer.WriteBooleanValue(ValidateEdiTypes);
            writer.WritePropertyName("validateXSDTypes"u8);
            writer.WriteBooleanValue(ValidateXsdTypes);
            writer.WritePropertyName("allowLeadingAndTrailingSpacesAndZeroes"u8);
            writer.WriteBooleanValue(AllowLeadingAndTrailingSpacesAndZeroes);
            writer.WritePropertyName("validateCharacterSet"u8);
            writer.WriteBooleanValue(ValidateCharacterSet);
            writer.WritePropertyName("trimLeadingAndTrailingSpacesAndZeroes"u8);
            writer.WriteBooleanValue(TrimLeadingAndTrailingSpacesAndZeroes);
            writer.WritePropertyName("trailingSeparatorPolicy"u8);
            writer.WriteStringValue(TrailingSeparatorPolicy.ToString());
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

        internal static X12ValidationOverride DeserializeX12ValidationOverride(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            bool validateEdiTypes = default;
            bool validateXsdTypes = default;
            bool allowLeadingAndTrailingSpacesAndZeroes = default;
            bool validateCharacterSet = default;
            bool trimLeadingAndTrailingSpacesAndZeroes = default;
            TrailingSeparatorPolicy trailingSeparatorPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validateEDITypes"u8))
                {
                    validateEdiTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateXSDTypes"u8))
                {
                    validateXsdTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowLeadingAndTrailingSpacesAndZeroes"u8))
                {
                    allowLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateCharacterSet"u8))
                {
                    validateCharacterSet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trimLeadingAndTrailingSpacesAndZeroes"u8))
                {
                    trimLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trailingSeparatorPolicy"u8))
                {
                    trailingSeparatorPolicy = new TrailingSeparatorPolicy(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new X12ValidationOverride(messageId, validateEdiTypes, validateXsdTypes, allowLeadingAndTrailingSpacesAndZeroes, validateCharacterSet, trimLeadingAndTrailingSpacesAndZeroes, trailingSeparatorPolicy, rawData);
        }

        X12ValidationOverride IModelJsonSerializable<X12ValidationOverride>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeX12ValidationOverride(doc.RootElement, options);
        }

        BinaryData IModelSerializable<X12ValidationOverride>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        X12ValidationOverride IModelSerializable<X12ValidationOverride>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeX12ValidationOverride(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="X12ValidationOverride"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="X12ValidationOverride"/> to convert. </param>
        public static implicit operator RequestContent(X12ValidationOverride model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="X12ValidationOverride"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator X12ValidationOverride(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeX12ValidationOverride(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
