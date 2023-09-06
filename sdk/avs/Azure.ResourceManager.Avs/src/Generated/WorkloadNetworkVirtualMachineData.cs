// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the WorkloadNetworkVirtualMachine data model.
    /// NSX Virtual Machine
    /// </summary>
    public partial class WorkloadNetworkVirtualMachineData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkVirtualMachineData"/>. </summary>
        public WorkloadNetworkVirtualMachineData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkVirtualMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the VM. </param>
        /// <param name="vmType"> Virtual machine type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkVirtualMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, WorkloadNetworkVmType? vmType, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            VmType = vmType;
            _rawData = rawData;
        }

        /// <summary> Display name of the VM. </summary>
        public string DisplayName { get; set; }
        /// <summary> Virtual machine type. </summary>
        public WorkloadNetworkVmType? VmType { get; }
    }
}
