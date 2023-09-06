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
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Models
{
    internal partial class ExperimentStatusListResult : IUtf8JsonSerializable, IModelJsonSerializable<ExperimentStatusListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExperimentStatusListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExperimentStatusListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentStatusListResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ExperimentStatusListResult DeserializeExperimentStatusListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ExperimentStatusData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExperimentStatusData> array = new List<ExperimentStatusData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExperimentStatusData.DeserializeExperimentStatusData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExperimentStatusListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        ExperimentStatusListResult IModelJsonSerializable<ExperimentStatusListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentStatusListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExperimentStatusListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExperimentStatusListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentStatusListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExperimentStatusListResult IModelSerializable<ExperimentStatusListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentStatusListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExperimentStatusListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExperimentStatusListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExperimentStatusListResult"/> to convert. </param>
        public static implicit operator RequestContent(ExperimentStatusListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExperimentStatusListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExperimentStatusListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExperimentStatusListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
