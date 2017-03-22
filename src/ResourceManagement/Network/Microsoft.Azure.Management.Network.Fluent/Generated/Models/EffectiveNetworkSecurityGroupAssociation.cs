// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The effective network security group association.
    /// </summary>
    public partial class EffectiveNetworkSecurityGroupAssociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupAssociation class.
        /// </summary>
        public EffectiveNetworkSecurityGroupAssociation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupAssociation class.
        /// </summary>
        /// <param name="subnet">The ID of the subnet if assigned.</param>
        /// <param name="networkInterface">The ID of the network interface if
        /// assigned.</param>
        public EffectiveNetworkSecurityGroupAssociation(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource subnet = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), Microsoft.Azure.Management.ResourceManager.Fluent.SubResource networkInterface = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource))
        {
            Subnet = subnet;
            NetworkInterface = networkInterface;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the subnet if assigned.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets the ID of the network interface if assigned.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterface")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource NetworkInterface { get; set; }

    }
}
