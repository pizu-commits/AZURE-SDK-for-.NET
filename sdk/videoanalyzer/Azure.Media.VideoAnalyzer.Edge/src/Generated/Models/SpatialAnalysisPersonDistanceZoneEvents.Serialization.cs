// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonDistanceZoneEvents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("zone");
            writer.WriteObjectValue(Zone);
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events");
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonDistanceZoneEvents DeserializeSpatialAnalysisPersonDistanceZoneEvents(JsonElement element)
        {
            NamedPolygonBase zone = default;
            Optional<IList<SpatialAnalysisPersonDistanceEvent>> events = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"))
                {
                    zone = NamedPolygonBase.DeserializeNamedPolygonBase(property.Value);
                    continue;
                }
                if (property.NameEquals("events"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SpatialAnalysisPersonDistanceEvent> array = new List<SpatialAnalysisPersonDistanceEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonDistanceEvent.DeserializeSpatialAnalysisPersonDistanceEvent(item));
                    }
                    events = array;
                    continue;
                }
            }
            return new SpatialAnalysisPersonDistanceZoneEvents(zone, Optional.ToList(events));
        }
    }
}
