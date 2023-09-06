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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class DirectLineSpeechChannelProperties : IUtf8JsonSerializable, IModelJsonSerializable<DirectLineSpeechChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DirectLineSpeechChannelProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DirectLineSpeechChannelProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DirectLineSpeechChannelProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CognitiveServiceResourceId))
            {
                writer.WritePropertyName("cognitiveServiceResourceId"u8);
                writer.WriteStringValue(CognitiveServiceResourceId);
            }
            if (Optional.IsDefined(CognitiveServiceRegion))
            {
                if (CognitiveServiceRegion != null)
                {
                    writer.WritePropertyName("cognitiveServiceRegion"u8);
                    writer.WriteStringValue(CognitiveServiceRegion);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceRegion");
                }
            }
            if (Optional.IsDefined(CognitiveServiceSubscriptionKey))
            {
                if (CognitiveServiceSubscriptionKey != null)
                {
                    writer.WritePropertyName("cognitiveServiceSubscriptionKey"u8);
                    writer.WriteStringValue(CognitiveServiceSubscriptionKey);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceSubscriptionKey");
                }
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(CustomVoiceDeploymentId))
            {
                writer.WritePropertyName("customVoiceDeploymentId"u8);
                writer.WriteStringValue(CustomVoiceDeploymentId);
            }
            if (Optional.IsDefined(CustomSpeechModelId))
            {
                writer.WritePropertyName("customSpeechModelId"u8);
                writer.WriteStringValue(CustomSpeechModelId);
            }
            if (Optional.IsDefined(IsDefaultBotForCogSvcAccount))
            {
                writer.WritePropertyName("isDefaultBotForCogSvcAccount"u8);
                writer.WriteBooleanValue(IsDefaultBotForCogSvcAccount.Value);
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

        internal static DirectLineSpeechChannelProperties DeserializeDirectLineSpeechChannelProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> cognitiveServiceResourceId = default;
            Optional<string> cognitiveServiceRegion = default;
            Optional<string> cognitiveServiceSubscriptionKey = default;
            Optional<bool> isEnabled = default;
            Optional<string> customVoiceDeploymentId = default;
            Optional<string> customSpeechModelId = default;
            Optional<bool> isDefaultBotForCogSvcAccount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cognitiveServiceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cognitiveServiceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cognitiveServiceRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceRegion = null;
                        continue;
                    }
                    cognitiveServiceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceSubscriptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceSubscriptionKey = null;
                        continue;
                    }
                    cognitiveServiceSubscriptionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customVoiceDeploymentId"u8))
                {
                    customVoiceDeploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customSpeechModelId"u8))
                {
                    customSpeechModelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefaultBotForCogSvcAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefaultBotForCogSvcAccount = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DirectLineSpeechChannelProperties(cognitiveServiceResourceId.Value, cognitiveServiceRegion.Value, cognitiveServiceSubscriptionKey.Value, Optional.ToNullable(isEnabled), customVoiceDeploymentId.Value, customSpeechModelId.Value, Optional.ToNullable(isDefaultBotForCogSvcAccount), rawData);
        }

        DirectLineSpeechChannelProperties IModelJsonSerializable<DirectLineSpeechChannelProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DirectLineSpeechChannelProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectLineSpeechChannelProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DirectLineSpeechChannelProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DirectLineSpeechChannelProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DirectLineSpeechChannelProperties IModelSerializable<DirectLineSpeechChannelProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DirectLineSpeechChannelProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDirectLineSpeechChannelProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DirectLineSpeechChannelProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DirectLineSpeechChannelProperties"/> to convert. </param>
        public static implicit operator RequestContent(DirectLineSpeechChannelProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DirectLineSpeechChannelProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DirectLineSpeechChannelProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDirectLineSpeechChannelProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
