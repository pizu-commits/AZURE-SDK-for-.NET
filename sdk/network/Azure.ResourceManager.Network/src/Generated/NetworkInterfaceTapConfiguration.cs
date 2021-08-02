// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a NetworkInterfaceTapConfiguration along with the instance operations that can be performed on it. </summary>
    public class NetworkInterfaceTapConfiguration : NetworkInterfaceTapConfigurationOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "NetworkInterfaceTapConfiguration"/> class for mocking. </summary>
        protected NetworkInterfaceTapConfiguration() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkInterfaceTapConfiguration"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal NetworkInterfaceTapConfiguration(ResourceOperations options, NetworkInterfaceTapConfigurationData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the NetworkInterfaceTapConfigurationData. </summary>
        public virtual NetworkInterfaceTapConfigurationData Data { get; private set; }
    }
}
