// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageModelSettingsClassification : IUtf8JsonSerializable, IModelJsonSerializable<ImageModelSettingsClassification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ImageModelSettingsClassification>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ImageModelSettingsClassification>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageModelSettingsClassification>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TrainingCropSize))
            {
                if (TrainingCropSize != null)
                {
                    writer.WritePropertyName("trainingCropSize"u8);
                    writer.WriteNumberValue(TrainingCropSize.Value);
                }
                else
                {
                    writer.WriteNull("trainingCropSize");
                }
            }
            if (Optional.IsDefined(ValidationCropSize))
            {
                if (ValidationCropSize != null)
                {
                    writer.WritePropertyName("validationCropSize"u8);
                    writer.WriteNumberValue(ValidationCropSize.Value);
                }
                else
                {
                    writer.WriteNull("validationCropSize");
                }
            }
            if (Optional.IsDefined(ValidationResizeSize))
            {
                if (ValidationResizeSize != null)
                {
                    writer.WritePropertyName("validationResizeSize"u8);
                    writer.WriteNumberValue(ValidationResizeSize.Value);
                }
                else
                {
                    writer.WriteNull("validationResizeSize");
                }
            }
            if (Optional.IsDefined(WeightedLoss))
            {
                if (WeightedLoss != null)
                {
                    writer.WritePropertyName("weightedLoss"u8);
                    writer.WriteNumberValue(WeightedLoss.Value);
                }
                else
                {
                    writer.WriteNull("weightedLoss");
                }
            }
            if (Optional.IsDefined(AdvancedSettings))
            {
                if (AdvancedSettings != null)
                {
                    writer.WritePropertyName("advancedSettings"u8);
                    writer.WriteStringValue(AdvancedSettings);
                }
                else
                {
                    writer.WriteNull("advancedSettings");
                }
            }
            if (Optional.IsDefined(AmsGradient))
            {
                if (AmsGradient != null)
                {
                    writer.WritePropertyName("amsGradient"u8);
                    writer.WriteBooleanValue(AmsGradient.Value);
                }
                else
                {
                    writer.WriteNull("amsGradient");
                }
            }
            if (Optional.IsDefined(Augmentations))
            {
                if (Augmentations != null)
                {
                    writer.WritePropertyName("augmentations"u8);
                    writer.WriteStringValue(Augmentations);
                }
                else
                {
                    writer.WriteNull("augmentations");
                }
            }
            if (Optional.IsDefined(Beta1))
            {
                if (Beta1 != null)
                {
                    writer.WritePropertyName("beta1"u8);
                    writer.WriteNumberValue(Beta1.Value);
                }
                else
                {
                    writer.WriteNull("beta1");
                }
            }
            if (Optional.IsDefined(Beta2))
            {
                if (Beta2 != null)
                {
                    writer.WritePropertyName("beta2"u8);
                    writer.WriteNumberValue(Beta2.Value);
                }
                else
                {
                    writer.WriteNull("beta2");
                }
            }
            if (Optional.IsDefined(CheckpointFrequency))
            {
                if (CheckpointFrequency != null)
                {
                    writer.WritePropertyName("checkpointFrequency"u8);
                    writer.WriteNumberValue(CheckpointFrequency.Value);
                }
                else
                {
                    writer.WriteNull("checkpointFrequency");
                }
            }
            if (Optional.IsDefined(CheckpointModel))
            {
                if (CheckpointModel != null)
                {
                    writer.WritePropertyName("checkpointModel"u8);
                    if (CheckpointModel is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningFlowModelJobInput>)CheckpointModel).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("checkpointModel");
                }
            }
            if (Optional.IsDefined(CheckpointRunId))
            {
                if (CheckpointRunId != null)
                {
                    writer.WritePropertyName("checkpointRunId"u8);
                    writer.WriteStringValue(CheckpointRunId);
                }
                else
                {
                    writer.WriteNull("checkpointRunId");
                }
            }
            if (Optional.IsDefined(Distributed))
            {
                if (Distributed != null)
                {
                    writer.WritePropertyName("distributed"u8);
                    writer.WriteBooleanValue(Distributed.Value);
                }
                else
                {
                    writer.WriteNull("distributed");
                }
            }
            if (Optional.IsDefined(EarlyStopping))
            {
                if (EarlyStopping != null)
                {
                    writer.WritePropertyName("earlyStopping"u8);
                    writer.WriteBooleanValue(EarlyStopping.Value);
                }
                else
                {
                    writer.WriteNull("earlyStopping");
                }
            }
            if (Optional.IsDefined(EarlyStoppingDelay))
            {
                if (EarlyStoppingDelay != null)
                {
                    writer.WritePropertyName("earlyStoppingDelay"u8);
                    writer.WriteNumberValue(EarlyStoppingDelay.Value);
                }
                else
                {
                    writer.WriteNull("earlyStoppingDelay");
                }
            }
            if (Optional.IsDefined(EarlyStoppingPatience))
            {
                if (EarlyStoppingPatience != null)
                {
                    writer.WritePropertyName("earlyStoppingPatience"u8);
                    writer.WriteNumberValue(EarlyStoppingPatience.Value);
                }
                else
                {
                    writer.WriteNull("earlyStoppingPatience");
                }
            }
            if (Optional.IsDefined(EnableOnnxNormalization))
            {
                if (EnableOnnxNormalization != null)
                {
                    writer.WritePropertyName("enableOnnxNormalization"u8);
                    writer.WriteBooleanValue(EnableOnnxNormalization.Value);
                }
                else
                {
                    writer.WriteNull("enableOnnxNormalization");
                }
            }
            if (Optional.IsDefined(EvaluationFrequency))
            {
                if (EvaluationFrequency != null)
                {
                    writer.WritePropertyName("evaluationFrequency"u8);
                    writer.WriteNumberValue(EvaluationFrequency.Value);
                }
                else
                {
                    writer.WriteNull("evaluationFrequency");
                }
            }
            if (Optional.IsDefined(GradientAccumulationStep))
            {
                if (GradientAccumulationStep != null)
                {
                    writer.WritePropertyName("gradientAccumulationStep"u8);
                    writer.WriteNumberValue(GradientAccumulationStep.Value);
                }
                else
                {
                    writer.WriteNull("gradientAccumulationStep");
                }
            }
            if (Optional.IsDefined(LayersToFreeze))
            {
                if (LayersToFreeze != null)
                {
                    writer.WritePropertyName("layersToFreeze"u8);
                    writer.WriteNumberValue(LayersToFreeze.Value);
                }
                else
                {
                    writer.WriteNull("layersToFreeze");
                }
            }
            if (Optional.IsDefined(LearningRate))
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate"u8);
                    writer.WriteNumberValue(LearningRate.Value);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (Optional.IsDefined(LearningRateScheduler))
            {
                writer.WritePropertyName("learningRateScheduler"u8);
                writer.WriteStringValue(LearningRateScheduler.Value.ToString());
            }
            if (Optional.IsDefined(ModelName))
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName"u8);
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (Optional.IsDefined(Momentum))
            {
                if (Momentum != null)
                {
                    writer.WritePropertyName("momentum"u8);
                    writer.WriteNumberValue(Momentum.Value);
                }
                else
                {
                    writer.WriteNull("momentum");
                }
            }
            if (Optional.IsDefined(Nesterov))
            {
                if (Nesterov != null)
                {
                    writer.WritePropertyName("nesterov"u8);
                    writer.WriteBooleanValue(Nesterov.Value);
                }
                else
                {
                    writer.WriteNull("nesterov");
                }
            }
            if (Optional.IsDefined(NumberOfEpochs))
            {
                if (NumberOfEpochs != null)
                {
                    writer.WritePropertyName("numberOfEpochs"u8);
                    writer.WriteNumberValue(NumberOfEpochs.Value);
                }
                else
                {
                    writer.WriteNull("numberOfEpochs");
                }
            }
            if (Optional.IsDefined(NumberOfWorkers))
            {
                if (NumberOfWorkers != null)
                {
                    writer.WritePropertyName("numberOfWorkers"u8);
                    writer.WriteNumberValue(NumberOfWorkers.Value);
                }
                else
                {
                    writer.WriteNull("numberOfWorkers");
                }
            }
            if (Optional.IsDefined(Optimizer))
            {
                writer.WritePropertyName("optimizer"u8);
                writer.WriteStringValue(Optimizer.Value.ToString());
            }
            if (Optional.IsDefined(RandomSeed))
            {
                if (RandomSeed != null)
                {
                    writer.WritePropertyName("randomSeed"u8);
                    writer.WriteNumberValue(RandomSeed.Value);
                }
                else
                {
                    writer.WriteNull("randomSeed");
                }
            }
            if (Optional.IsDefined(StepLRGamma))
            {
                if (StepLRGamma != null)
                {
                    writer.WritePropertyName("stepLRGamma"u8);
                    writer.WriteNumberValue(StepLRGamma.Value);
                }
                else
                {
                    writer.WriteNull("stepLRGamma");
                }
            }
            if (Optional.IsDefined(StepLRStepSize))
            {
                if (StepLRStepSize != null)
                {
                    writer.WritePropertyName("stepLRStepSize"u8);
                    writer.WriteNumberValue(StepLRStepSize.Value);
                }
                else
                {
                    writer.WriteNull("stepLRStepSize");
                }
            }
            if (Optional.IsDefined(TrainingBatchSize))
            {
                if (TrainingBatchSize != null)
                {
                    writer.WritePropertyName("trainingBatchSize"u8);
                    writer.WriteNumberValue(TrainingBatchSize.Value);
                }
                else
                {
                    writer.WriteNull("trainingBatchSize");
                }
            }
            if (Optional.IsDefined(ValidationBatchSize))
            {
                if (ValidationBatchSize != null)
                {
                    writer.WritePropertyName("validationBatchSize"u8);
                    writer.WriteNumberValue(ValidationBatchSize.Value);
                }
                else
                {
                    writer.WriteNull("validationBatchSize");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRCycles))
            {
                if (WarmupCosineLRCycles != null)
                {
                    writer.WritePropertyName("warmupCosineLRCycles"u8);
                    writer.WriteNumberValue(WarmupCosineLRCycles.Value);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRCycles");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRWarmupEpochs))
            {
                if (WarmupCosineLRWarmupEpochs != null)
                {
                    writer.WritePropertyName("warmupCosineLRWarmupEpochs"u8);
                    writer.WriteNumberValue(WarmupCosineLRWarmupEpochs.Value);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRWarmupEpochs");
                }
            }
            if (Optional.IsDefined(WeightDecay))
            {
                if (WeightDecay != null)
                {
                    writer.WritePropertyName("weightDecay"u8);
                    writer.WriteNumberValue(WeightDecay.Value);
                }
                else
                {
                    writer.WriteNull("weightDecay");
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ImageModelSettingsClassification DeserializeImageModelSettingsClassification(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int?> trainingCropSize = default;
            Optional<int?> validationCropSize = default;
            Optional<int?> validationResizeSize = default;
            Optional<int?> weightedLoss = default;
            Optional<string> advancedSettings = default;
            Optional<bool?> amsGradient = default;
            Optional<string> augmentations = default;
            Optional<float?> beta1 = default;
            Optional<float?> beta2 = default;
            Optional<int?> checkpointFrequency = default;
            Optional<MachineLearningFlowModelJobInput> checkpointModel = default;
            Optional<string> checkpointRunId = default;
            Optional<bool?> distributed = default;
            Optional<bool?> earlyStopping = default;
            Optional<int?> earlyStoppingDelay = default;
            Optional<int?> earlyStoppingPatience = default;
            Optional<bool?> enableOnnxNormalization = default;
            Optional<int?> evaluationFrequency = default;
            Optional<int?> gradientAccumulationStep = default;
            Optional<int?> layersToFreeze = default;
            Optional<float?> learningRate = default;
            Optional<LearningRateScheduler> learningRateScheduler = default;
            Optional<string> modelName = default;
            Optional<float?> momentum = default;
            Optional<bool?> nesterov = default;
            Optional<int?> numberOfEpochs = default;
            Optional<int?> numberOfWorkers = default;
            Optional<StochasticOptimizer> optimizer = default;
            Optional<int?> randomSeed = default;
            Optional<float?> stepLRGamma = default;
            Optional<int?> stepLRStepSize = default;
            Optional<int?> trainingBatchSize = default;
            Optional<int?> validationBatchSize = default;
            Optional<float?> warmupCosineLRCycles = default;
            Optional<int?> warmupCosineLRWarmupEpochs = default;
            Optional<float?> weightDecay = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trainingCropSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingCropSize = null;
                        continue;
                    }
                    trainingCropSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationCropSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationCropSize = null;
                        continue;
                    }
                    validationCropSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationResizeSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationResizeSize = null;
                        continue;
                    }
                    validationResizeSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weightedLoss"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightedLoss = null;
                        continue;
                    }
                    weightedLoss = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("advancedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        advancedSettings = null;
                        continue;
                    }
                    advancedSettings = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amsGradient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        amsGradient = null;
                        continue;
                    }
                    amsGradient = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("augmentations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        augmentations = null;
                        continue;
                    }
                    augmentations = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta1 = null;
                        continue;
                    }
                    beta1 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("beta2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta2 = null;
                        continue;
                    }
                    beta2 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("checkpointFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointFrequency = null;
                        continue;
                    }
                    checkpointFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("checkpointModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointModel = null;
                        continue;
                    }
                    checkpointModel = MachineLearningFlowModelJobInput.DeserializeMachineLearningFlowModelJobInput(property.Value);
                    continue;
                }
                if (property.NameEquals("checkpointRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointRunId = null;
                        continue;
                    }
                    checkpointRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distributed = null;
                        continue;
                    }
                    distributed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("earlyStopping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStopping = null;
                        continue;
                    }
                    earlyStopping = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("earlyStoppingDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingDelay = null;
                        continue;
                    }
                    earlyStoppingDelay = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("earlyStoppingPatience"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingPatience = null;
                        continue;
                    }
                    earlyStoppingPatience = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableOnnxNormalization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableOnnxNormalization = null;
                        continue;
                    }
                    enableOnnxNormalization = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("evaluationFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evaluationFrequency = null;
                        continue;
                    }
                    evaluationFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gradientAccumulationStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gradientAccumulationStep = null;
                        continue;
                    }
                    gradientAccumulationStep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("layersToFreeze"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        layersToFreeze = null;
                        continue;
                    }
                    layersToFreeze = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("learningRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("learningRateScheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    learningRateScheduler = new LearningRateScheduler(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("momentum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        momentum = null;
                        continue;
                    }
                    momentum = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("nesterov"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nesterov = null;
                        continue;
                    }
                    nesterov = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("numberOfEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfEpochs = null;
                        continue;
                    }
                    numberOfEpochs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfWorkers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfWorkers = null;
                        continue;
                    }
                    numberOfWorkers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("optimizer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optimizer = new StochasticOptimizer(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("randomSeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        randomSeed = null;
                        continue;
                    }
                    randomSeed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stepLRGamma"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRGamma = null;
                        continue;
                    }
                    stepLRGamma = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stepLRStepSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRStepSize = null;
                        continue;
                    }
                    stepLRStepSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trainingBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingBatchSize = null;
                        continue;
                    }
                    trainingBatchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationBatchSize = null;
                        continue;
                    }
                    validationBatchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRCycles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRCycles = null;
                        continue;
                    }
                    warmupCosineLRCycles = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRWarmupEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRWarmupEpochs = null;
                        continue;
                    }
                    warmupCosineLRWarmupEpochs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weightDecay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightDecay = null;
                        continue;
                    }
                    weightDecay = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ImageModelSettingsClassification(advancedSettings.Value, Optional.ToNullable(amsGradient), augmentations.Value, Optional.ToNullable(beta1), Optional.ToNullable(beta2), Optional.ToNullable(checkpointFrequency), checkpointModel.Value, checkpointRunId.Value, Optional.ToNullable(distributed), Optional.ToNullable(earlyStopping), Optional.ToNullable(earlyStoppingDelay), Optional.ToNullable(earlyStoppingPatience), Optional.ToNullable(enableOnnxNormalization), Optional.ToNullable(evaluationFrequency), Optional.ToNullable(gradientAccumulationStep), Optional.ToNullable(layersToFreeze), Optional.ToNullable(learningRate), Optional.ToNullable(learningRateScheduler), modelName.Value, Optional.ToNullable(momentum), Optional.ToNullable(nesterov), Optional.ToNullable(numberOfEpochs), Optional.ToNullable(numberOfWorkers), Optional.ToNullable(optimizer), Optional.ToNullable(randomSeed), Optional.ToNullable(stepLRGamma), Optional.ToNullable(stepLRStepSize), Optional.ToNullable(trainingBatchSize), Optional.ToNullable(validationBatchSize), Optional.ToNullable(warmupCosineLRCycles), Optional.ToNullable(warmupCosineLRWarmupEpochs), Optional.ToNullable(weightDecay), Optional.ToNullable(trainingCropSize), Optional.ToNullable(validationCropSize), Optional.ToNullable(validationResizeSize), Optional.ToNullable(weightedLoss), rawData);
        }

        ImageModelSettingsClassification IModelJsonSerializable<ImageModelSettingsClassification>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageModelSettingsClassification>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeImageModelSettingsClassification(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ImageModelSettingsClassification>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageModelSettingsClassification>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ImageModelSettingsClassification IModelSerializable<ImageModelSettingsClassification>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImageModelSettingsClassification>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeImageModelSettingsClassification(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ImageModelSettingsClassification"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ImageModelSettingsClassification"/> to convert. </param>
        public static implicit operator RequestContent(ImageModelSettingsClassification model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ImageModelSettingsClassification"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ImageModelSettingsClassification(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeImageModelSettingsClassification(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
