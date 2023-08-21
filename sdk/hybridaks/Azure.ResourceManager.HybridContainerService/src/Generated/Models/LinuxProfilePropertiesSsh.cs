// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> SSH - SSH configuration for Linux-based VMs running on Azure. </summary>
    internal partial class LinuxProfilePropertiesSsh
    {
        /// <summary> Initializes a new instance of LinuxProfilePropertiesSsh. </summary>
        public LinuxProfilePropertiesSsh()
        {
            PublicKeys = new Core.ChangeTrackingList<LinuxProfilePropertiesSshPublicKeysItem>();
        }

        /// <summary> Initializes a new instance of LinuxProfilePropertiesSsh. </summary>
        /// <param name="publicKeys"> PublicKeys - The list of SSH public keys used to authenticate with Linux-based VMs. Only expect one key specified. </param>
        internal LinuxProfilePropertiesSsh(IList<LinuxProfilePropertiesSshPublicKeysItem> publicKeys)
        {
            PublicKeys = publicKeys;
        }

        /// <summary> PublicKeys - The list of SSH public keys used to authenticate with Linux-based VMs. Only expect one key specified. </summary>
        public IList<LinuxProfilePropertiesSshPublicKeysItem> PublicKeys { get; }
    }
}
