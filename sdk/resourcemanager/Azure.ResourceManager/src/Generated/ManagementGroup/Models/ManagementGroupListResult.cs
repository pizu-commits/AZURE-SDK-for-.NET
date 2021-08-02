// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> Describes the result of the request to list management groups. </summary>
    internal partial class ManagementGroupListResult
    {
        /// <summary> Initializes a new instance of ManagementGroupListResult. </summary>
        internal ManagementGroupListResult()
        {
            Value = new ChangeTrackingList<ManagementGroupInfoData>();
        }

        /// <summary> Initializes a new instance of ManagementGroupListResult. </summary>
        /// <param name="value"> The list of management groups. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ManagementGroupListResult(IReadOnlyList<ManagementGroupInfoData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of management groups. </summary>
        public IReadOnlyList<ManagementGroupInfoData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
