// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the SiteRecoveryNetworkMapping data model.
    /// Network Mapping model. Ideally it should have been possible to inherit this class from prev version in InheritedModels as long as there is no difference in structure or method signature. Since there were no base Models for certain fields and methods viz NetworkMappingProperties and Load with required return type, the class has been introduced in its entirety with references to base models to facilitate extensions in subsequent versions.
    /// </summary>
    public partial class SiteRecoveryNetworkMappingData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryNetworkMappingData"/>. </summary>
        internal SiteRecoveryNetworkMappingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryNetworkMappingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The Network Mapping Properties. </param>
        /// <param name="location"> Resource Location. </param>
        internal SiteRecoveryNetworkMappingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRecoveryNetworkMappingProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> The Network Mapping Properties. </summary>
        public SiteRecoveryNetworkMappingProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
