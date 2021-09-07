// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for GenerateExpressRoutePortsLOA API service call. </summary>
    public partial class GenerateExpressRoutePortsLOAResult
    {
        /// <summary> Initializes a new instance of GenerateExpressRoutePortsLOAResult. </summary>
        internal GenerateExpressRoutePortsLOAResult()
        {
        }

        /// <summary> Initializes a new instance of GenerateExpressRoutePortsLOAResult. </summary>
        /// <param name="encodedContent"> The content as a base64 encoded string. </param>
        internal GenerateExpressRoutePortsLOAResult(string encodedContent)
        {
            EncodedContent = encodedContent;
        }

        /// <summary> The content as a base64 encoded string. </summary>
        public string EncodedContent { get; }
    }
}
