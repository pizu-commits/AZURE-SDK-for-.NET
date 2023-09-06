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
    public partial class MachineLearningFlowModelJobInput : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningFlowModelJobInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningFlowModelJobInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningFlowModelJobInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFlowModelJobInput>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
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
            writer.WritePropertyName("jobInputType"u8);
            writer.WriteStringValue(JobInputType.ToString());
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

        internal static MachineLearningFlowModelJobInput DeserializeMachineLearningFlowModelJobInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningInputDeliveryMode> mode = default;
            Uri uri = default;
            Optional<string> description = default;
            JobInputType jobInputType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MachineLearningInputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("jobInputType"u8))
                {
                    jobInputType = new JobInputType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningFlowModelJobInput(description.Value, jobInputType, Optional.ToNullable(mode), uri, rawData);
        }

        MachineLearningFlowModelJobInput IModelJsonSerializable<MachineLearningFlowModelJobInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFlowModelJobInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningFlowModelJobInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningFlowModelJobInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFlowModelJobInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningFlowModelJobInput IModelSerializable<MachineLearningFlowModelJobInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFlowModelJobInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningFlowModelJobInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningFlowModelJobInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningFlowModelJobInput"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningFlowModelJobInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningFlowModelJobInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningFlowModelJobInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningFlowModelJobInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
