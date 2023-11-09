// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for creating the call. </summary>
    internal partial class CreateCallRequestInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateCallRequestInternal"/>. </summary>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targets"/> or <paramref name="callbackUri"/> is null. </exception>
        public CreateCallRequestInternal(IEnumerable<CommunicationIdentifierModel> targets, string callbackUri)
        {
            Argument.AssertNotNull(targets, nameof(targets));
            Argument.AssertNotNull(callbackUri, nameof(callbackUri));

            Targets = targets.ToList();
            CallbackUri = callbackUri;
        }

        /// <summary> Initializes a new instance of <see cref="CreateCallRequestInternal"/>. </summary>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="sourceCallerIdNumber">
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </param>
        /// <param name="sourceDisplayName"> Display name of the call if dialing out to a pstn number. </param>
        /// <param name="sourceIdentity"> The identifier of the source of the call. </param>
        /// <param name="operationContext"> A customer set value used to track the answering of a call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="mediaStreamingConfiguration"> Media Streaming Configuration. </param>
        /// <param name="transcriptionConfiguration"> Live Transcription Configuration. </param>
        /// <param name="azureCognitiveServicesEndpointUrl"> The identifier of the Cognitive Service resource assigned to this call. </param>
        /// <param name="customContext"> Used by customer to send custom context to targets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateCallRequestInternal(IList<CommunicationIdentifierModel> targets, PhoneNumberIdentifierModel sourceCallerIdNumber, string sourceDisplayName, CommunicationUserIdentifierModel sourceIdentity, string operationContext, string callbackUri, MediaStreamingOptionsInternal mediaStreamingConfiguration, TranscriptionOptionsInternal transcriptionConfiguration, string azureCognitiveServicesEndpointUrl, CustomContextInternal customContext, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Targets = targets;
            SourceCallerIdNumber = sourceCallerIdNumber;
            SourceDisplayName = sourceDisplayName;
            SourceIdentity = sourceIdentity;
            OperationContext = operationContext;
            CallbackUri = callbackUri;
            MediaStreamingConfiguration = mediaStreamingConfiguration;
            TranscriptionConfiguration = transcriptionConfiguration;
            AzureCognitiveServicesEndpointUrl = azureCognitiveServicesEndpointUrl;
            CustomContext = customContext;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateCallRequestInternal"/> for deserialization. </summary>
        internal CreateCallRequestInternal()
        {
        }

        /// <summary> The targets of the call. </summary>
        public IList<CommunicationIdentifierModel> Targets { get; }
        /// <summary>
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </summary>
        public PhoneNumberIdentifierModel SourceCallerIdNumber { get; set; }
        /// <summary> Display name of the call if dialing out to a pstn number. </summary>
        public string SourceDisplayName { get; set; }
        /// <summary> The identifier of the source of the call. </summary>
        public CommunicationUserIdentifierModel SourceIdentity { get; set; }
        /// <summary> A customer set value used to track the answering of a call. </summary>
        public string OperationContext { get; set; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> Media Streaming Configuration. </summary>
        public MediaStreamingOptionsInternal MediaStreamingConfiguration { get; set; }
        /// <summary> Live Transcription Configuration. </summary>
        public TranscriptionOptionsInternal TranscriptionConfiguration { get; set; }
        /// <summary> The identifier of the Cognitive Service resource assigned to this call. </summary>
        public string AzureCognitiveServicesEndpointUrl { get; set; }
        /// <summary> Used by customer to send custom context to targets. </summary>
        public CustomContextInternal CustomContext { get; set; }
    }
}
