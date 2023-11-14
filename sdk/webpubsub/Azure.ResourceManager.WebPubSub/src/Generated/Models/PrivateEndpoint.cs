// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Private endpoint. </summary>
    internal partial class PrivateEndpoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpoint"/>. </summary>
        public PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpoint"/>. </summary>
        /// <param name="id"> Full qualified Id of the private endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpoint(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Full qualified Id of the private endpoint. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
