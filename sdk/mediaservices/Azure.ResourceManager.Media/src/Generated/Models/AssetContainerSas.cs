// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The Asset Storage container SAS URLs. </summary>
    internal partial class AssetContainerSas
    {
        /// <summary> Initializes a new instance of AssetContainerSas. </summary>
        internal AssetContainerSas()
        {
            AssetContainerSasUris = new Core.ChangeTrackingList<Uri>();
        }

        /// <summary> Initializes a new instance of AssetContainerSas. </summary>
        /// <param name="assetContainerSasUris"> The list of Asset container SAS URLs. </param>
        internal AssetContainerSas(IReadOnlyList<Uri> assetContainerSasUris)
        {
            AssetContainerSasUris = assetContainerSasUris;
        }

        /// <summary> The list of Asset container SAS URLs. </summary>
        public IReadOnlyList<Uri> AssetContainerSasUris { get; }
    }
}
