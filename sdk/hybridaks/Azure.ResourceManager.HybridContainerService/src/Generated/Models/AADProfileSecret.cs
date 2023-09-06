// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The server AAD application secret. </summary>
    public partial class AADProfileSecret
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AADProfileSecret"/>. </summary>
        public AADProfileSecret()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AADProfileSecret"/>. </summary>
        /// <param name="serverAppSecret"> The server AAD application secret. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AADProfileSecret(string serverAppSecret, Dictionary<string, BinaryData> rawData)
        {
            ServerAppSecret = serverAppSecret;
            _rawData = rawData;
        }

        /// <summary> The server AAD application secret. </summary>
        public string ServerAppSecret { get; set; }
    }
}
