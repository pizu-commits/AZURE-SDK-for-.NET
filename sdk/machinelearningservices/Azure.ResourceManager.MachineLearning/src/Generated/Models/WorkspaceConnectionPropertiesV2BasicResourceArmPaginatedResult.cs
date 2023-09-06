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
    /// <summary> The WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult. </summary>
    internal partial class WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult"/>. </summary>
        internal WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningWorkspaceConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(IReadOnlyList<MachineLearningWorkspaceConnectionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<MachineLearningWorkspaceConnectionData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
