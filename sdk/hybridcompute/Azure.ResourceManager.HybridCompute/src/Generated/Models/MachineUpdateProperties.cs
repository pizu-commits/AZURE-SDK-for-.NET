// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the ARM updatable properties of a hybrid machine. </summary>
    public partial class MachineUpdateProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineUpdateProperties"/>. </summary>
        public MachineUpdateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineUpdateProperties"/>. </summary>
        /// <param name="locationData"> Metadata pertaining to the geographic location of the resource. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the hybrid machine. </param>
        /// <param name="cloudMetadata"> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </param>
        /// <param name="parentClusterResourceId"> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </param>
        /// <param name="privateLinkScopeResourceId"> The resource id of the private link scope this machine is assigned to, if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineUpdateProperties(LocationData locationData, OSProfile osProfile, CloudMetadata cloudMetadata, string parentClusterResourceId, string privateLinkScopeResourceId, Dictionary<string, BinaryData> rawData)
        {
            LocationData = locationData;
            OSProfile = osProfile;
            CloudMetadata = cloudMetadata;
            ParentClusterResourceId = parentClusterResourceId;
            PrivateLinkScopeResourceId = privateLinkScopeResourceId;
            _rawData = rawData;
        }

        /// <summary> Metadata pertaining to the geographic location of the resource. </summary>
        public LocationData LocationData { get; set; }
        /// <summary> Specifies the operating system settings for the hybrid machine. </summary>
        public OSProfile OSProfile { get; set; }
        /// <summary> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </summary>
        internal CloudMetadata CloudMetadata { get; set; }
        /// <summary> Specifies the cloud provider (Azure/AWS/GCP...). </summary>
        public string CloudMetadataProvider
        {
            get => CloudMetadata is null ? default : CloudMetadata.Provider;
        }

        /// <summary> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </summary>
        public string ParentClusterResourceId { get; set; }
        /// <summary> The resource id of the private link scope this machine is assigned to, if any. </summary>
        public string PrivateLinkScopeResourceId { get; set; }
    }
}
