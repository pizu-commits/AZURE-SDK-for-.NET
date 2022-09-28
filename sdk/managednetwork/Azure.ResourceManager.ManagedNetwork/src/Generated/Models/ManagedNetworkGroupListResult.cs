// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetwork;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Result of the request to list Managed Network Groups. It contains a list of groups and a URL link to get the next set of results. </summary>
    internal partial class ManagedNetworkGroupListResult
    {
        /// <summary> Initializes a new instance of ManagedNetworkGroupListResult. </summary>
        internal ManagedNetworkGroupListResult()
        {
            Value = new ChangeTrackingList<ManagedNetworkGroupData>();
        }

        /// <summary> Initializes a new instance of ManagedNetworkGroupListResult. </summary>
        /// <param name="value"> Gets a page of ManagedNetworkGroup. </param>
        /// <param name="nextLink"> Gets the URL to get the next set of results. </param>
        internal ManagedNetworkGroupListResult(IReadOnlyList<ManagedNetworkGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets a page of ManagedNetworkGroup. </summary>
        public IReadOnlyList<ManagedNetworkGroupData> Value { get; }
        /// <summary> Gets the URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
