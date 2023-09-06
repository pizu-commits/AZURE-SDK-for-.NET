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

namespace Azure.Maps.Routing.Models
{
    internal partial class GeoJsonFeatureCollection : IUtf8JsonSerializable, IModelJsonSerializable<GeoJsonFeatureCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GeoJsonFeatureCollection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GeoJsonFeatureCollection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonFeatureCollection>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("features"u8);
            writer.WriteStartArray();
            foreach (var item in Features)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GeoJsonFeature>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToSerialString());
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

        internal static GeoJsonFeatureCollection DeserializeGeoJsonFeatureCollection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<GeoJsonFeature> features = default;
            GeoJsonObjectType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("features"u8))
                {
                    List<GeoJsonFeature> array = new List<GeoJsonFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoJsonFeature.DeserializeGeoJsonFeature(item));
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GeoJsonFeatureCollection(type, features, rawData);
        }

        GeoJsonFeatureCollection IModelJsonSerializable<GeoJsonFeatureCollection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonFeatureCollection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGeoJsonFeatureCollection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GeoJsonFeatureCollection>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonFeatureCollection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GeoJsonFeatureCollection IModelSerializable<GeoJsonFeatureCollection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonFeatureCollection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGeoJsonFeatureCollection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GeoJsonFeatureCollection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GeoJsonFeatureCollection"/> to convert. </param>
        public static implicit operator RequestContent(GeoJsonFeatureCollection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GeoJsonFeatureCollection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GeoJsonFeatureCollection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGeoJsonFeatureCollection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
