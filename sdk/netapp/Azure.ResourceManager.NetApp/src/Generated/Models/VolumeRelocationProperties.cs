// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume relocation properties. </summary>
    internal partial class VolumeRelocationProperties
    {
        /// <summary> Initializes a new instance of VolumeRelocationProperties. </summary>
        internal VolumeRelocationProperties()
        {
        }

        /// <summary> The id of the old volume that is being relocated. </summary>
        public string OldVolumeId { get; }
        /// <summary> The id of the bare metal tenant owned by the existing volume. </summary>
        public string OldBareMetalTenantId { get; }
        /// <summary> Has relocation been requested for this volume. </summary>
        public bool? RelocationRequested { get; }
    }
}
