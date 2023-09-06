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

namespace Azure.Communication.CallAutomation
{
    public partial class ContinuousDtmfRecognitionToneReceived : IUtf8JsonSerializable, IModelJsonSerializable<ContinuousDtmfRecognitionToneReceived>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContinuousDtmfRecognitionToneReceived>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContinuousDtmfRecognitionToneReceived>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContinuousDtmfRecognitionToneReceived>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ToneInfo))
            {
                writer.WritePropertyName("toneInfo"u8);
                if (ToneInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ToneInfo>)ToneInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CallConnectionId))
            {
                writer.WritePropertyName("callConnectionId"u8);
                writer.WriteStringValue(CallConnectionId);
            }
            if (Optional.IsDefined(ServerCallId))
            {
                writer.WritePropertyName("serverCallId"u8);
                writer.WriteStringValue(ServerCallId);
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(ResultInformation))
            {
                writer.WritePropertyName("resultInformation"u8);
                if (ResultInformation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResultInformation>)ResultInformation).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
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

        internal static ContinuousDtmfRecognitionToneReceived DeserializeContinuousDtmfRecognitionToneReceived(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ToneInfo> toneInfo = default;
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            Optional<ResultInformation> resultInformation = default;
            Optional<string> operationContext = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("toneInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toneInfo = ToneInfo.DeserializeToneInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContinuousDtmfRecognitionToneReceived(toneInfo.Value, callConnectionId.Value, serverCallId.Value, correlationId.Value, resultInformation.Value, operationContext.Value, rawData);
        }

        ContinuousDtmfRecognitionToneReceived IModelJsonSerializable<ContinuousDtmfRecognitionToneReceived>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContinuousDtmfRecognitionToneReceived>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContinuousDtmfRecognitionToneReceived(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContinuousDtmfRecognitionToneReceived>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContinuousDtmfRecognitionToneReceived>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContinuousDtmfRecognitionToneReceived IModelSerializable<ContinuousDtmfRecognitionToneReceived>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContinuousDtmfRecognitionToneReceived>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContinuousDtmfRecognitionToneReceived(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContinuousDtmfRecognitionToneReceived"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContinuousDtmfRecognitionToneReceived"/> to convert. </param>
        public static implicit operator RequestContent(ContinuousDtmfRecognitionToneReceived model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContinuousDtmfRecognitionToneReceived"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContinuousDtmfRecognitionToneReceived(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContinuousDtmfRecognitionToneReceived(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
