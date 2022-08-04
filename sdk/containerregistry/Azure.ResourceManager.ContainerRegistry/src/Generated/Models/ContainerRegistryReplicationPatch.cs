// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a replication. </summary>
    public partial class ContainerRegistryReplicationPatch
    {
        /// <summary> Initializes a new instance of ContainerRegistryReplicationPatch. </summary>
        public ContainerRegistryReplicationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The tags for the replication. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Specifies whether the replication&apos;s regional endpoint is enabled. Requests will not be routed to a replication whose regional endpoint is disabled, however its data will continue to be synced with other replications. </summary>
        public bool? IsRegionEndpointEnabled { get; set; }
    }
}
