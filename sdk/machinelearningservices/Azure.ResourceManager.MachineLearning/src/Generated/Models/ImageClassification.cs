// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Image Classification. Multi-class image classification is used when an image is classified with only a single label
    /// from a set of classes - e.g. each image is classified as either an image of a &apos;cat&apos; or a &apos;dog&apos; or a &apos;duck&apos;.
    /// </summary>
    public partial class ImageClassification : AutoMLVertical
    {
        /// <summary> Initializes a new instance of ImageClassification. </summary>
        /// <param name="dataSettings"> [Required] Collection of registered Tabular Dataset Ids and other data settings required for training and validating models. </param>
        /// <param name="limitSettings"> [Required] Limit settings for the AutoML job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSettings"/> or <paramref name="limitSettings"/> is null. </exception>
        public ImageClassification(ImageVerticalDataSettings dataSettings, ImageLimitSettings limitSettings)
        {
            if (dataSettings == null)
            {
                throw new ArgumentNullException(nameof(dataSettings));
            }
            if (limitSettings == null)
            {
                throw new ArgumentNullException(nameof(limitSettings));
            }

            SearchSpace = new ChangeTrackingList<ImageModelDistributionSettingsClassification>();
            DataSettings = dataSettings;
            LimitSettings = limitSettings;
            TaskType = TaskType.ImageClassification;
        }

        /// <summary> Initializes a new instance of ImageClassification. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="primaryMetric"> Primary metric to optimize for this task. </param>
        /// <param name="modelSettings"> Settings used for training the model. </param>
        /// <param name="searchSpace"> Search space for sampling different combinations of models and their hyperparameters. </param>
        /// <param name="dataSettings"> [Required] Collection of registered Tabular Dataset Ids and other data settings required for training and validating models. </param>
        /// <param name="limitSettings"> [Required] Limit settings for the AutoML job. </param>
        /// <param name="sweepSettings"> Model sweeping and hyperparameter sweeping related settings. </param>
        internal ImageClassification(LogVerbosity? logVerbosity, TaskType taskType, ClassificationPrimaryMetric? primaryMetric, ImageModelSettingsClassification modelSettings, IList<ImageModelDistributionSettingsClassification> searchSpace, ImageVerticalDataSettings dataSettings, ImageLimitSettings limitSettings, ImageSweepSettings sweepSettings) : base(logVerbosity, taskType)
        {
            PrimaryMetric = primaryMetric;
            ModelSettings = modelSettings;
            SearchSpace = searchSpace;
            DataSettings = dataSettings;
            LimitSettings = limitSettings;
            SweepSettings = sweepSettings;
            TaskType = taskType;
        }

        /// <summary> Primary metric to optimize for this task. </summary>
        public ClassificationPrimaryMetric? PrimaryMetric { get; set; }
        /// <summary> Settings used for training the model. </summary>
        public ImageModelSettingsClassification ModelSettings { get; set; }
        /// <summary> Search space for sampling different combinations of models and their hyperparameters. </summary>
        public IList<ImageModelDistributionSettingsClassification> SearchSpace { get; set; }
        /// <summary> [Required] Collection of registered Tabular Dataset Ids and other data settings required for training and validating models. </summary>
        public ImageVerticalDataSettings DataSettings { get; set; }
        /// <summary> [Required] Limit settings for the AutoML job. </summary>
        public ImageLimitSettings LimitSettings { get; set; }
        /// <summary> Model sweeping and hyperparameter sweeping related settings. </summary>
        public ImageSweepSettings SweepSettings { get; set; }
    }
}
