// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the Experiment action target details properties model. </summary>
    public partial class ExperimentExecutionActionTargetDetailsProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExperimentExecutionActionTargetDetailsProperties"/>. </summary>
        internal ExperimentExecutionActionTargetDetailsProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExperimentExecutionActionTargetDetailsProperties"/>. </summary>
        /// <param name="status"> The status of the execution. </param>
        /// <param name="target"> The target for the action. </param>
        /// <param name="targetFailedOn"> String that represents the failed date time. </param>
        /// <param name="targetCompletedOn"> String that represents the completed date time. </param>
        /// <param name="error"> The error of the action. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExperimentExecutionActionTargetDetailsProperties(string status, string target, DateTimeOffset? targetFailedOn, DateTimeOffset? targetCompletedOn, ExperimentExecutionActionTargetDetailsError error, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Target = target;
            TargetFailedOn = targetFailedOn;
            TargetCompletedOn = targetCompletedOn;
            Error = error;
            _rawData = rawData;
        }

        /// <summary> The status of the execution. </summary>
        public string Status { get; }
        /// <summary> The target for the action. </summary>
        public string Target { get; }
        /// <summary> String that represents the failed date time. </summary>
        public DateTimeOffset? TargetFailedOn { get; }
        /// <summary> String that represents the completed date time. </summary>
        public DateTimeOffset? TargetCompletedOn { get; }
        /// <summary> The error of the action. </summary>
        public ExperimentExecutionActionTargetDetailsError Error { get; }
    }
}
