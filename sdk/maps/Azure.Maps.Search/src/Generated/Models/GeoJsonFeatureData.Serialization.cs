// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class GeoJsonFeatureData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("geometry"u8);
            writer.WriteObjectValue(Geometry);
            if (Core.Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(FeatureType))
            {
                writer.WritePropertyName("featureType"u8);
                writer.WriteStringValue(FeatureType);
            }
            writer.WriteEndObject();
        }

        internal static GeoJsonFeatureData DeserializeGeoJsonFeatureData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GeoJsonGeometry geometry = default;
            Core.Optional<object> properties = default;
            Core.Optional<string> id = default;
            Core.Optional<string> featureType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("geometry"u8))
                {
                    geometry = GeoJsonGeometry.DeserializeGeoJsonGeometry(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureType"u8))
                {
                    featureType = property.Value.GetString();
                    continue;
                }
            }
            return new GeoJsonFeatureData(geometry, properties.Value, id.Value, featureType.Value);
        }
    }
}
