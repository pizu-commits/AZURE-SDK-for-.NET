// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The PlayCanceled. </summary>
    public partial class PlayCanceled
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PlayCanceled"/>. </summary>
        internal PlayCanceled()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PlayCanceled"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PlayCanceled(string callConnectionId, string serverCallId, string correlationId, string operationContext, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
