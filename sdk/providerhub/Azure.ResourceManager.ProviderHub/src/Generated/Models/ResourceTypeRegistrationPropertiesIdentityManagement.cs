// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeRegistrationPropertiesIdentityManagement. </summary>
    public partial class ResourceTypeRegistrationPropertiesIdentityManagement : IdentityManagementProperties
    {
        /// <summary> Initializes a new instance of ResourceTypeRegistrationPropertiesIdentityManagement. </summary>
        public ResourceTypeRegistrationPropertiesIdentityManagement()
        {
        }

        /// <summary> Initializes a new instance of ResourceTypeRegistrationPropertiesIdentityManagement. </summary>
        /// <param name="managementType"></param>
        /// <param name="applicationId"></param>
        internal ResourceTypeRegistrationPropertiesIdentityManagement(IdentityManagementType? managementType, string applicationId) : base(managementType, applicationId)
        {
        }
    }
}
