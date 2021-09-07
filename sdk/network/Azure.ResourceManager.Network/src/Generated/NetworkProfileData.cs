// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the NetworkProfile data model. </summary>
    public partial class NetworkProfileData : Resource
    {
        /// <summary> Initializes a new instance of NetworkProfileData. </summary>
        public NetworkProfileData()
        {
            ContainerNetworkInterfaces = new ChangeTrackingList<ContainerNetworkInterface>();
            ContainerNetworkInterfaceConfigurations = new ChangeTrackingList<ContainerNetworkInterfaceConfiguration>();
        }

        /// <summary> Initializes a new instance of NetworkProfileData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="containerNetworkInterfaces"> List of child container network interfaces. </param>
        /// <param name="containerNetworkInterfaceConfigurations"> List of chid container network interface configurations. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network profile resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network profile resource. </param>
        internal NetworkProfileData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IReadOnlyList<ContainerNetworkInterface> containerNetworkInterfaces, IList<ContainerNetworkInterfaceConfiguration> containerNetworkInterfaceConfigurations, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            ContainerNetworkInterfaces = containerNetworkInterfaces;
            ContainerNetworkInterfaceConfigurations = containerNetworkInterfaceConfigurations;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> List of child container network interfaces. </summary>
        public IReadOnlyList<ContainerNetworkInterface> ContainerNetworkInterfaces { get; }
        /// <summary> List of chid container network interface configurations. </summary>
        public IList<ContainerNetworkInterfaceConfiguration> ContainerNetworkInterfaceConfigurations { get; }
        /// <summary> The resource GUID property of the network profile resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the network profile resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
