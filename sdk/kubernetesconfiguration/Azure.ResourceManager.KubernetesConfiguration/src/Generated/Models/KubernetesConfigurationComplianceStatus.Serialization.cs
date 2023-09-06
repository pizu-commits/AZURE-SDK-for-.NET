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

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesConfigurationComplianceStatus : IUtf8JsonSerializable, IModelJsonSerializable<KubernetesConfigurationComplianceStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KubernetesConfigurationComplianceStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KubernetesConfigurationComplianceStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesConfigurationComplianceStatus>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LastConfigAppliedOn))
            {
                writer.WritePropertyName("lastConfigApplied"u8);
                writer.WriteStringValue(LastConfigAppliedOn.Value, "O");
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(MessageLevel))
            {
                writer.WritePropertyName("messageLevel"u8);
                writer.WriteStringValue(MessageLevel.Value.ToString());
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

        internal static KubernetesConfigurationComplianceStatus DeserializeKubernetesConfigurationComplianceStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KubernetesConfigurationComplianceStateType> complianceState = default;
            Optional<DateTimeOffset> lastConfigApplied = default;
            Optional<string> message = default;
            Optional<KubernetesConfigurationMesageLevel> messageLevel = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceState = new KubernetesConfigurationComplianceStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastConfigApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConfigApplied = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageLevel = new KubernetesConfigurationMesageLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KubernetesConfigurationComplianceStatus(Optional.ToNullable(complianceState), Optional.ToNullable(lastConfigApplied), message.Value, Optional.ToNullable(messageLevel), rawData);
        }

        KubernetesConfigurationComplianceStatus IModelJsonSerializable<KubernetesConfigurationComplianceStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesConfigurationComplianceStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesConfigurationComplianceStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KubernetesConfigurationComplianceStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesConfigurationComplianceStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KubernetesConfigurationComplianceStatus IModelSerializable<KubernetesConfigurationComplianceStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesConfigurationComplianceStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKubernetesConfigurationComplianceStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KubernetesConfigurationComplianceStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KubernetesConfigurationComplianceStatus"/> to convert. </param>
        public static implicit operator RequestContent(KubernetesConfigurationComplianceStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KubernetesConfigurationComplianceStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KubernetesConfigurationComplianceStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKubernetesConfigurationComplianceStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
