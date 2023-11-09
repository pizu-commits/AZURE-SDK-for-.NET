// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload for rejecting the call. </summary>
    internal partial class RejectCallRequestInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RejectCallRequestInternal"/>. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="incomingCallContext"/> is null. </exception>
        public RejectCallRequestInternal(string incomingCallContext)
        {
            Argument.AssertNotNull(incomingCallContext, nameof(incomingCallContext));

            IncomingCallContext = incomingCallContext;
        }

        /// <summary> Initializes a new instance of <see cref="RejectCallRequestInternal"/>. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="callRejectReason"> The rejection reason. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RejectCallRequestInternal(string incomingCallContext, CallRejectReason? callRejectReason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IncomingCallContext = incomingCallContext;
            CallRejectReason = callRejectReason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RejectCallRequestInternal"/> for deserialization. </summary>
        internal RejectCallRequestInternal()
        {
        }

        /// <summary> The context associated with the call. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The rejection reason. </summary>
        public CallRejectReason? CallRejectReason { get; set; }
    }
}
