// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input required to add vCenter. </summary>
    public partial class SiteRecoveryVCenterCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVCenterCreateOrUpdateContent"/>. </summary>
        public SiteRecoveryVCenterCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVCenterCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> The properties of an add vCenter request. </param>
        internal SiteRecoveryVCenterCreateOrUpdateContent(SiteRecoveryAddVCenterProperties properties)
        {
            Properties = properties;
        }

        /// <summary> The properties of an add vCenter request. </summary>
        public SiteRecoveryAddVCenterProperties Properties { get; set; }
    }
}
