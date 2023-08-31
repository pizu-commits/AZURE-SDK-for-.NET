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
    public partial class BanditPolicy : IUtf8JsonSerializable, IModelJsonSerializable<BanditPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BanditPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BanditPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BanditPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SlackAmount))
            {
                writer.WritePropertyName("slackAmount"u8);
                writer.WriteNumberValue(SlackAmount.Value);
            }
            if (Optional.IsDefined(SlackFactor))
            {
                writer.WritePropertyName("slackFactor"u8);
                writer.WriteNumberValue(SlackFactor.Value);
            }
            if (Optional.IsDefined(DelayEvaluation))
            {
                writer.WritePropertyName("delayEvaluation"u8);
                writer.WriteNumberValue(DelayEvaluation.Value);
            }
            if (Optional.IsDefined(EvaluationInterval))
            {
                writer.WritePropertyName("evaluationInterval"u8);
                writer.WriteNumberValue(EvaluationInterval.Value);
            }
            writer.WritePropertyName("policyType"u8);
            writer.WriteStringValue(PolicyType.ToString());
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

        internal static BanditPolicy DeserializeBanditPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> slackAmount = default;
            Optional<float> slackFactor = default;
            Optional<int> delayEvaluation = default;
            Optional<int> evaluationInterval = default;
            EarlyTerminationPolicyType policyType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("slackAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slackAmount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("slackFactor"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slackFactor = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("delayEvaluation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delayEvaluation = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("evaluationInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyType"u8))
                {
                    policyType = new EarlyTerminationPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BanditPolicy(Optional.ToNullable(delayEvaluation), Optional.ToNullable(evaluationInterval), policyType, Optional.ToNullable(slackAmount), Optional.ToNullable(slackFactor), rawData);
        }

        BanditPolicy IModelJsonSerializable<BanditPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BanditPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBanditPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BanditPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BanditPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BanditPolicy IModelSerializable<BanditPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BanditPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBanditPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BanditPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BanditPolicy"/> to convert. </param>
        public static implicit operator RequestContent(BanditPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BanditPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BanditPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBanditPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
