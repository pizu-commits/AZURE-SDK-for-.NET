// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The response payload for getting participants of the call. </summary>
    internal partial class GetParticipantsResponseInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GetParticipantsResponseInternal"/>. </summary>
        internal GetParticipantsResponseInternal()
        {
            Values = new ChangeTrackingList<CallParticipantInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="GetParticipantsResponseInternal"/>. </summary>
        /// <param name="values"> List of the current participants in the call. </param>
        /// <param name="nextLink"> Continue of the list of participants. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetParticipantsResponseInternal(IReadOnlyList<CallParticipantInternal> values, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Values = values;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of the current participants in the call. </summary>
        public IReadOnlyList<CallParticipantInternal> Values { get; }
        /// <summary> Continue of the list of participants. </summary>
        public string NextLink { get; }
    }
}
