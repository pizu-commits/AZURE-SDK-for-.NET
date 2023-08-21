// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of L3 Isolation Domains. </summary>
    internal partial class L3IsolationDomainsListResult
    {
        /// <summary> Initializes a new instance of L3IsolationDomainsListResult. </summary>
        internal L3IsolationDomainsListResult()
        {
            Value = new Core.ChangeTrackingList<NetworkFabricL3IsolationDomainData>();
        }

        /// <summary> Initializes a new instance of L3IsolationDomainsListResult. </summary>
        /// <param name="value"> List of L3 Isolation Domain resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal L3IsolationDomainsListResult(IReadOnlyList<NetworkFabricL3IsolationDomainData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of L3 Isolation Domain resources. </summary>
        public IReadOnlyList<NetworkFabricL3IsolationDomainData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
