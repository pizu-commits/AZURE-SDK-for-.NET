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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRequestHistoryProperties : IUtf8JsonSerializable, IModelJsonSerializable<LogicWorkflowRequestHistoryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicWorkflowRequestHistoryProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicWorkflowRequestHistoryProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Request))
            {
                writer.WritePropertyName("request"u8);
                if (Request is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LogicWorkflowRequest>)Request).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Response))
            {
                writer.WritePropertyName("response"u8);
                if (Response is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LogicWorkflowResponse>)Response).Serialize(writer, options);
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

        internal static LogicWorkflowRequestHistoryProperties DeserializeLogicWorkflowRequestHistoryProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<LogicWorkflowRequest> request = default;
            Optional<LogicWorkflowResponse> response = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("request"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    request = LogicWorkflowRequest.DeserializeLogicWorkflowRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = LogicWorkflowResponse.DeserializeLogicWorkflowResponse(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicWorkflowRequestHistoryProperties(Optional.ToNullable(startTime), Optional.ToNullable(endTime), request.Value, response.Value, rawData);
        }

        LogicWorkflowRequestHistoryProperties IModelJsonSerializable<LogicWorkflowRequestHistoryProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRequestHistoryProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicWorkflowRequestHistoryProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicWorkflowRequestHistoryProperties IModelSerializable<LogicWorkflowRequestHistoryProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowRequestHistoryProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogicWorkflowRequestHistoryProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogicWorkflowRequestHistoryProperties"/> to convert. </param>
        public static implicit operator RequestContent(LogicWorkflowRequestHistoryProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogicWorkflowRequestHistoryProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogicWorkflowRequestHistoryProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicWorkflowRequestHistoryProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
