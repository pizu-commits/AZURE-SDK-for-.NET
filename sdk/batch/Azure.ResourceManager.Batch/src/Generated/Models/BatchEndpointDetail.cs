// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Details about the connection between the Batch service and the endpoint. </summary>
    public partial class BatchEndpointDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchEndpointDetail"/>. </summary>
        internal BatchEndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchEndpointDetail"/>. </summary>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchEndpointDetail(int? port, Dictionary<string, BinaryData> rawData)
        {
            Port = port;
            _rawData = rawData;
        }

        /// <summary> The port an endpoint is connected to. </summary>
        public int? Port { get; }
    }
}
