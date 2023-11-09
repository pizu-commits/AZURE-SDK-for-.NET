// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Results of the last detection. </summary>
    public partial class MultivariateLastDetectionResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MultivariateLastDetectionResult"/>. </summary>
        internal MultivariateLastDetectionResult()
        {
            VariableStates = new ChangeTrackingList<VariableState>();
            Results = new ChangeTrackingList<AnomalyState>();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="MultivariateLastDetectionResult"/>. </summary>
        /// <param name="variableStates"> Variable status. </param>
        /// <param name="results"> Anomaly status and information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MultivariateLastDetectionResult(IReadOnlyList<VariableState> variableStates, IReadOnlyList<AnomalyState> results, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VariableStates = variableStates;
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Variable status. </summary>
        public IReadOnlyList<VariableState> VariableStates { get; }
        /// <summary> Anomaly status and information. </summary>
        public IReadOnlyList<AnomalyState> Results { get; }
    }
}
