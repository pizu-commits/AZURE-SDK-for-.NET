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

namespace Azure.Maps.Search.Models
{
    internal partial class SearchAddressBatchItem : IUtf8JsonSerializable, IModelJsonSerializable<SearchAddressBatchItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchAddressBatchItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchAddressBatchItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchItem>(this, options.Format);

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

        internal static SearchAddressBatchItem DeserializeSearchAddressBatchItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SearchAddressBatchItemResponse> response = default;
            Optional<int> statusCode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = SearchAddressBatchItemResponse.DeserializeSearchAddressBatchItemResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchAddressBatchItem(Optional.ToNullable(statusCode), response.Value, rawData);
        }

        SearchAddressBatchItem IModelJsonSerializable<SearchAddressBatchItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchAddressBatchItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchAddressBatchItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchAddressBatchItem IModelSerializable<SearchAddressBatchItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchAddressBatchItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchAddressBatchItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchAddressBatchItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchAddressBatchItem"/> to convert. </param>
        public static implicit operator RequestContent(SearchAddressBatchItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchAddressBatchItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchAddressBatchItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchAddressBatchItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
