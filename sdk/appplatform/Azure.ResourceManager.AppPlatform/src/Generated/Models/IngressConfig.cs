// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Ingress configuration payload for Azure Spring Apps resource. </summary>
    internal partial class IngressConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IngressConfig"/>. </summary>
        public IngressConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IngressConfig"/>. </summary>
        /// <param name="readTimeoutInSeconds"> Ingress read time out in seconds. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IngressConfig(int? readTimeoutInSeconds, Dictionary<string, BinaryData> rawData)
        {
            ReadTimeoutInSeconds = readTimeoutInSeconds;
            _rawData = rawData;
        }

        /// <summary> Ingress read time out in seconds. </summary>
        public int? ReadTimeoutInSeconds { get; set; }
    }
}
