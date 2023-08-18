// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class TransferToParticipantRequestInternal : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetParticipant"u8);
            writer.WriteObjectValue(TargetParticipant);
            if (Core.Optional.IsDefined(CustomContext))
            {
                writer.WritePropertyName("customContext"u8);
                writer.WriteObjectValue(CustomContext);
            }
            if (Core.Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (Core.Optional.IsDefined(Transferee))
            {
                writer.WritePropertyName("transferee"u8);
                writer.WriteObjectValue(Transferee);
            }
            if (Core.Optional.IsDefined(CallbackUri))
            {
                writer.WritePropertyName("callbackUri"u8);
                writer.WriteStringValue(CallbackUri);
            }
            writer.WriteEndObject();
        }
    }
}
