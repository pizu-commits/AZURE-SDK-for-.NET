// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Ports and any VIF attached to segment. </summary>
    public partial class WorkloadNetworkSegmentPortVif
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkSegmentPortVif"/>. </summary>
        internal WorkloadNetworkSegmentPortVif()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkSegmentPortVif"/>. </summary>
        /// <param name="portName"> Name of port or VIF attached to segment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkSegmentPortVif(string portName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PortName = portName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of port or VIF attached to segment. </summary>
        public string PortName { get; }
    }
}
