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
    public partial class LogicWorkflowResponse : IUtf8JsonSerializable, IModelJsonSerializable<LogicWorkflowResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicWorkflowResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicWorkflowResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Headers);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Headers.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(StatusCode))
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteNumberValue(StatusCode.Value);
            }
            if (Optional.IsDefined(BodyLink))
            {
                writer.WritePropertyName("bodyLink"u8);
                if (BodyLink is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LogicContentLink>)BodyLink).Serialize(writer, options);
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

        internal static LogicWorkflowResponse DeserializeLogicWorkflowResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> headers = default;
            Optional<int> statusCode = default;
            Optional<LogicContentLink> bodyLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    headers = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bodyLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bodyLink = LogicContentLink.DeserializeLogicContentLink(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicWorkflowResponse(headers.Value, Optional.ToNullable(statusCode), bodyLink.Value, rawData);
        }

        LogicWorkflowResponse IModelJsonSerializable<LogicWorkflowResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicWorkflowResponse>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicWorkflowResponse IModelSerializable<LogicWorkflowResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogicWorkflowResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogicWorkflowResponse"/> to convert. </param>
        public static implicit operator RequestContent(LogicWorkflowResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogicWorkflowResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogicWorkflowResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicWorkflowResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
