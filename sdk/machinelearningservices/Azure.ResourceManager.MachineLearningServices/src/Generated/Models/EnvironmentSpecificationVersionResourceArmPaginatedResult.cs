// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A paginated list of EnvironmentSpecificationVersion entities. </summary>
    internal partial class EnvironmentSpecificationVersionResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of EnvironmentSpecificationVersionResourceArmPaginatedResult. </summary>
        internal EnvironmentSpecificationVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<EnvironmentSpecificationVersionResource>();
        }

        /// <summary> Initializes a new instance of EnvironmentSpecificationVersionResourceArmPaginatedResult. </summary>
        /// <param name="value"> An array of objects of type EnvironmentSpecificationVersion. </param>
        /// <param name="nextLink"> . </param>
        internal EnvironmentSpecificationVersionResourceArmPaginatedResult(IReadOnlyList<EnvironmentSpecificationVersionResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of objects of type EnvironmentSpecificationVersion. </summary>
        public IReadOnlyList<EnvironmentSpecificationVersionResource> Value { get; }
        public string NextLink { get; }
    }
}
