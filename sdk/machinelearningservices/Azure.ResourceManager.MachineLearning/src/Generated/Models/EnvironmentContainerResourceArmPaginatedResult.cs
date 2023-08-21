// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of EnvironmentContainer entities. </summary>
    internal partial class EnvironmentContainerResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of EnvironmentContainerResourceArmPaginatedResult. </summary>
        internal EnvironmentContainerResourceArmPaginatedResult()
        {
            Value = new Core.ChangeTrackingList<MachineLearningEnvironmentContainerData>();
        }

        /// <summary> Initializes a new instance of EnvironmentContainerResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of EnvironmentContainer objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type EnvironmentContainer. </param>
        internal EnvironmentContainerResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningEnvironmentContainerData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of EnvironmentContainer objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type EnvironmentContainer. </summary>
        public IReadOnlyList<MachineLearningEnvironmentContainerData> Value { get; }
    }
}
