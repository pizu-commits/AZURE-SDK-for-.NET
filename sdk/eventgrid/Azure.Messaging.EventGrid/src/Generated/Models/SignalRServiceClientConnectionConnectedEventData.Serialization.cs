// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(SignalRServiceClientConnectionConnectedEventDataConverter))]
    public partial class SignalRServiceClientConnectionConnectedEventData
    {
        internal static SignalRServiceClientConnectionConnectedEventData DeserializeSignalRServiceClientConnectionConnectedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            string hubName = default;
            string connectionId = default;
            string userId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionId"u8))
                {
                    connectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
            }
            return new SignalRServiceClientConnectionConnectedEventData(timestamp, hubName, connectionId, userId);
        }

        internal partial class SignalRServiceClientConnectionConnectedEventDataConverter : JsonConverter<SignalRServiceClientConnectionConnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, SignalRServiceClientConnectionConnectedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override SignalRServiceClientConnectionConnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSignalRServiceClientConnectionConnectedEventData(document.RootElement);
            }
        }
    }
}
