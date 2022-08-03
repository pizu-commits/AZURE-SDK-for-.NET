// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary>
    /// Defines the NSG resource settings.
    /// Serialized Name: NetworkSecurityGroupResourceSettings
    /// </summary>
    public partial class NetworkSecurityGroupResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of NetworkSecurityGroupResourceSettings. </summary>
        /// <param name="targetResourceName">
        /// Gets or sets the target Resource name.
        /// Serialized Name: ResourceSettings.targetResourceName
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public NetworkSecurityGroupResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            if (targetResourceName == null)
            {
                throw new ArgumentNullException(nameof(targetResourceName));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            SecurityRules = new ChangeTrackingList<NetworkSecurityGroupSecurityRule>();
            ResourceType = "Microsoft.Network/networkSecurityGroups";
        }

        /// <summary> Initializes a new instance of NetworkSecurityGroupResourceSettings. </summary>
        /// <param name="resourceType">
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// Serialized Name: ResourceSettings.resourceType
        /// </param>
        /// <param name="targetResourceName">
        /// Gets or sets the target Resource name.
        /// Serialized Name: ResourceSettings.targetResourceName
        /// </param>
        /// <param name="tags">
        /// Gets or sets the Resource tags.
        /// Serialized Name: NetworkSecurityGroupResourceSettings.tags
        /// </param>
        /// <param name="securityRules">
        /// Gets or sets Security rules of network security group.
        /// Serialized Name: NetworkSecurityGroupResourceSettings.securityRules
        /// </param>
        internal NetworkSecurityGroupResourceSettings(string resourceType, string targetResourceName, IDictionary<string, string> tags, IList<NetworkSecurityGroupSecurityRule> securityRules) : base(resourceType, targetResourceName)
        {
            Tags = tags;
            SecurityRules = securityRules;
            ResourceType = resourceType ?? "Microsoft.Network/networkSecurityGroups";
        }

        /// <summary>
        /// Gets or sets the Resource tags.
        /// Serialized Name: NetworkSecurityGroupResourceSettings.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// Gets or sets Security rules of network security group.
        /// Serialized Name: NetworkSecurityGroupResourceSettings.securityRules
        /// </summary>
        public IList<NetworkSecurityGroupSecurityRule> SecurityRules { get; }
    }
}
