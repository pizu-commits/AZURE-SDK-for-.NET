// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaLiveEventIncomingDataChunkDroppedEventDataConverter))]
    public partial class MediaLiveEventIncomingDataChunkDroppedEventData
    {
        internal static MediaLiveEventIncomingDataChunkDroppedEventData DeserializeMediaLiveEventIncomingDataChunkDroppedEventData(JsonElement element)
        {
            Optional<string> timestamp = default;
            Optional<string> trackType = default;
            Optional<long> bitrate = default;
            Optional<string> timescale = default;
            Optional<string> resultCode = default;
            Optional<string> trackName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackType"))
                {
                    trackType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bitrate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bitrate = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("timescale"))
                {
                    timescale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultCode"))
                {
                    resultCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackName"))
                {
                    trackName = property.Value.GetString();
                    continue;
                }
            }
            return new MediaLiveEventIncomingDataChunkDroppedEventData(timestamp.Value, trackType.Value, Optional.ToNullable(bitrate), timescale.Value, resultCode.Value, trackName.Value);
        }

        internal partial class MediaLiveEventIncomingDataChunkDroppedEventDataConverter : JsonConverter<MediaLiveEventIncomingDataChunkDroppedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventIncomingDataChunkDroppedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MediaLiveEventIncomingDataChunkDroppedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventIncomingDataChunkDroppedEventData(document.RootElement);
            }
        }
    }
}
