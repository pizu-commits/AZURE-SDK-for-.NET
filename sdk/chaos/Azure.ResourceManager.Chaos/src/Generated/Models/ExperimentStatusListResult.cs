// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a list of Experiment statuses and a link for pagination. </summary>
    internal partial class ExperimentStatusListResult
    {
        /// <summary> Initializes a new instance of ExperimentStatusListResult. </summary>
        internal ExperimentStatusListResult()
        {
            Value = new Core.ChangeTrackingList<ExperimentStatusData>();
        }

        /// <summary> Initializes a new instance of ExperimentStatusListResult. </summary>
        /// <param name="value"> List of Experiment statuses. </param>
        /// <param name="nextLink"> URL to retrieve the next page of Experiment statuses. </param>
        internal ExperimentStatusListResult(IReadOnlyList<ExperimentStatusData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Experiment statuses. </summary>
        public IReadOnlyList<ExperimentStatusData> Value { get; }
        /// <summary> URL to retrieve the next page of Experiment statuses. </summary>
        public string NextLink { get; }
    }
}
