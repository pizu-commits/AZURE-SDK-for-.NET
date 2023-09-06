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
    public partial class MachineLearningFeaturizationSettings : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningFeaturizationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningFeaturizationSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningFeaturizationSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFeaturizationSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DatasetLanguage))
            {
                if (DatasetLanguage != null)
                {
                    writer.WritePropertyName("datasetLanguage"u8);
                    writer.WriteStringValue(DatasetLanguage);
                }
                else
                {
                    writer.WriteNull("datasetLanguage");
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

        internal static MachineLearningFeaturizationSettings DeserializeMachineLearningFeaturizationSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> datasetLanguage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasetLanguage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        datasetLanguage = null;
                        continue;
                    }
                    datasetLanguage = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningFeaturizationSettings(datasetLanguage.Value, rawData);
        }

        MachineLearningFeaturizationSettings IModelJsonSerializable<MachineLearningFeaturizationSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFeaturizationSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningFeaturizationSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningFeaturizationSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFeaturizationSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningFeaturizationSettings IModelSerializable<MachineLearningFeaturizationSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningFeaturizationSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningFeaturizationSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningFeaturizationSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningFeaturizationSettings"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningFeaturizationSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningFeaturizationSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningFeaturizationSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningFeaturizationSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
