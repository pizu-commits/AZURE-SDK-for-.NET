// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The AddParticipantsResponse. </summary>
    internal partial class AddParticipantsResponseInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AddParticipantsResponseInternal"/>. </summary>
        internal AddParticipantsResponseInternal()
        {
            Participants = new ChangeTrackingList<AcsCallParticipantInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="AddParticipantsResponseInternal"/>. </summary>
        /// <param name="participants"></param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AddParticipantsResponseInternal(IReadOnlyList<AcsCallParticipantInternal> participants, string operationContext, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Participants = participants;
            OperationContext = operationContext;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the participants. </summary>
        public IReadOnlyList<AcsCallParticipantInternal> Participants { get; }
        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
