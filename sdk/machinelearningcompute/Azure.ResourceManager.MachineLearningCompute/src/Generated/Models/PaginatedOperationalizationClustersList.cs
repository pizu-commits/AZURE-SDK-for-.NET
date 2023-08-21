// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningCompute;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Paginated list of operationalization clusters. </summary>
    internal partial class PaginatedOperationalizationClustersList
    {
        /// <summary> Initializes a new instance of PaginatedOperationalizationClustersList. </summary>
        internal PaginatedOperationalizationClustersList()
        {
            Value = new Core.ChangeTrackingList<OperationalizationClusterData>();
        }

        /// <summary> Initializes a new instance of PaginatedOperationalizationClustersList. </summary>
        /// <param name="value"> An array of cluster objects. </param>
        /// <param name="nextLink"> A continuation link (absolute URI) to the next page of results in the list. </param>
        internal PaginatedOperationalizationClustersList(IReadOnlyList<OperationalizationClusterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of cluster objects. </summary>
        public IReadOnlyList<OperationalizationClusterData> Value { get; }
        /// <summary> A continuation link (absolute URI) to the next page of results in the list. </summary>
        public string NextLink { get; }
    }
}
