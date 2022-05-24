// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Represents the capacity reservation utilization in terms of resources allocated. </summary>
    internal partial class CapacityReservationUtilization
    {
        /// <summary> Initializes a new instance of CapacityReservationUtilization. </summary>
        internal CapacityReservationUtilization()
        {
            VirtualMachinesAllocated = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of CapacityReservationUtilization. </summary>
        /// <param name="virtualMachinesAllocated"> A list of all virtual machines resource ids allocated against the capacity reservation. </param>
        internal CapacityReservationUtilization(IReadOnlyList<SubResource> virtualMachinesAllocated)
        {
            VirtualMachinesAllocated = virtualMachinesAllocated;
        }

        /// <summary> A list of all virtual machines resource ids allocated against the capacity reservation. </summary>
        public IReadOnlyList<SubResource> VirtualMachinesAllocated { get; }
    }
}
