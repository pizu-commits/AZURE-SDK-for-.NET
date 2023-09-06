// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary> The RemoveParticipantsResponse. </summary>
    public partial class RemoveParticipantsResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantsResult"/>. </summary>
        internal RemoveParticipantsResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantsResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoveParticipantsResult(string operationContext, Dictionary<string, BinaryData> rawData)
        {
            OperationContext = operationContext;
            _rawData = rawData;
        }

        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
