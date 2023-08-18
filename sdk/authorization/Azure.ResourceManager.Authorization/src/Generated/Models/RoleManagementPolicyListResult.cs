// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role management policy list operation result. </summary>
    internal partial class RoleManagementPolicyListResult
    {
        /// <summary> Initializes a new instance of RoleManagementPolicyListResult. </summary>
        internal RoleManagementPolicyListResult()
        {
            Value = new Core.ChangeTrackingList<RoleManagementPolicyData>();
        }

        /// <summary> Initializes a new instance of RoleManagementPolicyListResult. </summary>
        /// <param name="value"> Role management policy list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleManagementPolicyListResult(IReadOnlyList<RoleManagementPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role management policy list. </summary>
        public IReadOnlyList<RoleManagementPolicyData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
