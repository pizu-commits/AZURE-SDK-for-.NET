// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary>
    /// Defines the resource group resource settings.
    /// Serialized Name: ResourceGroupResourceSettings
    /// </summary>
    public partial class ResourceGroupResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of ResourceGroupResourceSettings. </summary>
        /// <param name="targetResourceName">
        /// Gets or sets the target Resource name.
        /// Serialized Name: ResourceSettings.targetResourceName
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public ResourceGroupResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            if (targetResourceName == null)
            {
                throw new ArgumentNullException(nameof(targetResourceName));
            }

            ResourceType = "resourceGroups";
        }

        /// <summary> Initializes a new instance of ResourceGroupResourceSettings. </summary>
        /// <param name="resourceType">
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// Serialized Name: ResourceSettings.resourceType
        /// </param>
        /// <param name="targetResourceName">
        /// Gets or sets the target Resource name.
        /// Serialized Name: ResourceSettings.targetResourceName
        /// </param>
        internal ResourceGroupResourceSettings(string resourceType, string targetResourceName) : base(resourceType, targetResourceName)
        {
            ResourceType = resourceType ?? "resourceGroups";
        }
    }
}
