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
    public partial class AutoMLVertical : IUtf8JsonSerializable, IModelJsonSerializable<AutoMLVertical>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutoMLVertical>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutoMLVertical>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoMLVertical>(this, options.Format);

            writer.WriteStartObject();
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

        internal static AutoMLVertical DeserializeAutoMLVertical(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("taskType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Classification": return ClassificationTask.DeserializeClassificationTask(element);
                    case "Forecasting": return MachineLearningForecasting.DeserializeMachineLearningForecasting(element);
                    case "ImageClassification": return ImageClassification.DeserializeImageClassification(element);
                    case "ImageClassificationMultilabel": return ImageClassificationMultilabel.DeserializeImageClassificationMultilabel(element);
                    case "ImageInstanceSegmentation": return ImageInstanceSegmentation.DeserializeImageInstanceSegmentation(element);
                    case "ImageObjectDetection": return ImageObjectDetection.DeserializeImageObjectDetection(element);
                    case "Regression": return AutoMLVerticalRegression.DeserializeAutoMLVerticalRegression(element);
                    case "TextClassification": return TextClassification.DeserializeTextClassification(element);
                    case "TextClassificationMultilabel": return TextClassificationMultilabel.DeserializeTextClassificationMultilabel(element);
                    case "TextNER": return TextNer.DeserializeTextNer(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<MachineLearningLogVerbosity> logVerbosity = default;
            Optional<string> targetColumnName = default;
            TaskType taskType = default;
            MachineLearningTableJobInput trainingData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownAutoMLVertical(Optional.ToNullable(logVerbosity), targetColumnName.Value, taskType, trainingData, rawData);
        }

        AutoMLVertical IModelJsonSerializable<AutoMLVertical>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoMLVertical>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoMLVertical(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutoMLVertical>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoMLVertical>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutoMLVertical IModelSerializable<AutoMLVertical>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoMLVertical>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutoMLVertical(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutoMLVertical"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutoMLVertical"/> to convert. </param>
        public static implicit operator RequestContent(AutoMLVertical model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutoMLVertical"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutoMLVertical(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutoMLVertical(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
