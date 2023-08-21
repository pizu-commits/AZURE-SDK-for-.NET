// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkDeviceSku data model.
    /// The NetworkDeviceSku resource definition.
    /// </summary>
    public partial class NetworkDeviceSkuData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkDeviceSkuData. </summary>
        /// <param name="model"> Model of the network device. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        public NetworkDeviceSkuData(string model)
        {
            Argument.AssertNotNull(model, nameof(model));

            Model = model;
            SupportedVersions = new Core.ChangeTrackingList<SupportedVersionProperties>();
            SupportedRoleTypes = new Core.ChangeTrackingList<NetworkDeviceRoleName>();
            Interfaces = new Core.ChangeTrackingList<NetworkDeviceInterfaceProperties>();
        }

        /// <summary> Initializes a new instance of NetworkDeviceSkuData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="model"> Model of the network device. </param>
        /// <param name="manufacturer"> Manufacturer of the network device. </param>
        /// <param name="supportedVersions"> List of supported version details of network device. </param>
        /// <param name="supportedRoleTypes"> Available roles for the network device. </param>
        /// <param name="interfaces"> List of network device interfaces. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        internal NetworkDeviceSkuData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string model, string manufacturer, IList<SupportedVersionProperties> supportedVersions, IList<NetworkDeviceRoleName> supportedRoleTypes, IList<NetworkDeviceInterfaceProperties> interfaces, NetworkFabricProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Model = model;
            Manufacturer = manufacturer;
            SupportedVersions = supportedVersions;
            SupportedRoleTypes = supportedRoleTypes;
            Interfaces = interfaces;
            ProvisioningState = provisioningState;
        }

        /// <summary> Model of the network device. </summary>
        public string Model { get; set; }
        /// <summary> Manufacturer of the network device. </summary>
        public string Manufacturer { get; set; }
        /// <summary> List of supported version details of network device. </summary>
        public IList<SupportedVersionProperties> SupportedVersions { get; }
        /// <summary> Available roles for the network device. </summary>
        public IList<NetworkDeviceRoleName> SupportedRoleTypes { get; }
        /// <summary> List of network device interfaces. </summary>
        public IList<NetworkDeviceInterfaceProperties> Interfaces { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
