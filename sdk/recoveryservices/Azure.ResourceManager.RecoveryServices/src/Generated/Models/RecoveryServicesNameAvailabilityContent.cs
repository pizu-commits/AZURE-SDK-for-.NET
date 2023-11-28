// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Resource Name availability input parameters - Resource type and resource name. </summary>
    public partial class RecoveryServicesNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryServicesNameAvailabilityContent"/>. </summary>
        public RecoveryServicesNameAvailabilityContent()
        {
        }

        /// <summary> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </summary>
        public ResourceType? ResourceType { get; set; }
        /// <summary> Resource name for which availability needs to be checked. </summary>
        public string Name { get; set; }
    }
}
