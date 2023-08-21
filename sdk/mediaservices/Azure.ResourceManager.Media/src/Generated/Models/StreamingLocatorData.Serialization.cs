// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class StreamingLocatorData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AssetName))
            {
                writer.WritePropertyName("assetName"u8);
                writer.WriteStringValue(AssetName);
            }
            if (Core.Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Core.Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Core.Optional.IsDefined(StreamingLocatorId))
            {
                writer.WritePropertyName("streamingLocatorId"u8);
                writer.WriteStringValue(StreamingLocatorId.Value);
            }
            if (Core.Optional.IsDefined(StreamingPolicyName))
            {
                writer.WritePropertyName("streamingPolicyName"u8);
                writer.WriteStringValue(StreamingPolicyName);
            }
            if (Core.Optional.IsDefined(DefaultContentKeyPolicyName))
            {
                writer.WritePropertyName("defaultContentKeyPolicyName"u8);
                writer.WriteStringValue(DefaultContentKeyPolicyName);
            }
            if (Core.Optional.IsCollectionDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys"u8);
                writer.WriteStartArray();
                foreach (var item in ContentKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(AlternativeMediaId))
            {
                writer.WritePropertyName("alternativeMediaId"u8);
                writer.WriteStringValue(AlternativeMediaId);
            }
            if (Core.Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StreamingLocatorData DeserializeStreamingLocatorData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> assetName = default;
            Core.Optional<DateTimeOffset> created = default;
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<DateTimeOffset> endTime = default;
            Core.Optional<Guid> streamingLocatorId = default;
            Core.Optional<string> streamingPolicyName = default;
            Core.Optional<string> defaultContentKeyPolicyName = default;
            Core.Optional<IList<StreamingLocatorContentKey>> contentKeys = default;
            Core.Optional<string> alternativeMediaId = default;
            Core.Optional<IList<string>> filters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("assetName"u8))
                        {
                            assetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("streamingLocatorId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            streamingLocatorId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("streamingPolicyName"u8))
                        {
                            streamingPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultContentKeyPolicyName"u8))
                        {
                            defaultContentKeyPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamingLocatorContentKey> array = new List<StreamingLocatorContentKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamingLocatorContentKey.DeserializeStreamingLocatorContentKey(item));
                            }
                            contentKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("alternativeMediaId"u8))
                        {
                            alternativeMediaId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("filters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            filters = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StreamingLocatorData(id, name, type, systemData.Value, assetName.Value, Core.Optional.ToNullable(created), Core.Optional.ToNullable(startTime), Core.Optional.ToNullable(endTime), Core.Optional.ToNullable(streamingLocatorId), streamingPolicyName.Value, defaultContentKeyPolicyName.Value, Core.Optional.ToList(contentKeys), alternativeMediaId.Value, Core.Optional.ToList(filters));
        }
    }
}
