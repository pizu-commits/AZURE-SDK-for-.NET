// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Infra network profile for VMware platform. </summary>
    internal partial class VirtualNetworksPropertiesInfraVnetProfileVmware
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesInfraVnetProfileVmware"/>. </summary>
        public VirtualNetworksPropertiesInfraVnetProfileVmware()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesInfraVnetProfileVmware"/>. </summary>
        /// <param name="segmentName"> Name of the network segment in VSphere. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworksPropertiesInfraVnetProfileVmware(string segmentName, Dictionary<string, BinaryData> rawData)
        {
            SegmentName = segmentName;
            _rawData = rawData;
        }

        /// <summary> Name of the network segment in VSphere. </summary>
        public string SegmentName { get; set; }
    }
}
