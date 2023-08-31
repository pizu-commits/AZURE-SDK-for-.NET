// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of NetworkInterfaces. </summary>
    internal partial class NetworkDeviceInterfacesList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkDeviceInterfacesList"/>. </summary>
        internal NetworkDeviceInterfacesList()
        {
            Value = new ChangeTrackingList<NetworkDeviceInterfaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkDeviceInterfacesList"/>. </summary>
        /// <param name="value"> List of NetworkInterfaces resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkDeviceInterfacesList(IReadOnlyList<NetworkDeviceInterfaceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of NetworkInterfaces resources. </summary>
        public IReadOnlyList<NetworkDeviceInterfaceData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
