// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Partial update of a Dev Box definition resource. </summary>
    public partial class DevBoxDefinitionPatch : TrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of DevBoxDefinitionPatch. </summary>
        public DevBoxDefinitionPatch()
        {
        }

        /// <summary> Image reference information. </summary>
        public ImageReference ImageReference { get; set; }
        /// <summary> The SKU for Dev Boxes created using this definition. </summary>
        public DevCenterSku Sku { get; set; }
        /// <summary> The storage type used for the Operating System disk of Dev Boxes created using this definition. </summary>
        public string OSStorageType { get; set; }
    }
}
