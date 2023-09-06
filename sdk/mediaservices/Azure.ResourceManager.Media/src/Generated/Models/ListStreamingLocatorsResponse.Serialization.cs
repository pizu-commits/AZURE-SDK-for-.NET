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
    internal partial class ListStreamingLocatorsResponse : IUtf8JsonSerializable, IModelJsonSerializable<ListStreamingLocatorsResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ListStreamingLocatorsResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ListStreamingLocatorsResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListStreamingLocatorsResponse>(this, options.Format);

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

        internal static ListStreamingLocatorsResponse DeserializeListStreamingLocatorsResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MediaAssetStreamingLocator>> streamingLocators = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingLocators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaAssetStreamingLocator> array = new List<MediaAssetStreamingLocator>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaAssetStreamingLocator.DeserializeMediaAssetStreamingLocator(item));
                    }
                    streamingLocators = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ListStreamingLocatorsResponse(Optional.ToList(streamingLocators), rawData);
        }

        ListStreamingLocatorsResponse IModelJsonSerializable<ListStreamingLocatorsResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListStreamingLocatorsResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeListStreamingLocatorsResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ListStreamingLocatorsResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListStreamingLocatorsResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ListStreamingLocatorsResponse IModelSerializable<ListStreamingLocatorsResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListStreamingLocatorsResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeListStreamingLocatorsResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ListStreamingLocatorsResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ListStreamingLocatorsResponse"/> to convert. </param>
        public static implicit operator RequestContent(ListStreamingLocatorsResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ListStreamingLocatorsResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ListStreamingLocatorsResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeListStreamingLocatorsResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
