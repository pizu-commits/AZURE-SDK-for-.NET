// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> Defines the resource update properties. </summary>
    public partial class StorageProfileUpdate
    {
        /// <summary> Initializes a new instance of StorageProfileUpdate. </summary>
        public StorageProfileUpdate()
        {
            Disks = new ChangeTrackingList<VirtualDiskUpdate>();
        }

        /// <summary> Gets or sets the list of virtual disks associated with the virtual machine. </summary>
        public IList<VirtualDiskUpdate> Disks { get; }
    }
}
