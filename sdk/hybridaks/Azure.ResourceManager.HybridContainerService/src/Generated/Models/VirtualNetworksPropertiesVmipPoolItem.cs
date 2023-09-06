// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The VirtualNetworksPropertiesVmipPoolItem. </summary>
    public partial class VirtualNetworksPropertiesVmipPoolItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesVmipPoolItem"/>. </summary>
        public VirtualNetworksPropertiesVmipPoolItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworksPropertiesVmipPoolItem"/>. </summary>
        /// <param name="endIP"> Ending IP address for the IP Pool. </param>
        /// <param name="startIP"> Starting IP address for the IP Pool. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworksPropertiesVmipPoolItem(string endIP, string startIP, Dictionary<string, BinaryData> rawData)
        {
            EndIP = endIP;
            StartIP = startIP;
            _rawData = rawData;
        }

        /// <summary> Ending IP address for the IP Pool. </summary>
        public string EndIP { get; set; }
        /// <summary> Starting IP address for the IP Pool. </summary>
        public string StartIP { get; set; }
    }
}
