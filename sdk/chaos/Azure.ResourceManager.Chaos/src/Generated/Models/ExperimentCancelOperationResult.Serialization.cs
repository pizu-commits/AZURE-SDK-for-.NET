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

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ExperimentCancelOperationResult : IUtf8JsonSerializable, IModelJsonSerializable<ExperimentCancelOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExperimentCancelOperationResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExperimentCancelOperationResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentCancelOperationResult>(this, options.Format);

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

        internal static ExperimentCancelOperationResult DeserializeExperimentCancelOperationResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> statusUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusUrl"u8))
                {
                    statusUrl = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExperimentCancelOperationResult(name.Value, statusUrl.Value, rawData);
        }

        ExperimentCancelOperationResult IModelJsonSerializable<ExperimentCancelOperationResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentCancelOperationResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExperimentCancelOperationResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExperimentCancelOperationResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentCancelOperationResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExperimentCancelOperationResult IModelSerializable<ExperimentCancelOperationResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExperimentCancelOperationResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExperimentCancelOperationResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExperimentCancelOperationResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExperimentCancelOperationResult"/> to convert. </param>
        public static implicit operator RequestContent(ExperimentCancelOperationResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExperimentCancelOperationResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExperimentCancelOperationResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExperimentCancelOperationResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
