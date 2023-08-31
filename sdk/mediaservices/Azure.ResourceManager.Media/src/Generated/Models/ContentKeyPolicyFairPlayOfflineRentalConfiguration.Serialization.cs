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
    public partial class ContentKeyPolicyFairPlayOfflineRentalConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyFairPlayOfflineRentalConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyFairPlayOfflineRentalConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("playbackDurationSeconds"u8);
            writer.WriteNumberValue(PlaybackDurationInSeconds);
            writer.WritePropertyName("storageDurationSeconds"u8);
            writer.WriteNumberValue(StorageDurationInSeconds);
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

        internal static ContentKeyPolicyFairPlayOfflineRentalConfiguration DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long playbackDurationSeconds = default;
            long storageDurationSeconds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playbackDurationSeconds"u8))
                {
                    playbackDurationSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageDurationSeconds"u8))
                {
                    storageDurationSeconds = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContentKeyPolicyFairPlayOfflineRentalConfiguration(playbackDurationSeconds, storageDurationSeconds, rawData);
        }

        ContentKeyPolicyFairPlayOfflineRentalConfiguration IModelJsonSerializable<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyFairPlayOfflineRentalConfiguration IModelSerializable<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentKeyPolicyFairPlayOfflineRentalConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentKeyPolicyFairPlayOfflineRentalConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContentKeyPolicyFairPlayOfflineRentalConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentKeyPolicyFairPlayOfflineRentalConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentKeyPolicyFairPlayOfflineRentalConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
