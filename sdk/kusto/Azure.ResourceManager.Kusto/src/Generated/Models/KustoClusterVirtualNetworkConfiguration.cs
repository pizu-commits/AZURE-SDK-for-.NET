// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A class that contains virtual network definition. </summary>
    public partial class KustoClusterVirtualNetworkConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoClusterVirtualNetworkConfiguration"/>. </summary>
        /// <param name="subnetId"> The subnet resource id. </param>
        /// <param name="enginePublicIPId"> Engine service's public IP address resource id. </param>
        /// <param name="dataManagementPublicIPId"> Data management's service public IP address resource id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetId"/>, <paramref name="enginePublicIPId"/> or <paramref name="dataManagementPublicIPId"/> is null. </exception>
        public KustoClusterVirtualNetworkConfiguration(string subnetId, string enginePublicIPId, string dataManagementPublicIPId)
        {
            Argument.AssertNotNull(subnetId, nameof(subnetId));
            Argument.AssertNotNull(enginePublicIPId, nameof(enginePublicIPId));
            Argument.AssertNotNull(dataManagementPublicIPId, nameof(dataManagementPublicIPId));

            SubnetId = subnetId;
            EnginePublicIPId = enginePublicIPId;
            DataManagementPublicIPId = dataManagementPublicIPId;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterVirtualNetworkConfiguration"/>. </summary>
        /// <param name="subnetId"> The subnet resource id. </param>
        /// <param name="enginePublicIPId"> Engine service's public IP address resource id. </param>
        /// <param name="dataManagementPublicIPId"> Data management's service public IP address resource id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoClusterVirtualNetworkConfiguration(string subnetId, string enginePublicIPId, string dataManagementPublicIPId, Dictionary<string, BinaryData> rawData)
        {
            SubnetId = subnetId;
            EnginePublicIPId = enginePublicIPId;
            DataManagementPublicIPId = dataManagementPublicIPId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterVirtualNetworkConfiguration"/> for deserialization. </summary>
        internal KustoClusterVirtualNetworkConfiguration()
        {
        }

        /// <summary> The subnet resource id. </summary>
        public string SubnetId { get; set; }
        /// <summary> Engine service's public IP address resource id. </summary>
        public string EnginePublicIPId { get; set; }
        /// <summary> Data management's service public IP address resource id. </summary>
        public string DataManagementPublicIPId { get; set; }
    }
}
