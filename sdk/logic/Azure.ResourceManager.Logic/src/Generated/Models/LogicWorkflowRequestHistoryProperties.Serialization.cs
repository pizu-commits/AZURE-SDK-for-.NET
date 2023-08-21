// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRequestHistoryProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Core.Optional.IsDefined(Request))
            {
                writer.WritePropertyName("request"u8);
                writer.WriteObjectValue(Request);
            }
            if (Core.Optional.IsDefined(Response))
            {
                writer.WritePropertyName("response"u8);
                writer.WriteObjectValue(Response);
            }
            writer.WriteEndObject();
        }

        internal static LogicWorkflowRequestHistoryProperties DeserializeLogicWorkflowRequestHistoryProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<DateTimeOffset> endTime = default;
            Core.Optional<LogicWorkflowRequest> request = default;
            Core.Optional<LogicWorkflowResponse> response = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("request"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    request = LogicWorkflowRequest.DeserializeLogicWorkflowRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = LogicWorkflowResponse.DeserializeLogicWorkflowResponse(property.Value);
                    continue;
                }
            }
            return new LogicWorkflowRequestHistoryProperties(Core.Optional.ToNullable(startTime), Core.Optional.ToNullable(endTime), request.Value, response.Value);
        }
    }
}
