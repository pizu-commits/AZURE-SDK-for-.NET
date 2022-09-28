// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary> A class representing the Pool data model. </summary>
    public partial class PoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of PoolData. </summary>
        /// <param name="location"> The location. </param>
        public PoolData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of PoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="devBoxDefinitionName"> Name of a Dev Box definition in parent Project of this Pool. </param>
        /// <param name="networkConnectionName"> Name of a Network Connection in parent Project of this Pool. </param>
        /// <param name="licenseType"> Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created. </param>
        /// <param name="localAdministrator"> Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal PoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string devBoxDefinitionName, string networkConnectionName, LicenseType? licenseType, LocalAdminStatus? localAdministrator, string provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            DevBoxDefinitionName = devBoxDefinitionName;
            NetworkConnectionName = networkConnectionName;
            LicenseType = licenseType;
            LocalAdministrator = localAdministrator;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of a Dev Box definition in parent Project of this Pool. </summary>
        public string DevBoxDefinitionName { get; set; }
        /// <summary> Name of a Network Connection in parent Project of this Pool. </summary>
        public string NetworkConnectionName { get; set; }
        /// <summary> Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created. </summary>
        public LicenseType? LicenseType { get; set; }
        /// <summary> Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box. </summary>
        public LocalAdminStatus? LocalAdministrator { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public string ProvisioningState { get; }
    }
}
