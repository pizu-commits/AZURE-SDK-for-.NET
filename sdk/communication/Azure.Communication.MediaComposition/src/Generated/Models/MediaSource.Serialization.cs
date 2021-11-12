// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class MediaSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(SourceType))
            {
                writer.WritePropertyName("sourceType");
                writer.WriteStringValue(SourceType.Value.ToString());
            }
            if (Optional.IsDefined(Participant))
            {
                writer.WritePropertyName("participant");
                writer.WriteObjectValue(Participant);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(MediaInputId))
            {
                writer.WritePropertyName("mediaInputId");
                writer.WriteStringValue(MediaInputId);
            }
            writer.WriteEndObject();
        }

        internal static MediaSource DeserializeMediaSource(JsonElement element)
        {
            Optional<string> description = default;
            Optional<SourceType> sourceType = default;
            Optional<CommunicationUserIdentifierModel> participant = default;
            Optional<string> location = default;
            Optional<string> mediaInputId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceType = new SourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("participant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    participant = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaInputId"))
                {
                    mediaInputId = property.Value.GetString();
                    continue;
                }
            }
            return new MediaSource(description.Value, Optional.ToNullable(sourceType), participant.Value, location.Value, mediaInputId.Value);
        }
    }
}
