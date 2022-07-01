// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Frontend IP configuration of an application gateway. </summary>
    public partial class ApplicationGatewayFrontendIPConfiguration : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFrontendIPConfiguration. </summary>
        public ApplicationGatewayFrontendIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayFrontendIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateIPAddress"> PrivateIPAddress of the network interface IP Configuration. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="subnet"> Reference to the subnet resource. </param>
        /// <param name="publicIPAddress"> Reference to the PublicIP resource. </param>
        /// <param name="privateLinkConfiguration"> Reference to the application gateway private link configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the frontend IP configuration resource. </param>
        internal ApplicationGatewayFrontendIPConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, string privateIPAddress, NetworkIPAllocationMethod? privateIPAllocationMethod, WritableSubResource subnet, WritableSubResource publicIPAddress, WritableSubResource privateLinkConfiguration, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = eTag;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            PrivateLinkConfiguration = privateLinkConfiguration;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> PrivateIPAddress of the network interface IP Configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public NetworkIPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> Reference to the subnet resource. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> Reference to the PublicIP resource. </summary>
        internal WritableSubResource PublicIPAddress { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPAddressId
        {
            get => PublicIPAddress is null ? default : PublicIPAddress.Id;
            set
            {
                if (PublicIPAddress is null)
                    PublicIPAddress = new WritableSubResource();
                PublicIPAddress.Id = value;
            }
        }

        /// <summary> Reference to the application gateway private link configuration. </summary>
        internal WritableSubResource PrivateLinkConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateLinkConfigurationId
        {
            get => PrivateLinkConfiguration is null ? default : PrivateLinkConfiguration.Id;
            set
            {
                if (PrivateLinkConfiguration is null)
                    PrivateLinkConfiguration = new WritableSubResource();
                PrivateLinkConfiguration.Id = value;
            }
        }

        /// <summary> The provisioning state of the frontend IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
