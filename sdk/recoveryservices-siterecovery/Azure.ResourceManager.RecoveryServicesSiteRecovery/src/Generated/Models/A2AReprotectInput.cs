// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Azure specific reprotect input. </summary>
    public partial class A2AReprotectInput : ReverseReplicationProviderSpecificInput
    {
        /// <summary> Initializes a new instance of A2AReprotectInput. </summary>
        public A2AReprotectInput()
        {
            VmDisks = new ChangeTrackingList<A2AVmDiskInputDetails>();
            InstanceType = "A2A";
        }

        /// <summary> The recovery container Id. </summary>
        public string RecoveryContainerId { get; set; }
        /// <summary> The list of vm disk details. </summary>
        public IList<A2AVmDiskInputDetails> VmDisks { get; }
        /// <summary> The recovery resource group Id. Valid for V2 scenarios. </summary>
        public string RecoveryResourceGroupId { get; set; }
        /// <summary> The recovery cloud service Id. Valid for V1 scenarios. </summary>
        public string RecoveryCloudServiceId { get; set; }
        /// <summary> The recovery availability set. </summary>
        public string RecoveryAvailabilitySetId { get; set; }
        /// <summary> The Policy Id. </summary>
        public string PolicyId { get; set; }
    }
}
