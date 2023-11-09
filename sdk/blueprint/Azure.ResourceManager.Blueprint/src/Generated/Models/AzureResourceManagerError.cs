// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Error code and message. </summary>
    public partial class AzureResourceManagerError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureResourceManagerError"/>. </summary>
        public AzureResourceManagerError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureResourceManagerError"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureResourceManagerError(string code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Error code. </summary>
        public string Code { get; set; }
        /// <summary> Error message. </summary>
        public string Message { get; set; }
    }
}
