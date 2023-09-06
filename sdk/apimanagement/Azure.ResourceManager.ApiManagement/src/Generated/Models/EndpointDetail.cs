// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Current TCP connectivity information from the Api Management Service to a single endpoint. </summary>
    public partial class EndpointDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EndpointDetail"/>. </summary>
        internal EndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EndpointDetail"/>. </summary>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="region"> The region of the dependency. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointDetail(int? port, string region, Dictionary<string, BinaryData> rawData)
        {
            Port = port;
            Region = region;
            _rawData = rawData;
        }

        /// <summary> The port an endpoint is connected to. </summary>
        public int? Port { get; }
        /// <summary> The region of the dependency. </summary>
        public string Region { get; }
    }
}
