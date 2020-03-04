// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Request parameter to train a new custom model. </summary>
    internal partial class TrainRequest_internal
    {
        /// <summary> Source path containing the training documents. </summary>
        public string Source { get; set; }
        /// <summary> Filter to apply to the documents in the source path for training. </summary>
        public TrainingFileFilter SourceFilter { get; set; }
        /// <summary> Use label file for training a model. </summary>
        public bool? UseLabelFile { get; set; }
    }
}
