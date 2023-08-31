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
    public partial class ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("bestEffort"u8);
            writer.WriteBooleanValue(IsBestEffort);
            writer.WritePropertyName("configurationData"u8);
            writer.WriteNumberValue(ConfigurationData);
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

        internal static ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool bestEffort = default;
            int configurationData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bestEffort"u8))
                {
                    bestEffort = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationData"u8))
                {
                    configurationData = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(bestEffort, configurationData, rawData);
        }

        ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction IModelJsonSerializable<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction IModelSerializable<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction"/> to convert. </param>
        public static implicit operator RequestContent(ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
