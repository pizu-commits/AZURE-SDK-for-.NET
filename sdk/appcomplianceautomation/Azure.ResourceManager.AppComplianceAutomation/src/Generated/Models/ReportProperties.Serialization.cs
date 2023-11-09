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

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ReportProperties : IUtf8JsonSerializable, IJsonModel<ReportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ReportProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Id))
                {
                    writer.WritePropertyName("id"u8);
                    writer.WriteStringValue(Id);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TenantId))
                {
                    writer.WritePropertyName("tenantId"u8);
                    writer.WriteStringValue(TenantId.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ReportName))
                {
                    writer.WritePropertyName("reportName"u8);
                    writer.WriteStringValue(ReportName);
                }
            }
            if (Optional.IsDefined(OfferGuid))
            {
                writer.WritePropertyName("offerGuid"u8);
                writer.WriteStringValue(OfferGuid);
            }
            writer.WritePropertyName("timeZone"u8);
            writer.WriteStringValue(TimeZone);
            writer.WritePropertyName("triggerTime"u8);
            writer.WriteStringValue(TriggerOn, "O");
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(NextTriggerOn))
                {
                    writer.WritePropertyName("nextTriggerTime"u8);
                    writer.WriteStringValue(NextTriggerOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LastTriggerOn))
                {
                    writer.WritePropertyName("lastTriggerTime"u8);
                    writer.WriteStringValue(LastTriggerOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Subscriptions))
                {
                    writer.WritePropertyName("subscriptions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Subscriptions)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WritePropertyName("resources"u8);
            writer.WriteStartArray();
            foreach (var item in Resources)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ComplianceStatus))
                {
                    writer.WritePropertyName("complianceStatus"u8);
                    writer.WriteObjectValue(ComplianceStatus);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
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

        ReportProperties IJsonModel<ReportProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReportProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportProperties(document.RootElement, options);
        }

        internal static ReportProperties DeserializeReportProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<ReportStatus> status = default;
            Optional<Guid> tenantId = default;
            Optional<string> reportName = default;
            Optional<string> offerGuid = default;
            string timeZone = default;
            DateTimeOffset triggerTime = default;
            Optional<DateTimeOffset> nextTriggerTime = default;
            Optional<DateTimeOffset> lastTriggerTime = default;
            Optional<IReadOnlyList<string>> subscriptions = default;
            IList<ResourceMetadata> resources = default;
            Optional<ReportComplianceStatus> complianceStatus = default;
            Optional<ProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ReportStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("reportName"u8))
                {
                    reportName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerGuid"u8))
                {
                    offerGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerTime"u8))
                {
                    triggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("nextTriggerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTriggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTriggerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTriggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
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
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    List<ResourceMetadata> array = new List<ResourceMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceMetadata.DeserializeResourceMetadata(item));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = ReportComplianceStatus.DeserializeReportComplianceStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReportProperties(id.Value, Optional.ToNullable(status), Optional.ToNullable(tenantId), reportName.Value, offerGuid.Value, timeZone, triggerTime, Optional.ToNullable(nextTriggerTime), Optional.ToNullable(lastTriggerTime), Optional.ToList(subscriptions), resources, complianceStatus.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IModel<ReportProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReportProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ReportProperties IModel<ReportProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReportProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeReportProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ReportProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
