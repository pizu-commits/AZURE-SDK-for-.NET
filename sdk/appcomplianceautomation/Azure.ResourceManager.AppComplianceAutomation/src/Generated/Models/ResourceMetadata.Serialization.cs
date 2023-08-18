// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ResourceMetadata : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            if (Core.Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (Core.Optional.IsDefined(ResourceKind))
            {
                writer.WritePropertyName("resourceKind"u8);
                writer.WriteStringValue(ResourceKind);
            }
            if (Core.Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ResourceMetadata DeserializeResourceMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            Core.Optional<string> resourceType = default;
            Core.Optional<string> resourceKind = default;
            Core.Optional<string> resourceName = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceKind"u8))
                {
                    resourceKind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new ResourceMetadata(resourceId, resourceType.Value, resourceKind.Value, resourceName.Value, Core.Optional.ToDictionary(tags));
        }
    }
}
