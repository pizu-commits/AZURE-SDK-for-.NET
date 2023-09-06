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
    public partial class MachineLearningJobOutput : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningJobOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningJobOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningJobOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningJobOutput>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobOutputType"u8);
            writer.WriteStringValue(JobOutputType.ToString());
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

        internal static MachineLearningJobOutput DeserializeMachineLearningJobOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobOutputType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "custom_model": return MachineLearningCustomModelJobOutput.DeserializeMachineLearningCustomModelJobOutput(element);
                    case "mlflow_model": return MachineLearningFlowModelJobOutput.DeserializeMachineLearningFlowModelJobOutput(element);
                    case "mltable": return MachineLearningTableJobOutput.DeserializeMachineLearningTableJobOutput(element);
                    case "triton_model": return MachineLearningTritonModelJobOutput.DeserializeMachineLearningTritonModelJobOutput(element);
                    case "uri_file": return MachineLearningUriFileJobOutput.DeserializeMachineLearningUriFileJobOutput(element);
                    case "uri_folder": return MachineLearningUriFolderJobOutput.DeserializeMachineLearningUriFolderJobOutput(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<string> description = default;
            JobOutputType jobOutputType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutputType"u8))
                {
                    jobOutputType = new JobOutputType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownJobOutput(description.Value, jobOutputType, rawData);
        }

        MachineLearningJobOutput IModelJsonSerializable<MachineLearningJobOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningJobOutput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningJobOutput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningJobOutput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningJobOutput IModelSerializable<MachineLearningJobOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningJobOutput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningJobOutput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningJobOutput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningJobOutput"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningJobOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningJobOutput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningJobOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningJobOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
