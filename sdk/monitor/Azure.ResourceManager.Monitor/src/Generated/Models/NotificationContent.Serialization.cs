// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class NotificationContent : IUtf8JsonSerializable, IJsonModel<NotificationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NotificationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("alertType"u8);
            writer.WriteStringValue(AlertType);
            if (Optional.IsCollectionDefined(EmailReceivers))
            {
                writer.WritePropertyName("emailReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in EmailReceivers)
                {
                    writer.WriteObjectValue<MonitorEmailReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SmsReceivers))
            {
                writer.WritePropertyName("smsReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in SmsReceivers)
                {
                    writer.WriteObjectValue<MonitorSmsReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WebhookReceivers))
            {
                writer.WritePropertyName("webhookReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in WebhookReceivers)
                {
                    writer.WriteObjectValue<MonitorWebhookReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ItsmReceivers))
            {
                writer.WritePropertyName("itsmReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in ItsmReceivers)
                {
                    writer.WriteObjectValue<MonitorItsmReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AzureAppPushReceivers))
            {
                writer.WritePropertyName("azureAppPushReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in AzureAppPushReceivers)
                {
                    writer.WriteObjectValue<MonitorAzureAppPushReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AutomationRunbookReceivers))
            {
                writer.WritePropertyName("automationRunbookReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in AutomationRunbookReceivers)
                {
                    writer.WriteObjectValue<MonitorAutomationRunbookReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VoiceReceivers))
            {
                writer.WritePropertyName("voiceReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in VoiceReceivers)
                {
                    writer.WriteObjectValue<MonitorVoiceReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LogicAppReceivers))
            {
                writer.WritePropertyName("logicAppReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in LogicAppReceivers)
                {
                    writer.WriteObjectValue<MonitorLogicAppReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AzureFunctionReceivers))
            {
                writer.WritePropertyName("azureFunctionReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in AzureFunctionReceivers)
                {
                    writer.WriteObjectValue<MonitorAzureFunctionReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ArmRoleReceivers))
            {
                writer.WritePropertyName("armRoleReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in ArmRoleReceivers)
                {
                    writer.WriteObjectValue<MonitorArmRoleReceiver>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EventHubReceivers))
            {
                writer.WritePropertyName("eventHubReceivers"u8);
                writer.WriteStartArray();
                foreach (var item in EventHubReceivers)
                {
                    writer.WriteObjectValue<MonitorEventHubReceiver>(item, options);
                }
                writer.WriteEndArray();
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

        NotificationContent IJsonModel<NotificationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationContent(document.RootElement, options);
        }

        internal static NotificationContent DeserializeNotificationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string alertType = default;
            IList<MonitorEmailReceiver> emailReceivers = default;
            IList<MonitorSmsReceiver> smsReceivers = default;
            IList<MonitorWebhookReceiver> webhookReceivers = default;
            IList<MonitorItsmReceiver> itsmReceivers = default;
            IList<MonitorAzureAppPushReceiver> azureAppPushReceivers = default;
            IList<MonitorAutomationRunbookReceiver> automationRunbookReceivers = default;
            IList<MonitorVoiceReceiver> voiceReceivers = default;
            IList<MonitorLogicAppReceiver> logicAppReceivers = default;
            IList<MonitorAzureFunctionReceiver> azureFunctionReceivers = default;
            IList<MonitorArmRoleReceiver> armRoleReceivers = default;
            IList<MonitorEventHubReceiver> eventHubReceivers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertType"u8))
                {
                    alertType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorEmailReceiver> array = new List<MonitorEmailReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorEmailReceiver.DeserializeMonitorEmailReceiver(item, options));
                    }
                    emailReceivers = array;
                    continue;
                }
                if (property.NameEquals("smsReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorSmsReceiver> array = new List<MonitorSmsReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorSmsReceiver.DeserializeMonitorSmsReceiver(item, options));
                    }
                    smsReceivers = array;
                    continue;
                }
                if (property.NameEquals("webhookReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorWebhookReceiver> array = new List<MonitorWebhookReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorWebhookReceiver.DeserializeMonitorWebhookReceiver(item, options));
                    }
                    webhookReceivers = array;
                    continue;
                }
                if (property.NameEquals("itsmReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorItsmReceiver> array = new List<MonitorItsmReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorItsmReceiver.DeserializeMonitorItsmReceiver(item, options));
                    }
                    itsmReceivers = array;
                    continue;
                }
                if (property.NameEquals("azureAppPushReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorAzureAppPushReceiver> array = new List<MonitorAzureAppPushReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorAzureAppPushReceiver.DeserializeMonitorAzureAppPushReceiver(item, options));
                    }
                    azureAppPushReceivers = array;
                    continue;
                }
                if (property.NameEquals("automationRunbookReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorAutomationRunbookReceiver> array = new List<MonitorAutomationRunbookReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorAutomationRunbookReceiver.DeserializeMonitorAutomationRunbookReceiver(item, options));
                    }
                    automationRunbookReceivers = array;
                    continue;
                }
                if (property.NameEquals("voiceReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorVoiceReceiver> array = new List<MonitorVoiceReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorVoiceReceiver.DeserializeMonitorVoiceReceiver(item, options));
                    }
                    voiceReceivers = array;
                    continue;
                }
                if (property.NameEquals("logicAppReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorLogicAppReceiver> array = new List<MonitorLogicAppReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorLogicAppReceiver.DeserializeMonitorLogicAppReceiver(item, options));
                    }
                    logicAppReceivers = array;
                    continue;
                }
                if (property.NameEquals("azureFunctionReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorAzureFunctionReceiver> array = new List<MonitorAzureFunctionReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorAzureFunctionReceiver.DeserializeMonitorAzureFunctionReceiver(item, options));
                    }
                    azureFunctionReceivers = array;
                    continue;
                }
                if (property.NameEquals("armRoleReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorArmRoleReceiver> array = new List<MonitorArmRoleReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorArmRoleReceiver.DeserializeMonitorArmRoleReceiver(item, options));
                    }
                    armRoleReceivers = array;
                    continue;
                }
                if (property.NameEquals("eventHubReceivers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorEventHubReceiver> array = new List<MonitorEventHubReceiver>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorEventHubReceiver.DeserializeMonitorEventHubReceiver(item, options));
                    }
                    eventHubReceivers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NotificationContent(
                alertType,
                emailReceivers ?? new ChangeTrackingList<MonitorEmailReceiver>(),
                smsReceivers ?? new ChangeTrackingList<MonitorSmsReceiver>(),
                webhookReceivers ?? new ChangeTrackingList<MonitorWebhookReceiver>(),
                itsmReceivers ?? new ChangeTrackingList<MonitorItsmReceiver>(),
                azureAppPushReceivers ?? new ChangeTrackingList<MonitorAzureAppPushReceiver>(),
                automationRunbookReceivers ?? new ChangeTrackingList<MonitorAutomationRunbookReceiver>(),
                voiceReceivers ?? new ChangeTrackingList<MonitorVoiceReceiver>(),
                logicAppReceivers ?? new ChangeTrackingList<MonitorLogicAppReceiver>(),
                azureFunctionReceivers ?? new ChangeTrackingList<MonitorAzureFunctionReceiver>(),
                armRoleReceivers ?? new ChangeTrackingList<MonitorArmRoleReceiver>(),
                eventHubReceivers ?? new ChangeTrackingList<MonitorEventHubReceiver>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationContent)} does not support writing '{options.Format}' format.");
            }
        }

        NotificationContent IPersistableModel<NotificationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
