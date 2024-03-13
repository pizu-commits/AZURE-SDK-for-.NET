// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsSmsReceivedEventDataConverter))]
    public partial class AcsSmsReceivedEventData
    {
        internal static AcsSmsReceivedEventData DeserializeAcsSmsReceivedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string message = default;
            DateTimeOffset? receivedTimestamp = default;
            string messageId = default;
            string @from = default;
            string to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receivedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    receivedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
            }
            return new AcsSmsReceivedEventData(messageId, @from, to, message, receivedTimestamp);
        }

        internal partial class AcsSmsReceivedEventDataConverter : JsonConverter<AcsSmsReceivedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsSmsReceivedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsSmsReceivedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsSmsReceivedEventData(document.RootElement);
            }
        }
    }
}
