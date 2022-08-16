// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A private container registry. </summary>
    public partial class BatchVmContainerRegistry
    {
        /// <summary> Initializes a new instance of BatchVmContainerRegistry. </summary>
        public BatchVmContainerRegistry()
        {
        }

        /// <summary> Initializes a new instance of BatchVmContainerRegistry. </summary>
        /// <param name="userName"> The user name to log into the registry server. </param>
        /// <param name="password"> The password to log into the registry server. </param>
        /// <param name="registryServer"> If omitted, the default is &quot;docker.io&quot;. </param>
        /// <param name="identity"> The reference to a user assigned identity associated with the Batch pool which a compute node will use. </param>
        internal BatchVmContainerRegistry(string userName, string password, string registryServer, ComputeNodeIdentityReference identity)
        {
            UserName = userName;
            Password = password;
            RegistryServer = registryServer;
            Identity = identity;
        }

        /// <summary> The user name to log into the registry server. </summary>
        public string UserName { get; set; }
        /// <summary> The password to log into the registry server. </summary>
        public string Password { get; set; }
        /// <summary> If omitted, the default is &quot;docker.io&quot;. </summary>
        public string RegistryServer { get; set; }
        /// <summary> The reference to a user assigned identity associated with the Batch pool which a compute node will use. </summary>
        internal ComputeNodeIdentityReference Identity { get; set; }
        /// <summary> The ARM resource id of the user assigned identity. </summary>
        public ResourceIdentifier IdentityResourceId
        {
            get => Identity is null ? default : Identity.ResourceId;
            set
            {
                if (Identity is null)
                    Identity = new ComputeNodeIdentityReference();
                Identity.ResourceId = value;
            }
        }
    }
}
