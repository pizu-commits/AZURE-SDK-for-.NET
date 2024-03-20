// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowDebugResultResponseConverter))]
    public partial class DataFlowDebugResultResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStringValue(Data);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowDebugResultResponse DeserializeDataFlowDebugResultResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            string data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    data = property.Value.GetString();
                    continue;
                }
            }
            return new DataFlowDebugResultResponse(status, data);
        }

        internal partial class DataFlowDebugResultResponseConverter : JsonConverter<DataFlowDebugResultResponse>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugResultResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugResultResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugResultResponse(document.RootElement);
            }
        }
    }
}
