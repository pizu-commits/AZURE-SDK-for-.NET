// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Get User Token response details. </summary>
    public partial class UserTokenResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UserTokenResult"/>. </summary>
        internal UserTokenResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UserTokenResult"/>. </summary>
        /// <param name="value"> Shared Access Authorization token for the User. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserTokenResult(string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Shared Access Authorization token for the User. </summary>
        public string Value { get; }
    }
}
