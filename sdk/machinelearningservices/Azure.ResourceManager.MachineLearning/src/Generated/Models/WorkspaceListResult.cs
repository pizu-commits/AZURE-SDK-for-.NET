// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The result of a request to list machine learning workspaces. </summary>
    internal partial class WorkspaceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkspaceListResult"/>. </summary>
        internal WorkspaceListResult()
        {
            Value = new ChangeTrackingList<MachineLearningWorkspaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceListResult"/>. </summary>
        /// <param name="value"> The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request the next list of machine learning workspaces. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of machine learning workspaces. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceListResult(IReadOnlyList<MachineLearningWorkspaceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request the next list of machine learning workspaces. </summary>
        public IReadOnlyList<MachineLearningWorkspaceData> Value { get; }
        /// <summary> The URI that can be used to request the next list of machine learning workspaces. </summary>
        public string NextLink { get; }
    }
}
