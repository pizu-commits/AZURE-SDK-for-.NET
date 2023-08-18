// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class CallTransferAccepted
    {
        internal static CallTransferAccepted DeserializeCallTransferAccepted(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> eventSource = default;
            Core.Optional<string> operationContext = default;
            Core.Optional<ResultInformation> resultInformation = default;
            Core.Optional<string> version = default;
            Core.Optional<string> callConnectionId = default;
            Core.Optional<string> serverCallId = default;
            Core.Optional<string> correlationId = default;
            Core.Optional<string> publicEventType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventSource"u8))
                {
                    eventSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicEventType"u8))
                {
                    publicEventType = property.Value.GetString();
                    continue;
                }
            }
            return new CallTransferAccepted(eventSource.Value, operationContext.Value, resultInformation.Value, version.Value, callConnectionId.Value, serverCallId.Value, correlationId.Value, publicEventType.Value);
        }
    }
}
