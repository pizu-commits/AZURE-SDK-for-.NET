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

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static ContentKeyPolicyConfiguration DeserializeContentKeyPolicyConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.ContentKeyPolicyClearKeyConfiguration": return ContentKeyPolicyClearKeyConfiguration.DeserializeContentKeyPolicyClearKeyConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyFairPlayConfiguration": return ContentKeyPolicyFairPlayConfiguration.DeserializeContentKeyPolicyFairPlayConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyPlayReadyConfiguration": return ContentKeyPolicyPlayReadyConfiguration.DeserializeContentKeyPolicyPlayReadyConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyUnknownConfiguration": return ContentKeyPolicyUnknownConfiguration.DeserializeContentKeyPolicyUnknownConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyWidevineConfiguration": return ContentKeyPolicyWidevineConfiguration.DeserializeContentKeyPolicyWidevineConfiguration(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownContentKeyPolicyConfiguration(odataType, rawData);
        }

        ContentKeyPolicyConfiguration IModelJsonSerializable<ContentKeyPolicyConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyConfiguration IModelSerializable<ContentKeyPolicyConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentKeyPolicyConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentKeyPolicyConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContentKeyPolicyConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentKeyPolicyConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentKeyPolicyConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
