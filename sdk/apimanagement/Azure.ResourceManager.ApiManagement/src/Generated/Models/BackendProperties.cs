// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Properties specific to the Backend Type. </summary>
    internal partial class BackendProperties
    {
        /// <summary> Initializes a new instance of <see cref="BackendProperties"/>. </summary>
        public BackendProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackendProperties"/>. </summary>
        /// <param name="serviceFabricCluster"> Backend Service Fabric Cluster Properties. </param>
        internal BackendProperties(BackendServiceFabricClusterProperties serviceFabricCluster)
        {
            ServiceFabricCluster = serviceFabricCluster;
        }

        /// <summary> Backend Service Fabric Cluster Properties. </summary>
        public BackendServiceFabricClusterProperties ServiceFabricCluster { get; set; }
    }
}
