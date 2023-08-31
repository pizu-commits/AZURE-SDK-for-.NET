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
    /// Text Classification Multilabel task in AutoML NLP vertical.
    /// NLP - Natural Language Processing.
    /// </summary>
    public partial class TextClassificationMultilabel : AutoMLVertical
    {
        /// <summary> Initializes a new instance of <see cref="TextClassificationMultilabel"/>. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> is null. </exception>
        public TextClassificationMultilabel(MachineLearningTableJobInput trainingData) : base(trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));

            TaskType = TaskType.TextClassificationMultilabel;
        }

        /// <summary> Initializes a new instance of <see cref="TextClassificationMultilabel"/>. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="primaryMetric">
        /// Primary metric for Text-Classification-Multilabel task.
        /// Currently only Accuracy is supported as primary metric, hence user need not set it explicitly.
        /// </param>
        /// <param name="featurizationSettings"> Featurization inputs needed for AutoML job. </param>
        /// <param name="limitSettings"> Execution constraints for AutoMLJob. </param>
        /// <param name="validationData"> Validation data inputs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TextClassificationMultilabel(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData, ClassificationMultilabelPrimaryMetric? primaryMetric, NlpVerticalFeaturizationSettings featurizationSettings, NlpVerticalLimitSettings limitSettings, MachineLearningTableJobInput validationData, Dictionary<string, BinaryData> rawData) : base(logVerbosity, targetColumnName, taskType, trainingData, rawData)
        {
            PrimaryMetric = primaryMetric;
            FeaturizationSettings = featurizationSettings;
            LimitSettings = limitSettings;
            ValidationData = validationData;
            TaskType = taskType;
        }

        /// <summary> Initializes a new instance of <see cref="TextClassificationMultilabel"/> for deserialization. </summary>
        internal TextClassificationMultilabel()
        {
        }

        /// <summary>
        /// Primary metric for Text-Classification-Multilabel task.
        /// Currently only Accuracy is supported as primary metric, hence user need not set it explicitly.
        /// </summary>
        public ClassificationMultilabelPrimaryMetric? PrimaryMetric { get; }
        /// <summary> Featurization inputs needed for AutoML job. </summary>
        internal NlpVerticalFeaturizationSettings FeaturizationSettings { get; set; }
        /// <summary> Dataset language, useful for the text data. </summary>
        public string FeaturizationDatasetLanguage
        {
            get => FeaturizationSettings is null ? default : FeaturizationSettings.DatasetLanguage;
            set
            {
                if (FeaturizationSettings is null)
                    FeaturizationSettings = new NlpVerticalFeaturizationSettings();
                FeaturizationSettings.DatasetLanguage = value;
            }
        }

        /// <summary> Execution constraints for AutoMLJob. </summary>
        public NlpVerticalLimitSettings LimitSettings { get; set; }
        /// <summary> Validation data inputs. </summary>
        public MachineLearningTableJobInput ValidationData { get; set; }
    }
}
