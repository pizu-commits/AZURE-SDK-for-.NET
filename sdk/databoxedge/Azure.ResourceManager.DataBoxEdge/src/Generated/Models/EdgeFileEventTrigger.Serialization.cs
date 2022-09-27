// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeFileEventTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("sourceInfo");
            writer.WriteObjectValue(SourceInfo);
            writer.WritePropertyName("sinkInfo");
            writer.WriteObjectValue(SinkInfo);
            if (Optional.IsDefined(CustomContextTag))
            {
                writer.WritePropertyName("customContextTag");
                writer.WriteStringValue(CustomContextTag);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EdgeFileEventTrigger DeserializeEdgeFileEventTrigger(JsonElement element)
        {
            TriggerEventType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            EdgeFileSourceInfo sourceInfo = default;
            DataBoxEdgeRoleSinkInfo sinkInfo = default;
            Optional<string> customContextTag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new TriggerEventType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceInfo"))
                        {
                            sourceInfo = EdgeFileSourceInfo.DeserializeEdgeFileSourceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sinkInfo"))
                        {
                            sinkInfo = DataBoxEdgeRoleSinkInfo.DeserializeDataBoxEdgeRoleSinkInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customContextTag"))
                        {
                            customContextTag = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EdgeFileEventTrigger(id, name, type, systemData.Value, kind, sourceInfo, sinkInfo, customContextTag.Value);
        }
    }
}
