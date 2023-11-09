// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a list of Experiment execution details and a link for pagination. </summary>
    internal partial class ExperimentExecutionDetailsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExperimentExecutionDetailsListResult"/>. </summary>
        internal ExperimentExecutionDetailsListResult()
        {
            Value = new ChangeTrackingList<ExperimentExecutionDetailData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExperimentExecutionDetailsListResult"/>. </summary>
        /// <param name="value"> List of Experiment execution details. </param>
        /// <param name="nextLink"> URL to retrieve the next page of Experiment execution details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExperimentExecutionDetailsListResult(IReadOnlyList<ExperimentExecutionDetailData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Experiment execution details. </summary>
        public IReadOnlyList<ExperimentExecutionDetailData> Value { get; }
        /// <summary> URL to retrieve the next page of Experiment execution details. </summary>
        public string NextLink { get; }
    }
}
