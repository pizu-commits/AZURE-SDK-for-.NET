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
    /// <summary> Channel affinity for a participant. </summary>
    internal partial class ChannelAffinityInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChannelAffinityInternal"/>. </summary>
        /// <param name="participant">
        /// The identifier for the participant whose bitstream will be written to the channel
        /// represented by the channel number.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participant"/> is null. </exception>
        public ChannelAffinityInternal(CommunicationIdentifierModel participant)
        {
            Argument.AssertNotNull(participant, nameof(participant));

            Participant = participant;
        }

        /// <summary> Initializes a new instance of <see cref="ChannelAffinityInternal"/>. </summary>
        /// <param name="channel"> Channel number to which bitstream from a particular participant will be written. </param>
        /// <param name="participant">
        /// The identifier for the participant whose bitstream will be written to the channel
        /// represented by the channel number.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChannelAffinityInternal(int? channel, CommunicationIdentifierModel participant, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Channel = channel;
            Participant = participant;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChannelAffinityInternal"/> for deserialization. </summary>
        internal ChannelAffinityInternal()
        {
        }

        /// <summary> Channel number to which bitstream from a particular participant will be written. </summary>
        public int? Channel { get; set; }
        /// <summary>
        /// The identifier for the participant whose bitstream will be written to the channel
        /// represented by the channel number.
        /// </summary>
        public CommunicationIdentifierModel Participant { get; }
    }
}
