// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The streaming endpoint sku. </summary>
    internal partial class StreamingEndpointSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointSku"/>. </summary>
        internal StreamingEndpointSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointSku"/>. </summary>
        /// <param name="name"> The streaming endpoint sku name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingEndpointSku(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The streaming endpoint sku name. </summary>
        public string Name { get; }
    }
}
