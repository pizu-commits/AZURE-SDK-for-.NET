// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of External Networks. </summary>
    internal partial class ExternalNetworksList
    {
        /// <summary> Initializes a new instance of ExternalNetworksList. </summary>
        internal ExternalNetworksList()
        {
            Value = new Core.ChangeTrackingList<NetworkFabricExternalNetworkData>();
        }

        /// <summary> Initializes a new instance of ExternalNetworksList. </summary>
        /// <param name="value"> List of External Network resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal ExternalNetworksList(IReadOnlyList<NetworkFabricExternalNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of External Network resources. </summary>
        public IReadOnlyList<NetworkFabricExternalNetworkData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
