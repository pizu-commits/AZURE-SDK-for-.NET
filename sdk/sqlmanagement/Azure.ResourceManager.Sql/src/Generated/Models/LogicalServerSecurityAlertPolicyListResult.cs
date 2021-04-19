// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of the server&apos;s security alert policies. </summary>
    internal partial class LogicalServerSecurityAlertPolicyListResult
    {
        /// <summary> Initializes a new instance of LogicalServerSecurityAlertPolicyListResult. </summary>
        internal LogicalServerSecurityAlertPolicyListResult()
        {
            Value = new ChangeTrackingList<ServerSecurityAlertPolicy>();
        }

        /// <summary> Initializes a new instance of LogicalServerSecurityAlertPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal LogicalServerSecurityAlertPolicyListResult(IReadOnlyList<ServerSecurityAlertPolicy> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerSecurityAlertPolicy> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
