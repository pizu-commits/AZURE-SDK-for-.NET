// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> InfraStorageProfile - List of infra storage profiles for the provisioned cluster. </summary>
    internal partial class CloudProviderProfileInfraStorageProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CloudProviderProfileInfraStorageProfile"/>. </summary>
        public CloudProviderProfileInfraStorageProfile()
        {
            StorageSpaceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudProviderProfileInfraStorageProfile"/>. </summary>
        /// <param name="storageSpaceIds"> Reference to azure resource corresponding to the new HybridAKSStorage object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpaceName}. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudProviderProfileInfraStorageProfile(IList<string> storageSpaceIds, Dictionary<string, BinaryData> rawData)
        {
            StorageSpaceIds = storageSpaceIds;
            _rawData = rawData;
        }

        /// <summary> Reference to azure resource corresponding to the new HybridAKSStorage object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpaceName}. </summary>
        public IList<string> StorageSpaceIds { get; }
    }
}
