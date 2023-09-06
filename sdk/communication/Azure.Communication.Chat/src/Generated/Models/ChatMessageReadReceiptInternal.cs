// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> A chat message read receipt indicates the time a chat message was read by a recipient. </summary>
    internal partial class ChatMessageReadReceiptInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ChatMessageReadReceiptInternal"/>. </summary>
        /// <param name="senderCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model must be interpreted as a union: Apart from rawId, at most one further property may be set. </param>
        /// <param name="chatMessageId"> Id of the chat message that has been read. This id is generated by the server. </param>
        /// <param name="readOn"> The time at which the message was read. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="senderCommunicationIdentifier"/> or <paramref name="chatMessageId"/> is null. </exception>
        internal ChatMessageReadReceiptInternal(CommunicationIdentifierModel senderCommunicationIdentifier, string chatMessageId, DateTimeOffset readOn)
        {
            Argument.AssertNotNull(senderCommunicationIdentifier, nameof(senderCommunicationIdentifier));
            Argument.AssertNotNull(chatMessageId, nameof(chatMessageId));

            SenderCommunicationIdentifier = senderCommunicationIdentifier;
            ChatMessageId = chatMessageId;
            ReadOn = readOn;
        }

        /// <summary> Initializes a new instance of <see cref="ChatMessageReadReceiptInternal"/>. </summary>
        /// <param name="senderCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model must be interpreted as a union: Apart from rawId, at most one further property may be set. </param>
        /// <param name="chatMessageId"> Id of the chat message that has been read. This id is generated by the server. </param>
        /// <param name="readOn"> The time at which the message was read. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatMessageReadReceiptInternal(CommunicationIdentifierModel senderCommunicationIdentifier, string chatMessageId, DateTimeOffset readOn, Dictionary<string, BinaryData> rawData)
        {
            SenderCommunicationIdentifier = senderCommunicationIdentifier;
            ChatMessageId = chatMessageId;
            ReadOn = readOn;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatMessageReadReceiptInternal"/> for deserialization. </summary>
        internal ChatMessageReadReceiptInternal()
        {
        }

        /// <summary> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model must be interpreted as a union: Apart from rawId, at most one further property may be set. </summary>
        public CommunicationIdentifierModel SenderCommunicationIdentifier { get; }
        /// <summary> Id of the chat message that has been read. This id is generated by the server. </summary>
        public string ChatMessageId { get; }
        /// <summary> The time at which the message was read. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset ReadOn { get; }
    }
}
