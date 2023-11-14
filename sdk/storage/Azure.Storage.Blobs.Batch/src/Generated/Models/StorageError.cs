// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Batch.Models
{
    /// <summary> The StorageError. </summary>
    internal partial class StorageError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageError"/>. </summary>
        internal StorageError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageError"/>. </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageError(string message, string code, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            Code = code;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
    }
}
