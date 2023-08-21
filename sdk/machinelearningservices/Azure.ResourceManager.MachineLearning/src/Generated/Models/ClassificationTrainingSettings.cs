// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Classification Training related configuration. </summary>
    public partial class ClassificationTrainingSettings : MachineLearningTrainingSettings
    {
        /// <summary> Initializes a new instance of ClassificationTrainingSettings. </summary>
        public ClassificationTrainingSettings()
        {
            AllowedTrainingAlgorithms = new Core.ChangeTrackingList<ClassificationModel>();
            BlockedTrainingAlgorithms = new Core.ChangeTrackingList<ClassificationModel>();
        }

        /// <summary> Initializes a new instance of ClassificationTrainingSettings. </summary>
        /// <param name="isDnnTrainingEnabled"> Enable recommendation of DNN models. </param>
        /// <param name="isModelExplainabilityEnabled"> Flag to turn on explainability on best model. </param>
        /// <param name="isOnnxCompatibleModelsEnabled"> Flag for enabling onnx compatible models. </param>
        /// <param name="isStackEnsembleEnabled"> Enable stack ensemble run. </param>
        /// <param name="isVoteEnsembleEnabled"> Enable voting ensemble run. </param>
        /// <param name="ensembleModelDownloadTimeout">
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// </param>
        /// <param name="stackEnsembleSettings"> Stack ensemble settings for stack ensemble run. </param>
        /// <param name="allowedTrainingAlgorithms"> Allowed models for classification task. </param>
        /// <param name="blockedTrainingAlgorithms"> Blocked models for classification task. </param>
        internal ClassificationTrainingSettings(bool? isDnnTrainingEnabled, bool? isModelExplainabilityEnabled, bool? isOnnxCompatibleModelsEnabled, bool? isStackEnsembleEnabled, bool? isVoteEnsembleEnabled, TimeSpan? ensembleModelDownloadTimeout, MachineLearningStackEnsembleSettings stackEnsembleSettings, IList<ClassificationModel> allowedTrainingAlgorithms, IList<ClassificationModel> blockedTrainingAlgorithms) : base(isDnnTrainingEnabled, isModelExplainabilityEnabled, isOnnxCompatibleModelsEnabled, isStackEnsembleEnabled, isVoteEnsembleEnabled, ensembleModelDownloadTimeout, stackEnsembleSettings)
        {
            AllowedTrainingAlgorithms = allowedTrainingAlgorithms;
            BlockedTrainingAlgorithms = blockedTrainingAlgorithms;
        }

        /// <summary> Allowed models for classification task. </summary>
        public IList<ClassificationModel> AllowedTrainingAlgorithms { get; set; }
        /// <summary> Blocked models for classification task. </summary>
        public IList<ClassificationModel> BlockedTrainingAlgorithms { get; set; }
    }
}
