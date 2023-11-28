// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for adding participant to the call. </summary>
    internal partial class AddParticipantRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="AddParticipantRequestInternal"/>. </summary>
        /// <param name="participantToAdd"> The participant to invite. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participantToAdd"/> is null. </exception>
        public AddParticipantRequestInternal(CommunicationIdentifierModel participantToAdd)
        {
            Argument.AssertNotNull(participantToAdd, nameof(participantToAdd));

            ParticipantToAdd = participantToAdd;
        }

        /// <summary>
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when inviting a PSTN participant.
        /// </summary>
        public PhoneNumberIdentifierModel SourceCallerIdNumber { get; set; }
        /// <summary>
        /// (Optional) The display name of the source that is associated with this invite operation when
        /// adding a PSTN participant or teams user.  Note: Will not update the display name in the roster.
        /// </summary>
        public string SourceDisplayName { get; set; }
        /// <summary> The participant to invite. </summary>
        public CommunicationIdentifierModel ParticipantToAdd { get; }
        /// <summary>
        /// Gets or sets the timeout to wait for the invited participant to pickup.
        /// The maximum value of this is 180 seconds
        /// </summary>
        public int? InvitationTimeoutInSeconds { get; set; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary> Used by customer to send custom context to targets. </summary>
        public CustomContextInternal CustomContext { get; set; }
        /// <summary> The callback URI to override the main callback URI. </summary>
        public string CallbackUri { get; set; }
    }
}
