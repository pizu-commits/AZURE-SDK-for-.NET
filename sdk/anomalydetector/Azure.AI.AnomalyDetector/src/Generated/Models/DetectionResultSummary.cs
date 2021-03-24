// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The DetectionResultSummary. </summary>
    public partial class DetectionResultSummary
    {
        /// <summary> Initializes a new instance of DetectionResultSummary. </summary>
        /// <param name="status"> Multivariate anomaly detection status. </param>
        /// <param name="setupInfo"> Request when creating the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="setupInfo"/> is null. </exception>
        internal DetectionResultSummary(DetectionStatus status, DetectionRequest setupInfo)
        {
            if (setupInfo == null)
            {
                throw new ArgumentNullException(nameof(setupInfo));
            }

            Status = status;
            Errors = new ChangeTrackingList<ErrorResponse>();
            VariableStates = new ChangeTrackingList<VariableState>();
            SetupInfo = setupInfo;
        }

        /// <summary> Initializes a new instance of DetectionResultSummary. </summary>
        /// <param name="status"> Multivariate anomaly detection status. </param>
        /// <param name="errors"> Error message when creating or training model fails. </param>
        /// <param name="variableStates"> . </param>
        /// <param name="setupInfo"> Request when creating the model. </param>
        internal DetectionResultSummary(DetectionStatus status, IReadOnlyList<ErrorResponse> errors, IReadOnlyList<VariableState> variableStates, DetectionRequest setupInfo)
        {
            Status = status;
            Errors = errors;
            VariableStates = variableStates;
            SetupInfo = setupInfo;
        }

        /// <summary> Multivariate anomaly detection status. </summary>
        public DetectionStatus Status { get; }
        /// <summary> Error message when creating or training model fails. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
        public IReadOnlyList<VariableState> VariableStates { get; }
        /// <summary> Request when creating the model. </summary>
        public DetectionRequest SetupInfo { get; }
    }
}
