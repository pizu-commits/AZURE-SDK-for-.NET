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
    public partial class PointOfInterestCategoryTreeResult : IUtf8JsonSerializable, IModelJsonSerializable<PointOfInterestCategoryTreeResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PointOfInterestCategoryTreeResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PointOfInterestCategoryTreeResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static PointOfInterestCategoryTreeResult DeserializePointOfInterestCategoryTreeResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PointOfInterestCategory>> poiCategories = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("poiCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PointOfInterestCategory> array = new List<PointOfInterestCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointOfInterestCategory.DeserializePointOfInterestCategory(item));
                    }
                    poiCategories = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PointOfInterestCategoryTreeResult(Optional.ToList(poiCategories), rawData);
        }

        PointOfInterestCategoryTreeResult IModelJsonSerializable<PointOfInterestCategoryTreeResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePointOfInterestCategoryTreeResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PointOfInterestCategoryTreeResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PointOfInterestCategoryTreeResult IModelSerializable<PointOfInterestCategoryTreeResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePointOfInterestCategoryTreeResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PointOfInterestCategoryTreeResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PointOfInterestCategoryTreeResult"/> to convert. </param>
        public static implicit operator RequestContent(PointOfInterestCategoryTreeResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PointOfInterestCategoryTreeResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PointOfInterestCategoryTreeResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePointOfInterestCategoryTreeResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
