// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Labeling MLAssist configuration definition. </summary>
    public partial class MLAssistConfiguration
    {
        /// <summary> Initializes a new instance of MLAssistConfiguration. </summary>
        public MLAssistConfiguration()
        {
        }

        /// <summary> Initializes a new instance of MLAssistConfiguration. </summary>
        /// <param name="inferencingComputeBinding"> Compute binding definition. </param>
        /// <param name="trainingComputeBinding"> Compute binding definition. </param>
        /// <param name="mlAssistEnabled"> Indicates whether MLAssist feature is enabled. </param>
        internal MLAssistConfiguration(ComputeBinding inferencingComputeBinding, ComputeBinding trainingComputeBinding, bool? mlAssistEnabled)
        {
            InferencingComputeBinding = inferencingComputeBinding;
            TrainingComputeBinding = trainingComputeBinding;
            MlAssistEnabled = mlAssistEnabled;
        }

        /// <summary> Compute binding definition. </summary>
        public ComputeBinding InferencingComputeBinding { get; set; }
        /// <summary> Compute binding definition. </summary>
        public ComputeBinding TrainingComputeBinding { get; set; }
        /// <summary> Indicates whether MLAssist feature is enabled. </summary>
        public bool? MlAssistEnabled { get; set; }
    }
}
