// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for GetConnectionSharedKey API service call. </summary>
    public partial class ConnectionSharedKey : NetworkSubResource
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionSharedKey"/>. </summary>
        /// <param name="value"> The virtual network connection shared key value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionSharedKey(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionSharedKey"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> The virtual network connection shared key value. </param>
        internal ConnectionSharedKey(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData, string value) : base(id, serializedAdditionalRawData)
        {
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionSharedKey"/> for deserialization. </summary>
        internal ConnectionSharedKey()
        {
        }

        /// <summary> The virtual network connection shared key value. </summary>
        public string Value { get; set; }
    }
}
