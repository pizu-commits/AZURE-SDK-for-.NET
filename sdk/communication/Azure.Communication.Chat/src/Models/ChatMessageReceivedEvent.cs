// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Azure.Communication.Chat.Models
{
    /// <summary>
    ///  Event for a received chat message.
    ///  All chat participants receive this event, including the original sender.
    /// </summary>
    public class ChatMessageReceivedEvent : ChatEvent
    {
        /// <summary>
        /// Type of the chat message.
        /// </summary>
        [JsonPropertyName("type")]
        public ChatMessageType Type => MessageType;

        /// <summary>
        /// Content of the message.
        /// </summary>
        [JsonPropertyName("messageBody")]
        public string Content { get; }

        /// <summary>
        /// Priority of the message. Possible values include: 'Normal', 'High'
        /// </summary>
        [JsonPropertyName("priority")]
        public string Priority { get; }

        /// <summary>
        /// The Id of the message. This Id is server generated.
        /// </summary>
        [JsonPropertyName("messageId")]
        public string Id { get; }

        /// <summary>
        /// The display name of the event sender.
        /// </summary>
        [JsonPropertyName("senderDisplayName")]
        public string SenderDisplayName { get; }

        /// <summary>
        ///  The timestamp when the message arrived at the server. The timestamp is in RFC3339 format:
        /// `yyyy-MM-ddTHH:mm:ssZ`.
        /// </summary>
        [JsonPropertyName("originalArrivalTime")]
        public DateTimeOffset CreatedOn { get; }

        /// <summary>
        ///  Version of the message. This version is an epoch time in a numeric unsigned Int64 format:
        /// `1593117207131`
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; }

        /// <summary>
        /// Message metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public IReadOnlyDictionary<string, string> Metadata => AcsChatMessageMetadata;

        /// <summary>
        /// Original Type of the chat message.
        /// </summary>
        [JsonPropertyName("messageType")]
        private ChatMessageType MessageType { get; }

        /// <summary>
        /// Message metadata.
        /// </summary>
        [JsonPropertyName("acsChatMessageMetadata")]
        public IReadOnlyDictionary<string, string> AcsChatMessageMetadata { get; }
    }
}
