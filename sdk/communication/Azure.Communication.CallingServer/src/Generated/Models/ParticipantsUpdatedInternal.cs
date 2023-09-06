// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The ParticipantsUpdatedEvent. </summary>
    internal partial class ParticipantsUpdatedInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ParticipantsUpdatedInternal"/>. </summary>
        internal ParticipantsUpdatedInternal()
        {
            Participants = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantsUpdatedInternal"/>. </summary>
        /// <param name="eventSource"></param>
        /// <param name="participants"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the "type" property in the CloudEvent. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ParticipantsUpdatedInternal(string eventSource, IReadOnlyList<CommunicationIdentifierModel> participants, string version, string operationContext, ResultInformation resultInformation, string callConnectionId, string serverCallId, string correlationId, string publicEventType, Dictionary<string, BinaryData> rawData)
        {
            EventSource = eventSource;
            Participants = participants;
            Version = version;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            PublicEventType = publicEventType;
            _rawData = rawData;
        }

        /// <summary> Gets the event source. </summary>
        public string EventSource { get; }
        /// <summary> Gets the participants. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Participants { get; }
        /// <summary> Used to determine the version of the event. </summary>
        public string Version { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code/sub-code and message from NGC services. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> The public event namespace used as the "type" property in the CloudEvent. </summary>
        public string PublicEventType { get; }
    }
}
