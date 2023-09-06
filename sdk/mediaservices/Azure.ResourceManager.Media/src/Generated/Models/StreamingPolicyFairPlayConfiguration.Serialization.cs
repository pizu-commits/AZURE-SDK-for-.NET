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
    public partial class StreamingPolicyFairPlayConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<StreamingPolicyFairPlayConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamingPolicyFairPlayConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamingPolicyFairPlayConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPolicyFairPlayConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomLicenseAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customLicenseAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomLicenseAcquisitionUriTemplate);
            }
            writer.WritePropertyName("allowPersistentLicense"u8);
            writer.WriteBooleanValue(AllowPersistentLicense);
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

        internal static StreamingPolicyFairPlayConfiguration DeserializeStreamingPolicyFairPlayConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> customLicenseAcquisitionUriTemplate = default;
            bool allowPersistentLicense = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customLicenseAcquisitionUrlTemplate"u8))
                {
                    customLicenseAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowPersistentLicense"u8))
                {
                    allowPersistentLicense = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StreamingPolicyFairPlayConfiguration(customLicenseAcquisitionUriTemplate.Value, allowPersistentLicense, rawData);
        }

        StreamingPolicyFairPlayConfiguration IModelJsonSerializable<StreamingPolicyFairPlayConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPolicyFairPlayConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPolicyFairPlayConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamingPolicyFairPlayConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPolicyFairPlayConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamingPolicyFairPlayConfiguration IModelSerializable<StreamingPolicyFairPlayConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingPolicyFairPlayConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamingPolicyFairPlayConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamingPolicyFairPlayConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamingPolicyFairPlayConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(StreamingPolicyFairPlayConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamingPolicyFairPlayConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamingPolicyFairPlayConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamingPolicyFairPlayConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
