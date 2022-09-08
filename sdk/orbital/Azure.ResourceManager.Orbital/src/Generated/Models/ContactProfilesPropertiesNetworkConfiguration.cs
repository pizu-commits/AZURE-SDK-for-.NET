// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Network configuration of customer virtual network. </summary>
    internal partial class ContactProfilesPropertiesNetworkConfiguration
    {
        /// <summary> Initializes a new instance of ContactProfilesPropertiesNetworkConfiguration. </summary>
        /// <param name="networkSubnetId"> ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class C subnet, and should not have any IP created in it. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSubnetId"/> is null. </exception>
        public ContactProfilesPropertiesNetworkConfiguration(ResourceIdentifier networkSubnetId)
        {
            if (networkSubnetId == null)
            {
                throw new ArgumentNullException(nameof(networkSubnetId));
            }

            NetworkSubnetId = networkSubnetId;
        }

        /// <summary> ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class C subnet, and should not have any IP created in it. </summary>
        public ResourceIdentifier NetworkSubnetId { get; set; }
    }
}
