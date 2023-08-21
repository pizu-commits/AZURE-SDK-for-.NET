// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of L2 Isolation Domains. </summary>
    internal partial class L2IsolationDomainsListResult
    {
        /// <summary> Initializes a new instance of L2IsolationDomainsListResult. </summary>
        internal L2IsolationDomainsListResult()
        {
            Value = new Core.ChangeTrackingList<NetworkFabricL2IsolationDomainData>();
        }

        /// <summary> Initializes a new instance of L2IsolationDomainsListResult. </summary>
        /// <param name="value"> Displays list of L2 Isolation Domain resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal L2IsolationDomainsListResult(IReadOnlyList<NetworkFabricL2IsolationDomainData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Displays list of L2 Isolation Domain resources. </summary>
        public IReadOnlyList<NetworkFabricL2IsolationDomainData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
