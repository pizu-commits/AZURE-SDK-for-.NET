// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set. </summary>
    public partial class AvailabilitySet : Resource
    {
        /// <summary> Initializes a new instance of AvailabilitySet. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public AvailabilitySet(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            VirtualMachines = new ChangeTrackingList<SubResource>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of AvailabilitySet. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks. Default value is &apos;Classic&apos;. </param>
        /// <param name="platformUpdateDomainCount"> Update Domain count. </param>
        /// <param name="platformFaultDomainCount"> Fault Domain count. </param>
        /// <param name="virtualMachines"> A list of references to all virtual machines in the availability set. </param>
        /// <param name="proximityPlacementGroup"> Specifies information about the proximity placement group that the availability set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal AvailabilitySet(string id, string name, string type, string location, IDictionary<string, string> tags, Sku sku, int? platformUpdateDomainCount, int? platformFaultDomainCount, IList<SubResource> virtualMachines, SubResource proximityPlacementGroup, IReadOnlyList<InstanceViewStatus> statuses) : base(id, name, type, location, tags)
        {
            Sku = sku;
            PlatformUpdateDomainCount = platformUpdateDomainCount;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachines = virtualMachines;
            ProximityPlacementGroup = proximityPlacementGroup;
            Statuses = statuses;
        }

        /// <summary> Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks. Default value is &apos;Classic&apos;. </summary>
        public Sku Sku { get; set; }
        /// <summary> Update Domain count. </summary>
        public int? PlatformUpdateDomainCount { get; set; }
        /// <summary> Fault Domain count. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> A list of references to all virtual machines in the availability set. </summary>
        public IList<SubResource> VirtualMachines { get; }
        /// <summary> Specifies information about the proximity placement group that the availability set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </summary>
        public SubResource ProximityPlacementGroup { get; set; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
