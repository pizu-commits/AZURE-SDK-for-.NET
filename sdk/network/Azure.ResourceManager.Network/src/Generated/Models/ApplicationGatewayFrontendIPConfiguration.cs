// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Frontend IP configuration of an application gateway. </summary>
    public partial class ApplicationGatewayFrontendIPConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFrontendIPConfiguration. </summary>
        public ApplicationGatewayFrontendIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayFrontendIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the frontend IP configuration that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="privateIPAddress"> PrivateIPAddress of the network interface IP Configuration. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="subnet"> Reference to the subnet resource. </param>
        /// <param name="publicIPAddress"> Reference to the PublicIP resource. </param>
        /// <param name="privateLinkConfiguration"> Reference to the application gateway private link configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the frontend IP configuration resource. </param>
        internal ApplicationGatewayFrontendIPConfiguration(string id, string name, string etag, string type, string privateIPAddress, IPAllocationMethod? privateIPAllocationMethod, WritableSubResource subnet, WritableSubResource publicIPAddress, WritableSubResource privateLinkConfiguration, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            PrivateLinkConfiguration = privateLinkConfiguration;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the frontend IP configuration that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> PrivateIPAddress of the network interface IP Configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
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
        public ProvisioningState? ProvisioningState { get; }
    }
}
