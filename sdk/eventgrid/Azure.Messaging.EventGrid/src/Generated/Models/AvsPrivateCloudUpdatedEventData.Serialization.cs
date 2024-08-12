// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AvsPrivateCloudUpdatedEventDataConverter))]
    public partial class AvsPrivateCloudUpdatedEventData
    {
        internal static AvsPrivateCloudUpdatedEventData DeserializeAvsPrivateCloudUpdatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
            }
            return new AvsPrivateCloudUpdatedEventData(operationId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AvsPrivateCloudUpdatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAvsPrivateCloudUpdatedEventData(document.RootElement);
        }

        internal partial class AvsPrivateCloudUpdatedEventDataConverter : JsonConverter<AvsPrivateCloudUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AvsPrivateCloudUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AvsPrivateCloudUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvsPrivateCloudUpdatedEventData(document.RootElement);
            }
        }
    }
}
