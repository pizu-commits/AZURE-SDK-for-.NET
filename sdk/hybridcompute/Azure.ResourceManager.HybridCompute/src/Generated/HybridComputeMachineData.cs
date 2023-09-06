// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the HybridComputeMachine data model.
    /// Describes a hybrid machine.
    /// </summary>
    public partial class HybridComputeMachineData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HybridComputeMachineData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HybridComputeMachineData(AzureLocation location) : base(location)
        {
            Resources = new ChangeTrackingList<HybridComputeMachineExtensionData>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Hybrid Compute Machine properties. </param>
        /// <param name="resources"> The list of extensions affiliated to the machine. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridComputeMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MachineProperties properties, IReadOnlyList<HybridComputeMachineExtensionData> resources, ManagedServiceIdentity identity, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Resources = resources;
            Identity = identity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeMachineData"/> for deserialization. </summary>
        internal HybridComputeMachineData()
        {
        }

        /// <summary> Hybrid Compute Machine properties. </summary>
        public MachineProperties Properties { get; set; }
        /// <summary> The list of extensions affiliated to the machine. </summary>
        public IReadOnlyList<HybridComputeMachineExtensionData> Resources { get; }
        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
