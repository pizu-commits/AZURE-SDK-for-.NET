// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Distribution expressions to sweep over values of model settings.
    /// &lt;example&gt;
    /// Some examples are:
    /// &lt;code&gt;
    /// ModelName = "choice('seresnext', 'resnest50')";
    /// LearningRate = "uniform(0.001, 0.01)";
    /// LayersToFreeze = "choice(0, 2)";
    /// &lt;/code&gt;&lt;/example&gt;
    /// All distributions can be specified as distribution_name(min, max) or choice(val1, val2, ..., valn)
    /// where distribution name can be: uniform, quniform, loguniform, etc
    /// For more details on how to compose distribution expressions please check the documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-tune-hyperparameters
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    /// </summary>
    public partial class ImageModelDistributionSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImageModelDistributionSettings"/>. </summary>
        public ImageModelDistributionSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageModelDistributionSettings"/>. </summary>
        /// <param name="amsGradient"> Enable AMSGrad when optimizer is 'adam' or 'adamw'. </param>
        /// <param name="augmentations"> Settings for using Augmentations. </param>
        /// <param name="beta1"> Value of 'beta1' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </param>
        /// <param name="beta2"> Value of 'beta2' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </param>
        /// <param name="distributed"> Whether to use distributer training. </param>
        /// <param name="earlyStopping"> Enable early stopping logic during training. </param>
        /// <param name="earlyStoppingDelay">
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </param>
        /// <param name="earlyStoppingPatience">
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </param>
        /// <param name="enableOnnxNormalization"> Enable normalization when exporting ONNX model. </param>
        /// <param name="evaluationFrequency"> Frequency to evaluate validation dataset to get metric scores. Must be a positive integer. </param>
        /// <param name="gradientAccumulationStep">
        /// Gradient accumulation means running a configured number of "GradAccumulationStep" steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </param>
        /// <param name="layersToFreeze">
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for 'seresnext' means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="learningRate"> Initial learning rate. Must be a float in the range [0, 1]. </param>
        /// <param name="learningRateScheduler"> Type of learning rate scheduler. Must be 'warmup_cosine' or 'step'. </param>
        /// <param name="modelName">
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="momentum"> Value of momentum when optimizer is 'sgd'. Must be a float in the range [0, 1]. </param>
        /// <param name="nesterov"> Enable nesterov when optimizer is 'sgd'. </param>
        /// <param name="numberOfEpochs"> Number of training epochs. Must be a positive integer. </param>
        /// <param name="numberOfWorkers"> Number of data loader workers. Must be a non-negative integer. </param>
        /// <param name="optimizer"> Type of optimizer. Must be either 'sgd', 'adam', or 'adamw'. </param>
        /// <param name="randomSeed"> Random seed to be used when using deterministic training. </param>
        /// <param name="stepLRGamma"> Value of gamma when learning rate scheduler is 'step'. Must be a float in the range [0, 1]. </param>
        /// <param name="stepLRStepSize"> Value of step size when learning rate scheduler is 'step'. Must be a positive integer. </param>
        /// <param name="trainingBatchSize"> Training batch size. Must be a positive integer. </param>
        /// <param name="validationBatchSize"> Validation batch size. Must be a positive integer. </param>
        /// <param name="warmupCosineLRCycles"> Value of cosine cycle when learning rate scheduler is 'warmup_cosine'. Must be a float in the range [0, 1]. </param>
        /// <param name="warmupCosineLRWarmupEpochs"> Value of warmup epochs when learning rate scheduler is 'warmup_cosine'. Must be a positive integer. </param>
        /// <param name="weightDecay"> Value of weight decay when optimizer is 'sgd', 'adam', or 'adamw'. Must be a float in the range[0, 1]. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageModelDistributionSettings(string amsGradient, string augmentations, string beta1, string beta2, string distributed, string earlyStopping, string earlyStoppingDelay, string earlyStoppingPatience, string enableOnnxNormalization, string evaluationFrequency, string gradientAccumulationStep, string layersToFreeze, string learningRate, string learningRateScheduler, string modelName, string momentum, string nesterov, string numberOfEpochs, string numberOfWorkers, string optimizer, string randomSeed, string stepLRGamma, string stepLRStepSize, string trainingBatchSize, string validationBatchSize, string warmupCosineLRCycles, string warmupCosineLRWarmupEpochs, string weightDecay, Dictionary<string, BinaryData> rawData)
        {
            AmsGradient = amsGradient;
            Augmentations = augmentations;
            Beta1 = beta1;
            Beta2 = beta2;
            Distributed = distributed;
            EarlyStopping = earlyStopping;
            EarlyStoppingDelay = earlyStoppingDelay;
            EarlyStoppingPatience = earlyStoppingPatience;
            EnableOnnxNormalization = enableOnnxNormalization;
            EvaluationFrequency = evaluationFrequency;
            GradientAccumulationStep = gradientAccumulationStep;
            LayersToFreeze = layersToFreeze;
            LearningRate = learningRate;
            LearningRateScheduler = learningRateScheduler;
            ModelName = modelName;
            Momentum = momentum;
            Nesterov = nesterov;
            NumberOfEpochs = numberOfEpochs;
            NumberOfWorkers = numberOfWorkers;
            Optimizer = optimizer;
            RandomSeed = randomSeed;
            StepLRGamma = stepLRGamma;
            StepLRStepSize = stepLRStepSize;
            TrainingBatchSize = trainingBatchSize;
            ValidationBatchSize = validationBatchSize;
            WarmupCosineLRCycles = warmupCosineLRCycles;
            WarmupCosineLRWarmupEpochs = warmupCosineLRWarmupEpochs;
            WeightDecay = weightDecay;
            _rawData = rawData;
        }

        /// <summary> Enable AMSGrad when optimizer is 'adam' or 'adamw'. </summary>
        public string AmsGradient { get; set; }
        /// <summary> Settings for using Augmentations. </summary>
        public string Augmentations { get; set; }
        /// <summary> Value of 'beta1' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </summary>
        public string Beta1 { get; set; }
        /// <summary> Value of 'beta2' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </summary>
        public string Beta2 { get; set; }
        /// <summary> Whether to use distributer training. </summary>
        public string Distributed { get; set; }
        /// <summary> Enable early stopping logic during training. </summary>
        public string EarlyStopping { get; set; }
        /// <summary>
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </summary>
        public string EarlyStoppingDelay { get; set; }
        /// <summary>
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </summary>
        public string EarlyStoppingPatience { get; set; }
        /// <summary> Enable normalization when exporting ONNX model. </summary>
        public string EnableOnnxNormalization { get; set; }
        /// <summary> Frequency to evaluate validation dataset to get metric scores. Must be a positive integer. </summary>
        public string EvaluationFrequency { get; set; }
        /// <summary>
        /// Gradient accumulation means running a configured number of "GradAccumulationStep" steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </summary>
        public string GradientAccumulationStep { get; set; }
        /// <summary>
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for 'seresnext' means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </summary>
        public string LayersToFreeze { get; set; }
        /// <summary> Initial learning rate. Must be a float in the range [0, 1]. </summary>
        public string LearningRate { get; set; }
        /// <summary> Type of learning rate scheduler. Must be 'warmup_cosine' or 'step'. </summary>
        public string LearningRateScheduler { get; set; }
        /// <summary>
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </summary>
        public string ModelName { get; set; }
        /// <summary> Value of momentum when optimizer is 'sgd'. Must be a float in the range [0, 1]. </summary>
        public string Momentum { get; set; }
        /// <summary> Enable nesterov when optimizer is 'sgd'. </summary>
        public string Nesterov { get; set; }
        /// <summary> Number of training epochs. Must be a positive integer. </summary>
        public string NumberOfEpochs { get; set; }
        /// <summary> Number of data loader workers. Must be a non-negative integer. </summary>
        public string NumberOfWorkers { get; set; }
        /// <summary> Type of optimizer. Must be either 'sgd', 'adam', or 'adamw'. </summary>
        public string Optimizer { get; set; }
        /// <summary> Random seed to be used when using deterministic training. </summary>
        public string RandomSeed { get; set; }
        /// <summary> Value of gamma when learning rate scheduler is 'step'. Must be a float in the range [0, 1]. </summary>
        public string StepLRGamma { get; set; }
        /// <summary> Value of step size when learning rate scheduler is 'step'. Must be a positive integer. </summary>
        public string StepLRStepSize { get; set; }
        /// <summary> Training batch size. Must be a positive integer. </summary>
        public string TrainingBatchSize { get; set; }
        /// <summary> Validation batch size. Must be a positive integer. </summary>
        public string ValidationBatchSize { get; set; }
        /// <summary> Value of cosine cycle when learning rate scheduler is 'warmup_cosine'. Must be a float in the range [0, 1]. </summary>
        public string WarmupCosineLRCycles { get; set; }
        /// <summary> Value of warmup epochs when learning rate scheduler is 'warmup_cosine'. Must be a positive integer. </summary>
        public string WarmupCosineLRWarmupEpochs { get; set; }
        /// <summary> Value of weight decay when optimizer is 'sgd', 'adam', or 'adamw'. Must be a float in the range[0, 1]. </summary>
        public string WeightDecay { get; set; }
    }
}
