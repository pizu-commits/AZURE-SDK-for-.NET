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
    public partial class BayesianSamplingAlgorithm : IUtf8JsonSerializable, IModelJsonSerializable<BayesianSamplingAlgorithm>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BayesianSamplingAlgorithm>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BayesianSamplingAlgorithm>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BayesianSamplingAlgorithm>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("samplingAlgorithmType"u8);
            writer.WriteStringValue(SamplingAlgorithmType.ToString());
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

        internal static BayesianSamplingAlgorithm DeserializeBayesianSamplingAlgorithm(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SamplingAlgorithmType samplingAlgorithmType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("samplingAlgorithmType"u8))
                {
                    samplingAlgorithmType = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BayesianSamplingAlgorithm(samplingAlgorithmType, rawData);
        }

        BayesianSamplingAlgorithm IModelJsonSerializable<BayesianSamplingAlgorithm>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BayesianSamplingAlgorithm>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBayesianSamplingAlgorithm(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BayesianSamplingAlgorithm>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BayesianSamplingAlgorithm>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BayesianSamplingAlgorithm IModelSerializable<BayesianSamplingAlgorithm>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BayesianSamplingAlgorithm>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBayesianSamplingAlgorithm(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BayesianSamplingAlgorithm"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BayesianSamplingAlgorithm"/> to convert. </param>
        public static implicit operator RequestContent(BayesianSamplingAlgorithm model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BayesianSamplingAlgorithm"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BayesianSamplingAlgorithm(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBayesianSamplingAlgorithm(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
