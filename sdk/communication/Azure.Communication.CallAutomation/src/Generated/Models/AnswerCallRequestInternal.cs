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
    /// <summary> The request payload for answering the call. </summary>
    internal partial class AnswerCallRequestInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnswerCallRequestInternal"/>. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="callbackUri"> The callback uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="incomingCallContext"/> or <paramref name="callbackUri"/> is null. </exception>
        public AnswerCallRequestInternal(string incomingCallContext, string callbackUri)
        {
            Argument.AssertNotNull(incomingCallContext, nameof(incomingCallContext));
            Argument.AssertNotNull(callbackUri, nameof(callbackUri));

            IncomingCallContext = incomingCallContext;
            CallbackUri = callbackUri;
        }

        /// <summary> Initializes a new instance of <see cref="AnswerCallRequestInternal"/>. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="callbackUri"> The callback uri. </param>
        /// <param name="operationContext"> A customer set value used to track the answering of a call. </param>
        /// <param name="mediaStreamingConfiguration"> Media Streaming Configuration. </param>
        /// <param name="azureCognitiveServicesEndpointUrl"> The endpoint URL of the Azure Cognitive Services resource attached. </param>
        /// <param name="answeredByIdentifier"> The identifier of the call automation entity which answers the call. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnswerCallRequestInternal(string incomingCallContext, string callbackUri, string operationContext, MediaStreamingOptionsInternal mediaStreamingConfiguration, string azureCognitiveServicesEndpointUrl, CommunicationUserIdentifierModel answeredByIdentifier, Dictionary<string, BinaryData> rawData)
        {
            IncomingCallContext = incomingCallContext;
            CallbackUri = callbackUri;
            OperationContext = operationContext;
            MediaStreamingConfiguration = mediaStreamingConfiguration;
            AzureCognitiveServicesEndpointUrl = azureCognitiveServicesEndpointUrl;
            AnsweredByIdentifier = answeredByIdentifier;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnswerCallRequestInternal"/> for deserialization. </summary>
        internal AnswerCallRequestInternal()
        {
        }

        /// <summary> The context associated with the call. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The callback uri. </summary>
        public string CallbackUri { get; }
        /// <summary> A customer set value used to track the answering of a call. </summary>
        public string OperationContext { get; set; }
        /// <summary> Media Streaming Configuration. </summary>
        public MediaStreamingOptionsInternal MediaStreamingConfiguration { get; set; }
        /// <summary> The endpoint URL of the Azure Cognitive Services resource attached. </summary>
        public string AzureCognitiveServicesEndpointUrl { get; set; }
        /// <summary> The identifier of the call automation entity which answers the call. </summary>
        public CommunicationUserIdentifierModel AnsweredByIdentifier { get; set; }
    }
}
