// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The failed to remove participant event. </summary>
    internal partial class RemoveParticipantFailedInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantFailedInternal"/>. </summary>
        internal RemoveParticipantFailedInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantFailedInternal"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="participant"> Participant. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoveParticipantFailedInternal(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation, CommunicationIdentifierModel participant, Dictionary<string, BinaryData> rawData)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            Participant = participant;
            _rawData = rawData;
        }

        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code/sub-code and message from NGC services. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Participant. </summary>
        public CommunicationIdentifierModel Participant { get; }
    }
}
