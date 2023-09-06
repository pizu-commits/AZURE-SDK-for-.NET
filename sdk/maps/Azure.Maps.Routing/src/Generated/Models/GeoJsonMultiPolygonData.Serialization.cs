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
    internal partial class GeoJsonMultiPolygonData : IUtf8JsonSerializable, IModelJsonSerializable<GeoJsonMultiPolygonData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GeoJsonMultiPolygonData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GeoJsonMultiPolygonData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonMultiPolygonData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("coordinates"u8);
            writer.WriteStartArray();
            foreach (var item in Coordinates)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStartArray();
                foreach (var item0 in item)
                {
                    if (item0 == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item1 in item0)
                    {
                        if (item1 == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStartArray();
                        foreach (var item2 in item1)
                        {
                            writer.WriteNumberValue(item2);
                        }
                        writer.WriteEndArray();
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
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

        internal static GeoJsonMultiPolygonData DeserializeGeoJsonMultiPolygonData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IList<IList<IList<double>>>> coordinates = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<IList<IList<IList<double>>>> array = new List<IList<IList<IList<double>>>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<IList<IList<double>>> array0 = new List<IList<IList<double>>>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                if (item0.ValueKind == JsonValueKind.Null)
                                {
                                    array0.Add(null);
                                }
                                else
                                {
                                    List<IList<double>> array1 = new List<IList<double>>();
                                    foreach (var item1 in item0.EnumerateArray())
                                    {
                                        if (item1.ValueKind == JsonValueKind.Null)
                                        {
                                            array1.Add(null);
                                        }
                                        else
                                        {
                                            List<double> array2 = new List<double>();
                                            foreach (var item2 in item1.EnumerateArray())
                                            {
                                                array2.Add(item2.GetDouble());
                                            }
                                            array1.Add(array2);
                                        }
                                    }
                                    array0.Add(array1);
                                }
                            }
                            array.Add(array0);
                        }
                    }
                    coordinates = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GeoJsonMultiPolygonData(coordinates, rawData);
        }

        GeoJsonMultiPolygonData IModelJsonSerializable<GeoJsonMultiPolygonData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonMultiPolygonData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGeoJsonMultiPolygonData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GeoJsonMultiPolygonData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonMultiPolygonData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GeoJsonMultiPolygonData IModelSerializable<GeoJsonMultiPolygonData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GeoJsonMultiPolygonData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGeoJsonMultiPolygonData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GeoJsonMultiPolygonData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GeoJsonMultiPolygonData"/> to convert. </param>
        public static implicit operator RequestContent(GeoJsonMultiPolygonData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GeoJsonMultiPolygonData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GeoJsonMultiPolygonData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGeoJsonMultiPolygonData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
