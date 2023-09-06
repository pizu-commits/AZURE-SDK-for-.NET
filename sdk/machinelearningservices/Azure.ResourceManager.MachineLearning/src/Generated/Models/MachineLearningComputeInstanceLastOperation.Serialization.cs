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
    public partial class MachineLearningComputeInstanceLastOperation : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningComputeInstanceLastOperation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningComputeInstanceLastOperation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningComputeInstanceLastOperation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceLastOperation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OperationName))
            {
                writer.WritePropertyName("operationName"u8);
                writer.WriteStringValue(OperationName.Value.ToString());
            }
            if (Optional.IsDefined(OperationOn))
            {
                writer.WritePropertyName("operationTime"u8);
                writer.WriteStringValue(OperationOn.Value, "O");
            }
            if (Optional.IsDefined(OperationStatus))
            {
                writer.WritePropertyName("operationStatus"u8);
                writer.WriteStringValue(OperationStatus.Value.ToString());
            }
            if (Optional.IsDefined(OperationTrigger))
            {
                writer.WritePropertyName("operationTrigger"u8);
                writer.WriteStringValue(OperationTrigger.Value.ToString());
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

        internal static MachineLearningComputeInstanceLastOperation DeserializeMachineLearningComputeInstanceLastOperation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningOperationName> operationName = default;
            Optional<DateTimeOffset> operationTime = default;
            Optional<MachineLearningOperationStatus> operationStatus = default;
            Optional<MachineLearningOperationTrigger> operationTrigger = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationName = new MachineLearningOperationName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("operationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationStatus = new MachineLearningOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationTrigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationTrigger = new MachineLearningOperationTrigger(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningComputeInstanceLastOperation(Optional.ToNullable(operationName), Optional.ToNullable(operationTime), Optional.ToNullable(operationStatus), Optional.ToNullable(operationTrigger), rawData);
        }

        MachineLearningComputeInstanceLastOperation IModelJsonSerializable<MachineLearningComputeInstanceLastOperation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceLastOperation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceLastOperation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningComputeInstanceLastOperation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceLastOperation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningComputeInstanceLastOperation IModelSerializable<MachineLearningComputeInstanceLastOperation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceLastOperation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningComputeInstanceLastOperation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningComputeInstanceLastOperation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningComputeInstanceLastOperation"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningComputeInstanceLastOperation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningComputeInstanceLastOperation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningComputeInstanceLastOperation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningComputeInstanceLastOperation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
