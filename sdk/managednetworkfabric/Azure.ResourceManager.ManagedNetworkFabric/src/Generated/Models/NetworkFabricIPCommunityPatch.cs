// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The IP Community patch resource definition. </summary>
    public partial class NetworkFabricIPCommunityPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of NetworkFabricIPCommunityPatch. </summary>
        public NetworkFabricIPCommunityPatch()
        {
            IPCommunityRules = new Core.ChangeTrackingList<IPCommunityRule>();
        }

        /// <summary> List of IP Community Rules. </summary>
        public IList<IPCommunityRule> IPCommunityRules { get; }
    }
}
