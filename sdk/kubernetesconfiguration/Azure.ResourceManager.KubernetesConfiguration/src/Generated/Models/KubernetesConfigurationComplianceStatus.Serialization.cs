// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesConfigurationComplianceStatus : IUtf8JsonSerializable, IJsonModel<KubernetesConfigurationComplianceStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesConfigurationComplianceStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesConfigurationComplianceStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesConfigurationComplianceStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesConfigurationComplianceStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState.Value.ToString());
            }
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
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        KubernetesConfigurationComplianceStatus IJsonModel<KubernetesConfigurationComplianceStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesConfigurationComplianceStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesConfigurationComplianceStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesConfigurationComplianceStatus(document.RootElement, options);
        }

        internal static KubernetesConfigurationComplianceStatus DeserializeKubernetesConfigurationComplianceStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KubernetesConfigurationComplianceStateType> complianceState = default;
            Optional<DateTimeOffset> lastConfigApplied = default;
            Optional<string> message = default;
            Optional<KubernetesConfigurationMesageLevel> messageLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesConfigurationComplianceStatus(Optional.ToNullable(complianceState), Optional.ToNullable(lastConfigApplied), message.Value, Optional.ToNullable(messageLevel), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesConfigurationComplianceStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesConfigurationComplianceStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesConfigurationComplianceStatus)} does not support '{options.Format}' format.");
            }
        }

        KubernetesConfigurationComplianceStatus IPersistableModel<KubernetesConfigurationComplianceStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesConfigurationComplianceStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesConfigurationComplianceStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesConfigurationComplianceStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesConfigurationComplianceStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
