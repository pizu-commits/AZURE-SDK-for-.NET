// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource group information. </summary>
    public partial class PatchableResourceGroupData
    {
        /// <summary> Initializes a new instance of PatchableResourceGroupData. </summary>
        public PatchableResourceGroupData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The name of the resource group. </summary>
        public string Name { get; set; }
        /// <summary> The resource group properties. </summary>
        internal ResourceGroupProperties Properties { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ResourceGroupProvisioningState
        {
            get => Properties is null ? default : Properties.ProvisioningState;
        }

        /// <summary> The ID of the resource that manages this resource group. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The tags attached to the resource group. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
