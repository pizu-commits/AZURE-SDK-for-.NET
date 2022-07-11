// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class LiveEventPreview : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints");
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AccessControl))
            {
                writer.WritePropertyName("accessControl");
                writer.WriteObjectValue(AccessControl);
            }
            if (Optional.IsDefined(PreviewLocator))
            {
                writer.WritePropertyName("previewLocator");
                writer.WriteStringValue(PreviewLocator);
            }
            if (Optional.IsDefined(StreamingPolicyName))
            {
                writer.WritePropertyName("streamingPolicyName");
                writer.WriteStringValue(StreamingPolicyName);
            }
            if (Optional.IsDefined(AlternativeMediaId))
            {
                writer.WritePropertyName("alternativeMediaId");
                writer.WriteStringValue(AlternativeMediaId);
            }
            writer.WriteEndObject();
        }

        internal static LiveEventPreview DeserializeLiveEventPreview(JsonElement element)
        {
            Optional<IList<LiveEventEndpoint>> endpoints = default;
            Optional<LiveEventPreviewAccessControl> accessControl = default;
            Optional<string> previewLocator = default;
            Optional<string> streamingPolicyName = default;
            Optional<string> alternativeMediaId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LiveEventEndpoint> array = new List<LiveEventEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LiveEventEndpoint.DeserializeLiveEventEndpoint(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("accessControl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accessControl = LiveEventPreviewAccessControl.DeserializeLiveEventPreviewAccessControl(property.Value);
                    continue;
                }
                if (property.NameEquals("previewLocator"))
                {
                    previewLocator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamingPolicyName"))
                {
                    streamingPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alternativeMediaId"))
                {
                    alternativeMediaId = property.Value.GetString();
                    continue;
                }
            }
            return new LiveEventPreview(Optional.ToList(endpoints), accessControl.Value, previewLocator.Value, streamingPolicyName.Value, alternativeMediaId.Value);
        }
    }
}
