// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(HealthcareDicomImageDeletedEventDataConverter))]
    public partial class HealthcareDicomImageDeletedEventData
    {
        internal static HealthcareDicomImageDeletedEventData DeserializeHealthcareDicomImageDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partitionName = default;
            string imageStudyInstanceUid = default;
            string imageSeriesInstanceUid = default;
            string imageSopInstanceUid = default;
            string serviceHostName = default;
            long? sequenceNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionName"u8))
                {
                    partitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageStudyInstanceUid"u8))
                {
                    imageStudyInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSeriesInstanceUid"u8))
                {
                    imageSeriesInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSopInstanceUid"u8))
                {
                    imageSopInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceHostName"u8))
                {
                    serviceHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
            }
            return new HealthcareDicomImageDeletedEventData(
                partitionName,
                imageStudyInstanceUid,
                imageSeriesInstanceUid,
                imageSopInstanceUid,
                serviceHostName,
                sequenceNumber);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HealthcareDicomImageDeletedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHealthcareDicomImageDeletedEventData(document.RootElement);
        }

        internal partial class HealthcareDicomImageDeletedEventDataConverter : JsonConverter<HealthcareDicomImageDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareDicomImageDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override HealthcareDicomImageDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareDicomImageDeletedEventData(document.RootElement);
            }
        }
    }
}
