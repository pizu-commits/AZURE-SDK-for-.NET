// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for transferring call to a participant. </summary>
    internal partial class TransferToParticipantRequestInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TransferToParticipantRequestInternal"/>. </summary>
        /// <param name="targetParticipant"> The identity of the target where call should be transferred to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipant"/> is null. </exception>
        public TransferToParticipantRequestInternal(CommunicationIdentifierModel targetParticipant)
        {
            Argument.AssertNotNull(targetParticipant, nameof(targetParticipant));

            TargetParticipant = targetParticipant;
        }

        /// <summary> Initializes a new instance of <see cref="TransferToParticipantRequestInternal"/>. </summary>
        /// <param name="targetParticipant"> The identity of the target where call should be transferred to. </param>
        /// <param name="customContext"> Used by customer to send custom context to targets. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="transferee"> Transferee is the participant who is transferring the call. </param>
        /// <param name="callbackUri"> The callback URI to override the main callback URI. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TransferToParticipantRequestInternal(CommunicationIdentifierModel targetParticipant, CustomContextInternal customContext, string operationContext, CommunicationIdentifierModel transferee, string callbackUri, Dictionary<string, BinaryData> rawData)
        {
            TargetParticipant = targetParticipant;
            CustomContext = customContext;
            OperationContext = operationContext;
            Transferee = transferee;
            CallbackUri = callbackUri;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TransferToParticipantRequestInternal"/> for deserialization. </summary>
        internal TransferToParticipantRequestInternal()
        {
        }

        /// <summary> The identity of the target where call should be transferred to. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> Used by customer to send custom context to targets. </summary>
        public CustomContextInternal CustomContext { get; set; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary> Transferee is the participant who is transferring the call. </summary>
        public CommunicationIdentifierModel Transferee { get; set; }
        /// <summary> The callback URI to override the main callback URI. </summary>
        public string CallbackUri { get; set; }
    }
}
