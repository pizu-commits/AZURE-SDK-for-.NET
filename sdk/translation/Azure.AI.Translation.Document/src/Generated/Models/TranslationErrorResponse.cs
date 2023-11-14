// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary>
    /// Contains unified error information used for HTTP responses across any Cognitive Service. Instances
    /// can be created either through Microsoft.CloudAI.Containers.HttpStatusExceptionV2 or by returning it directly from
    /// a controller.
    /// </summary>
    internal partial class TranslationErrorResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TranslationErrorResponse"/>. </summary>
        internal TranslationErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TranslationErrorResponse"/>. </summary>
        /// <param name="error"> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslationErrorResponse(TranslationError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </summary>
        public TranslationError Error { get; }
    }
}
