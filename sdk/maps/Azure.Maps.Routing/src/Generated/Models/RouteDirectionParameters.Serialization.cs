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
using Azure.Maps.Routing.Models;

namespace Azure.Maps.Routing
{
    public partial class RouteDirectionParameters : IUtf8JsonSerializable, IModelJsonSerializable<RouteDirectionParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouteDirectionParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouteDirectionParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouteDirectionParameters>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(_GeoJsonSupportingPoints))
            {
                writer.WritePropertyName("supportingPoints"u8);
                if (_GeoJsonSupportingPoints is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GeoJsonGeometryCollection>)_GeoJsonSupportingPoints).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AvoidVignette))
            {
                writer.WritePropertyName("avoidVignette"u8);
                writer.WriteStartArray();
                foreach (var item in AvoidVignette)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowVignette))
            {
                writer.WritePropertyName("allowVignette"u8);
                writer.WriteStartArray();
                foreach (var item in AllowVignette)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(_GeoJsonAvoidAreas))
            {
                writer.WritePropertyName("avoidAreas"u8);
                if (_GeoJsonAvoidAreas is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GeoJsonMultiPolygon>)_GeoJsonAvoidAreas).Serialize(writer, options);
                }
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

        internal static RouteDirectionParameters DeserializeRouteDirectionParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GeoJsonGeometryCollection> supportingPoints = default;
            Optional<IList<string>> avoidVignette = default;
            Optional<IList<string>> allowVignette = default;
            Optional<GeoJsonMultiPolygon> avoidAreas = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportingPoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportingPoints = GeoJsonGeometryCollection.DeserializeGeoJsonGeometryCollection(property.Value);
                    continue;
                }
                if (property.NameEquals("avoidVignette"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    avoidVignette = array;
                    continue;
                }
                if (property.NameEquals("allowVignette"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowVignette = array;
                    continue;
                }
                if (property.NameEquals("avoidAreas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    avoidAreas = GeoJsonMultiPolygon.DeserializeGeoJsonMultiPolygon(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouteDirectionParameters(supportingPoints.Value, Optional.ToList(avoidVignette), Optional.ToList(allowVignette), avoidAreas.Value, rawData);
        }

        RouteDirectionParameters IModelJsonSerializable<RouteDirectionParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouteDirectionParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouteDirectionParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouteDirectionParameters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouteDirectionParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouteDirectionParameters IModelSerializable<RouteDirectionParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouteDirectionParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouteDirectionParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RouteDirectionParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RouteDirectionParameters"/> to convert. </param>
        public static implicit operator RequestContent(RouteDirectionParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RouteDirectionParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RouteDirectionParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouteDirectionParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
