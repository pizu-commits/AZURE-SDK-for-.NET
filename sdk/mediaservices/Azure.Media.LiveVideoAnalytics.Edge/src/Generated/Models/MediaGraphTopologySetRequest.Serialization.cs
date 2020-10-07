// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class MediaGraphTopologySetRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("graph");
            writer.WriteObjectValue(Graph);
            writer.WriteEndObject();
        }

        internal static MediaGraphTopologySetRequest DeserializeMediaGraphTopologySetRequest(JsonElement element)
        {
            MediaGraphTopology graph = default;
            Optional<string> methodName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("graph"))
                {
                    graph = MediaGraphTopology.DeserializeMediaGraphTopology(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphTopologySetRequest(methodName.Value, graph);
        }
    }
}
