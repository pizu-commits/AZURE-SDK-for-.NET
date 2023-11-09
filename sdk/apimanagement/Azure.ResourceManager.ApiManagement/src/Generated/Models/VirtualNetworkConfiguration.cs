// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Configuration of a virtual network to which API Management service is deployed. </summary>
    public partial class VirtualNetworkConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkConfiguration"/>. </summary>
        public VirtualNetworkConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkConfiguration"/>. </summary>
        /// <param name="vnetId"> The virtual network ID. This is typically a GUID. Expect a null GUID by default. </param>
        /// <param name="subnetname"> The name of the subnet. </param>
        /// <param name="subnetResourceId"> The full resource ID of a subnet in a virtual network to deploy the API Management service in. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkConfiguration(Guid? vnetId, string subnetname, ResourceIdentifier subnetResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VnetId = vnetId;
            Subnetname = subnetname;
            SubnetResourceId = subnetResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The virtual network ID. This is typically a GUID. Expect a null GUID by default. </summary>
        public Guid? VnetId { get; }
        /// <summary> The name of the subnet. </summary>
        public string Subnetname { get; }
        /// <summary> The full resource ID of a subnet in a virtual network to deploy the API Management service in. </summary>
        public ResourceIdentifier SubnetResourceId { get; set; }
    }
}
