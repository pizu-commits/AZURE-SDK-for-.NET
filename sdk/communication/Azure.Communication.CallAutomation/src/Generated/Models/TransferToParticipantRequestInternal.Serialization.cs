// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class TransferToParticipantRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetParticipant"u8);
            writer.WriteObjectValue(TargetParticipant);
            if (Optional.IsDefined(CustomCallingContext))
            {
                writer.WritePropertyName("customCallingContext"u8);
                writer.WriteObjectValue(CustomCallingContext);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(Transferee))
            {
                writer.WritePropertyName("transferee"u8);
                writer.WriteObjectValue(Transferee);
            }
            if (Optional.IsDefined(OperationCallbackUri))
            {
                writer.WritePropertyName("operationCallbackUri"u8);
                writer.WriteStringValue(OperationCallbackUri);
            }
            if (Optional.IsDefined(SourceCallerIdNumber))
            {
                writer.WritePropertyName("sourceCallerIdNumber"u8);
                writer.WriteObjectValue(SourceCallerIdNumber);
            }
            writer.WriteEndObject();
        }
    }
}
