// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> HybridAKSClusterStatus defines the observed state of HybridAKSCluster. </summary>
    public partial class ProvisionedClustersCommonPropertiesStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatus"/>. </summary>
        internal ProvisionedClustersCommonPropertiesStatus()
        {
            AddonStatus = new ChangeTrackingDictionary<string, AddonStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatus"/>. </summary>
        /// <param name="featuresStatus"> Additional features status like Arc Agent Onboarding. </param>
        /// <param name="addonStatus"> AddonStatus - Status of Addons. </param>
        /// <param name="errorMessage"> ErrorMessage - Error messages during creation of cluster. </param>
        /// <param name="provisioningStatus"> Contains Provisioning errors. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClustersCommonPropertiesStatus(ProvisionedClustersCommonPropertiesStatusFeaturesStatus featuresStatus, IReadOnlyDictionary<string, AddonStatus> addonStatus, string errorMessage, ProvisionedClustersCommonPropertiesStatusProvisioningStatus provisioningStatus, Dictionary<string, BinaryData> rawData)
        {
            FeaturesStatus = featuresStatus;
            AddonStatus = addonStatus;
            ErrorMessage = errorMessage;
            ProvisioningStatus = provisioningStatus;
            _rawData = rawData;
        }

        /// <summary> Additional features status like Arc Agent Onboarding. </summary>
        internal ProvisionedClustersCommonPropertiesStatusFeaturesStatus FeaturesStatus { get; }
        /// <summary> Defines the observed Arc Agent status that is resourceSynced back to the ARM resource. </summary>
        public ArcAgentStatus ArcAgentStatus
        {
            get => FeaturesStatus?.ArcAgentStatus;
        }

        /// <summary> AddonStatus - Status of Addons. </summary>
        public IReadOnlyDictionary<string, AddonStatus> AddonStatus { get; }
        /// <summary> ErrorMessage - Error messages during creation of cluster. </summary>
        public string ErrorMessage { get; }
        /// <summary> Contains Provisioning errors. </summary>
        public ProvisionedClustersCommonPropertiesStatusProvisioningStatus ProvisioningStatus { get; }
    }
}
