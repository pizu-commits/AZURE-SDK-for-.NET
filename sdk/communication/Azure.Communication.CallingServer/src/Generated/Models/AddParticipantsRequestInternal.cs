// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The AddParticipantsRequest. </summary>
    internal partial class AddParticipantsRequestInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AddParticipantsRequestInternal"/>. </summary>
        /// <param name="participantsToAdd"> The participants to invite. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participantsToAdd"/> is null. </exception>
        public AddParticipantsRequestInternal(IEnumerable<CommunicationIdentifierModel> participantsToAdd)
        {
            Argument.AssertNotNull(participantsToAdd, nameof(participantsToAdd));

            ParticipantsToAdd = participantsToAdd.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AddParticipantsRequestInternal"/>. </summary>
        /// <param name="sourceCallerId"> The source caller Id that's shown to the PSTN participant being invited. Required only when inviting a PSTN participant. </param>
        /// <param name="participantsToAdd"> The participants to invite. </param>
        /// <param name="invitationTimeoutInSeconds">
        /// Gets or sets the timeout to wait for the invited participant to pickup.
        /// The maximum value of this is 180 seconds
        /// </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AddParticipantsRequestInternal(PhoneNumberIdentifierModel sourceCallerId, IList<CommunicationIdentifierModel> participantsToAdd, int? invitationTimeoutInSeconds, string operationContext, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceCallerId = sourceCallerId;
            ParticipantsToAdd = participantsToAdd;
            InvitationTimeoutInSeconds = invitationTimeoutInSeconds;
            OperationContext = operationContext;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AddParticipantsRequestInternal"/> for deserialization. </summary>
        internal AddParticipantsRequestInternal()
        {
        }

        /// <summary> The source caller Id that's shown to the PSTN participant being invited. Required only when inviting a PSTN participant. </summary>
        public PhoneNumberIdentifierModel SourceCallerId { get; set; }
        /// <summary> The participants to invite. </summary>
        public IList<CommunicationIdentifierModel> ParticipantsToAdd { get; }
        /// <summary>
        /// Gets or sets the timeout to wait for the invited participant to pickup.
        /// The maximum value of this is 180 seconds
        /// </summary>
        public int? InvitationTimeoutInSeconds { get; set; }
        /// <summary> The operation context. </summary>
        public string OperationContext { get; set; }
    }
}
