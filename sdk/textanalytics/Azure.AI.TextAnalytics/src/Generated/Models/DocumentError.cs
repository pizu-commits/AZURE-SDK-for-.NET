// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Contains details of errors encountered during a job execution. </summary>
    internal partial class DocumentError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DocumentError"/>. </summary>
        /// <param name="id"> The ID of the input document. </param>
        /// <param name="error"> Error encountered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="error"/> is null. </exception>
        public DocumentError(string id, Error error)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(error, nameof(error));

            Id = id;
            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentError"/>. </summary>
        /// <param name="id"> The ID of the input document. </param>
        /// <param name="error"> Error encountered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentError(string id, Error error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentError"/> for deserialization. </summary>
        internal DocumentError()
        {
        }

        /// <summary> The ID of the input document. </summary>
        public string Id { get; set; }
        /// <summary> Error encountered. </summary>
        public Error Error { get; set; }
    }
}
