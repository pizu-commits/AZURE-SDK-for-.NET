// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed. </summary>
    public partial class ApplicationGatewayIPConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayIPConfiguration. </summary>
        public ApplicationGatewayIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the IP configuration that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="subnet"> Reference to the subnet resource. A subnet from where application gateway gets its private address. </param>
        /// <param name="provisioningState"> The provisioning state of the application gateway IP configuration resource. </param>
        internal ApplicationGatewayIPConfiguration(string id, string name, string etag, string type, SubResource subnet, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            Subnet = subnet;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the IP configuration that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> Reference to the subnet resource. A subnet from where application gateway gets its private address. </summary>
        public SubResource Subnet { get; set; }
        /// <summary> The provisioning state of the application gateway IP configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
