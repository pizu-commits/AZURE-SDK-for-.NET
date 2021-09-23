// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of deployments. </summary>
    internal partial class DeploymentListResult
    {
        /// <summary> Initializes a new instance of DeploymentListResult. </summary>
        internal DeploymentListResult()
        {
            Value = new ChangeTrackingList<DeploymentExtendedData>();
        }

        /// <summary> Initializes a new instance of DeploymentListResult. </summary>
        /// <param name="value"> An array of deployments. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal DeploymentListResult(IReadOnlyList<DeploymentExtendedData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of deployments. </summary>
        public IReadOnlyList<DeploymentExtendedData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
