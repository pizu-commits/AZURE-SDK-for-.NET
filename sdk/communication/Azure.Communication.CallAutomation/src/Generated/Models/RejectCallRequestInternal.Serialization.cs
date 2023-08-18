// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class RejectCallRequestInternal : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("incomingCallContext"u8);
            writer.WriteStringValue(IncomingCallContext);
            if (Core.Optional.IsDefined(CallRejectReason))
            {
                writer.WritePropertyName("callRejectReason"u8);
                writer.WriteStringValue(CallRejectReason.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
