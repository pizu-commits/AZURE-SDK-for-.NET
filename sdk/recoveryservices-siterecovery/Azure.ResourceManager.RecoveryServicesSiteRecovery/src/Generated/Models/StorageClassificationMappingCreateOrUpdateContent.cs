// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Storage mapping input. </summary>
    public partial class StorageClassificationMappingCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of StorageClassificationMappingCreateOrUpdateContent. </summary>
        public StorageClassificationMappingCreateOrUpdateContent()
        {
        }

        /// <summary> Storage mapping input properties. </summary>
        internal StorageMappingInputProperties Properties { get; set; }
        /// <summary> The ID of the storage object. </summary>
        public string TargetStorageClassificationId
        {
            get => Properties is null ? default : Properties.TargetStorageClassificationId;
            set
            {
                if (Properties is null)
                    Properties = new StorageMappingInputProperties();
                Properties.TargetStorageClassificationId = value;
            }
        }
    }
}
