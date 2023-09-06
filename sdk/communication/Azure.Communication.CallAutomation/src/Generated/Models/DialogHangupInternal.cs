// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.CallAutomation;

namespace Azure.Communication.CallAutomation.Models.Events
{
    /// <summary> The DialogHangup. </summary>
    internal partial class DialogHangupInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DialogHangupInternal"/>. </summary>
        internal DialogHangupInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DialogHangupInternal"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling answerCall action to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="dialogInputType"> Determines the type of the dialog. </param>
        /// <param name="dialogId"> Dialog ID. </param>
        /// <param name="ivrContext"> Ivr Context. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DialogHangupInternal(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation, DialogInputType? dialogInputType, string dialogId, object ivrContext, Dictionary<string, BinaryData> rawData)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            DialogInputType = dialogInputType;
            DialogId = dialogId;
            IvrContext = ivrContext;
            _rawData = rawData;
        }

        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Used by customers when calling answerCall action to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code/sub-code and message from NGC services. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Determines the type of the dialog. </summary>
        public DialogInputType? DialogInputType { get; }
        /// <summary> Dialog ID. </summary>
        public string DialogId { get; }
        /// <summary> Ivr Context. </summary>
        public object IvrContext { get; }
    }
}
