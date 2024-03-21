// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of spark job definitions resources. </summary>
    internal partial class SparkJobDefinitionsListResponse
    {
        /// <summary> Initializes a new instance of <see cref="SparkJobDefinitionsListResponse"/>. </summary>
        /// <param name="value"> List of spark job definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SparkJobDefinitionsListResponse(IEnumerable<SparkJobDefinitionResource> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SparkJobDefinitionsListResponse"/>. </summary>
        /// <param name="value"> List of spark job definitions. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal SparkJobDefinitionsListResponse(IReadOnlyList<SparkJobDefinitionResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of spark job definitions. </summary>
        public IReadOnlyList<SparkJobDefinitionResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
