// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class GeoJsonMultiPoint : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
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
                    writer.WriteNumberValue(item0);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToSerialString());
            writer.WriteEndObject();
        }

        internal static GeoJsonMultiPoint DeserializeGeoJsonMultiPoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IList<double>> coordinates = default;
            GeoJsonObjectType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<IList<double>> array = new List<IList<double>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<double> array0 = new List<double>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetDouble());
                            }
                            array.Add(array0);
                        }
                    }
                    coordinates = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
            }
            return new GeoJsonMultiPoint(type, coordinates);
        }
    }
}
