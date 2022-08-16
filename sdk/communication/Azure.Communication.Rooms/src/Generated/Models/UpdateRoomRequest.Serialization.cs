// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    internal partial class UpdateRoomRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ValidFrom))
            {
                writer.WritePropertyName("validFrom");
                writer.WriteStringValue(ValidFrom.Value, "O");
            }
            if (Optional.IsDefined(ValidUntil))
            {
                writer.WritePropertyName("validUntil");
                writer.WriteStringValue(ValidUntil.Value, "O");
            }
            if (Optional.IsDefined(RoomJoinPolicy))
            {
                writer.WritePropertyName("roomJoinPolicy");
                writer.WriteStringValue(RoomJoinPolicy.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Participants))
            {
                writer.WritePropertyName("participants");
                writer.WriteStartArray();
                foreach (var item in Participants)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
