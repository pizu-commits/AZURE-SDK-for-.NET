// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The locator used for joining or taking action on a call. </summary>
    internal partial class CallLocatorInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CallLocatorInternal"/>. </summary>
        public CallLocatorInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CallLocatorInternal"/>. </summary>
        /// <param name="groupCallId"> The group call id. </param>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="kind"> The call locator kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CallLocatorInternal(string groupCallId, string serverCallId, CallLocatorKindInternal? kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GroupCallId = groupCallId;
            ServerCallId = serverCallId;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The group call id. </summary>
        public string GroupCallId { get; set; }
        /// <summary> The server call id. </summary>
        public string ServerCallId { get; set; }
        /// <summary> The call locator kind. </summary>
        public CallLocatorKindInternal? Kind { get; set; }
    }
}
