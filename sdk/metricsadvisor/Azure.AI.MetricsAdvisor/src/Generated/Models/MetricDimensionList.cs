// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.MetricsAdvisor;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricDimensionList. </summary>
    internal partial class MetricDimensionList
    {
        /// <summary> Initializes a new instance of <see cref="MetricDimensionList"/>. </summary>
        internal MetricDimensionList()
        {
            Value = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetricDimensionList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"></param>
        internal MetricDimensionList(string nextLink, IReadOnlyList<string> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<string> Value { get; }
    }
}
