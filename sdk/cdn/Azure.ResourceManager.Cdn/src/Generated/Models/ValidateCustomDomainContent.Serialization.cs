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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ValidateCustomDomainContent : IUtf8JsonSerializable, IModelJsonSerializable<ValidateCustomDomainContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ValidateCustomDomainContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ValidateCustomDomainContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ValidateCustomDomainContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("hostName"u8);
            writer.WriteStringValue(HostName);
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

        internal static ValidateCustomDomainContent DeserializeValidateCustomDomainContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hostName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ValidateCustomDomainContent(hostName, rawData);
        }

        ValidateCustomDomainContent IModelJsonSerializable<ValidateCustomDomainContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ValidateCustomDomainContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateCustomDomainContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ValidateCustomDomainContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ValidateCustomDomainContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ValidateCustomDomainContent IModelSerializable<ValidateCustomDomainContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ValidateCustomDomainContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeValidateCustomDomainContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ValidateCustomDomainContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ValidateCustomDomainContent"/> to convert. </param>
        public static implicit operator RequestContent(ValidateCustomDomainContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ValidateCustomDomainContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ValidateCustomDomainContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeValidateCustomDomainContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
