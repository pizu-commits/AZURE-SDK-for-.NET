// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ACSChatMessageEventBaseProperties
    {
        internal static ACSChatMessageEventBaseProperties DeserializeACSChatMessageEventBaseProperties(JsonElement element)
        {
            Optional<string> messageId = default;
            Optional<string> senderId = default;
            Optional<string> senderDisplayName = default;
            Optional<DateTimeOffset> composeTime = default;
            Optional<string> type = default;
            Optional<int> version = default;
            Optional<string> recipientId = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderId"))
                {
                    senderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderDisplayName"))
                {
                    senderDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("composeTime"))
                {
                    composeTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recipientId"))
                {
                    recipientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionId"))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new ACSChatMessageEventBaseProperties(recipientId.Value, transactionId.Value, threadId.Value, messageId.Value, senderId.Value, senderDisplayName.Value, Optional.ToNullable(composeTime), type.Value, Optional.ToNullable(version));
        }
    }
}
