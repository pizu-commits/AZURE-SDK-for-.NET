// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceManagementAction. </summary>
    public partial class ResourceManagementAction
    {
        /// <summary> Initializes a new instance of ResourceManagementAction. </summary>
        public ResourceManagementAction()
        {
            Resources = new ChangeTrackingList<ResourceManagementEntity>();
        }

        /// <summary> Initializes a new instance of ResourceManagementAction. </summary>
        /// <param name="resources"> resource management action content. </param>
        internal ResourceManagementAction(IList<ResourceManagementEntity> resources)
        {
            Resources = resources;
        }

        /// <summary> resource management action content. </summary>
        public IList<ResourceManagementEntity> Resources { get; }
    }
}
