// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> Defines the virtualMachineUpdate. </summary>
    public partial class VirtualMachineUpdate
    {
        /// <summary> Initializes a new instance of VirtualMachineUpdate. </summary>
        public VirtualMachineUpdate()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The identity of the resource. </summary>
        public VmwareIdentity Identity { get; set; }
        /// <summary> Defines the resource properties. </summary>
        public HardwareProfile HardwareProfile { get; set; }
        /// <summary> Defines the resource update properties. </summary>
        public StorageProfileUpdate StorageProfile { get; set; }
        /// <summary> Defines the update resource properties. </summary>
        public NetworkProfileUpdate NetworkProfile { get; set; }
    }
}
