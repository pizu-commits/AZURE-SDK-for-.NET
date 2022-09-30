// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The CallTransferFailedEvent. </summary>
    public partial class CallTransferFailed
    {
        /// <summary> Initializes a new instance of CallTransferFailed. </summary>
        internal CallTransferFailed()
        {
        }

        /// <summary> Initializes a new instance of CallTransferFailed. </summary>
        /// <param name="eventSource"></param>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        internal CallTransferFailed(string eventSource, string operationContext, ResultInformation resultInformation, string version, string callConnectionId, string serverCallId, string correlationId, string publicEventType)
        {
            EventSource = eventSource;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            Version = version;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            PublicEventType = publicEventType;
        }

        /// <summary> Gets the event source. </summary>
        public string EventSource { get; }
        /// <summary> Gets the operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Gets the result information. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Used to determine the version of the event. </summary>
        public string Version { get; }
        /// <summary> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </summary>
        public string PublicEventType { get; }
    }
}
