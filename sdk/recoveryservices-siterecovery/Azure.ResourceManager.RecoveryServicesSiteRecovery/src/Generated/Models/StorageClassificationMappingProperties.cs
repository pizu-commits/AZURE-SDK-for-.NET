// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Storage mapping properties. </summary>
    internal partial class StorageClassificationMappingProperties
    {
        /// <summary> Initializes a new instance of <see cref="StorageClassificationMappingProperties"/>. </summary>
        internal StorageClassificationMappingProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageClassificationMappingProperties"/>. </summary>
        /// <param name="targetStorageClassificationId"> Target storage object Id. </param>
        internal StorageClassificationMappingProperties(ResourceIdentifier targetStorageClassificationId)
        {
            TargetStorageClassificationId = targetStorageClassificationId;
        }

        /// <summary> Target storage object Id. </summary>
        public ResourceIdentifier TargetStorageClassificationId { get; }
    }
}
