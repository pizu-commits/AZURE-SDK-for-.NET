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
    internal partial class ListContentKeysResponse : IUtf8JsonSerializable, IModelJsonSerializable<ListContentKeysResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ListContentKeysResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ListContentKeysResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListContentKeysResponse>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys"u8);
                writer.WriteStartArray();
                foreach (var item in ContentKeys)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StreamingLocatorContentKey>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static ListContentKeysResponse DeserializeListContentKeysResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StreamingLocatorContentKey>> contentKeys = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamingLocatorContentKey> array = new List<StreamingLocatorContentKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingLocatorContentKey.DeserializeStreamingLocatorContentKey(item));
                    }
                    contentKeys = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ListContentKeysResponse(Optional.ToList(contentKeys), rawData);
        }

        ListContentKeysResponse IModelJsonSerializable<ListContentKeysResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListContentKeysResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeListContentKeysResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ListContentKeysResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListContentKeysResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ListContentKeysResponse IModelSerializable<ListContentKeysResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListContentKeysResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeListContentKeysResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ListContentKeysResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ListContentKeysResponse"/> to convert. </param>
        public static implicit operator RequestContent(ListContentKeysResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ListContentKeysResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ListContentKeysResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeListContentKeysResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
