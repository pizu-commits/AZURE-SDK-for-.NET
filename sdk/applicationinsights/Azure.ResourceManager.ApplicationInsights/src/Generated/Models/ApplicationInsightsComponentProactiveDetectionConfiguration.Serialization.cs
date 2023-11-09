// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentProactiveDetectionConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentProactiveDetectionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentProactiveDetectionConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ApplicationInsightsComponentProactiveDetectionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("Name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("Enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(SendEmailsToSubscriptionOwners))
            {
                writer.WritePropertyName("SendEmailsToSubscriptionOwners"u8);
                writer.WriteBooleanValue(SendEmailsToSubscriptionOwners.Value);
            }
            if (Optional.IsCollectionDefined(CustomEmails))
            {
                writer.WritePropertyName("CustomEmails"u8);
                writer.WriteStartArray();
                foreach (var item in CustomEmails)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastUpdatedTime))
            {
                writer.WritePropertyName("LastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedTime);
            }
            if (Optional.IsDefined(RuleDefinitions))
            {
                writer.WritePropertyName("RuleDefinitions"u8);
                writer.WriteObjectValue(RuleDefinitions);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ApplicationInsightsComponentProactiveDetectionConfiguration IJsonModel<ApplicationInsightsComponentProactiveDetectionConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentProactiveDetectionConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentProactiveDetectionConfiguration DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<bool> enabled = default;
            Optional<bool> sendEmailsToSubscriptionOwners = default;
            Optional<IList<string>> customEmails = default;
            Optional<string> lastUpdatedTime = default;
            Optional<ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions> ruleDefinitions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("SendEmailsToSubscriptionOwners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendEmailsToSubscriptionOwners = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("CustomEmails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    customEmails = array;
                    continue;
                }
                if (property.NameEquals("LastUpdatedTime"u8))
                {
                    lastUpdatedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("RuleDefinitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ruleDefinitions = ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions.DeserializeApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentProactiveDetectionConfiguration(name.Value, Optional.ToNullable(enabled), Optional.ToNullable(sendEmailsToSubscriptionOwners), Optional.ToList(customEmails), lastUpdatedTime.Value, ruleDefinitions.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ApplicationInsightsComponentProactiveDetectionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentProactiveDetectionConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplicationInsightsComponentProactiveDetectionConfiguration IModel<ApplicationInsightsComponentProactiveDetectionConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentProactiveDetectionConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ApplicationInsightsComponentProactiveDetectionConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
