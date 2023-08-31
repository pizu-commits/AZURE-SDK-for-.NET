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
    public partial class CheckSystemServicesUpdatesAvailableResponse : IUtf8JsonSerializable, IModelJsonSerializable<CheckSystemServicesUpdatesAvailableResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CheckSystemServicesUpdatesAvailableResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CheckSystemServicesUpdatesAvailableResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static CheckSystemServicesUpdatesAvailableResponse DeserializeCheckSystemServicesUpdatesAvailableResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<UpdatesAvailable> updatesAvailable = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("updatesAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatesAvailable = new UpdatesAvailable(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CheckSystemServicesUpdatesAvailableResponse(Optional.ToNullable(updatesAvailable), rawData);
        }

        CheckSystemServicesUpdatesAvailableResponse IModelJsonSerializable<CheckSystemServicesUpdatesAvailableResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckSystemServicesUpdatesAvailableResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CheckSystemServicesUpdatesAvailableResponse>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CheckSystemServicesUpdatesAvailableResponse IModelSerializable<CheckSystemServicesUpdatesAvailableResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCheckSystemServicesUpdatesAvailableResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CheckSystemServicesUpdatesAvailableResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CheckSystemServicesUpdatesAvailableResponse"/> to convert. </param>
        public static implicit operator RequestContent(CheckSystemServicesUpdatesAvailableResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CheckSystemServicesUpdatesAvailableResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CheckSystemServicesUpdatesAvailableResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCheckSystemServicesUpdatesAvailableResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
