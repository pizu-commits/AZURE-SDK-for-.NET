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
    public partial class TextClassification : IUtf8JsonSerializable, IModelJsonSerializable<TextClassification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TextClassification>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TextClassification>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TextClassification>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(FeaturizationSettings))
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings"u8);
                    if (FeaturizationSettings is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NlpVerticalFeaturizationSettings>)FeaturizationSettings).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
            if (Optional.IsDefined(LimitSettings))
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings"u8);
                    if (LimitSettings is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NlpVerticalLimitSettings>)LimitSettings).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    if (ValidationData is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningTableJobInput>)ValidationData).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            if (Optional.IsDefined(TargetColumnName))
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            if (TrainingData is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<MachineLearningTableJobInput>)TrainingData).Serialize(writer, options);
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

        internal static TextClassification DeserializeTextClassification(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ClassificationPrimaryMetric> primaryMetric = default;
            Optional<NlpVerticalFeaturizationSettings> featurizationSettings = default;
            Optional<NlpVerticalLimitSettings> limitSettings = default;
            Optional<MachineLearningTableJobInput> validationData = default;
            Optional<MachineLearningLogVerbosity> logVerbosity = default;
            Optional<string> targetColumnName = default;
            TaskType taskType = default;
            MachineLearningTableJobInput trainingData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new ClassificationPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("featurizationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = NlpVerticalFeaturizationSettings.DeserializeNlpVerticalFeaturizationSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = NlpVerticalLimitSettings.DeserializeNlpVerticalLimitSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value);
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TextClassification(Optional.ToNullable(logVerbosity), targetColumnName.Value, taskType, trainingData, Optional.ToNullable(primaryMetric), featurizationSettings.Value, limitSettings.Value, validationData.Value, rawData);
        }

        TextClassification IModelJsonSerializable<TextClassification>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TextClassification>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTextClassification(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TextClassification>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TextClassification>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TextClassification IModelSerializable<TextClassification>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TextClassification>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTextClassification(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TextClassification"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TextClassification"/> to convert. </param>
        public static implicit operator RequestContent(TextClassification model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TextClassification"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TextClassification(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTextClassification(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
