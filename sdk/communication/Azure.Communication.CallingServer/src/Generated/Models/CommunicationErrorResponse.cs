// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The Communication Services error response. </summary>
    internal partial class CommunicationErrorResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/>. </summary>
        /// <param name="error"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal CommunicationErrorResponse(CommunicationError error)
        {
            Argument.AssertNotNull(error, nameof(error));

            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/>. </summary>
        /// <param name="error"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunicationErrorResponse(CommunicationError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/> for deserialization. </summary>
        internal CommunicationErrorResponse()
        {
        }

        /// <summary> Gets the error. </summary>
        public CommunicationError Error { get; }
    }
}
