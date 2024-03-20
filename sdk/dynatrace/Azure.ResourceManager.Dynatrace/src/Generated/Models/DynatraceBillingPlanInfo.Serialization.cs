// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceBillingPlanInfo : IUtf8JsonSerializable, IJsonModel<DynatraceBillingPlanInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceBillingPlanInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DynatraceBillingPlanInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceBillingPlanInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceBillingPlanInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UsageType))
            {
                writer.WritePropertyName("usageType"u8);
                writer.WriteStringValue(UsageType);
            }
            if (Optional.IsDefined(BillingCycle))
            {
                writer.WritePropertyName("billingCycle"u8);
                writer.WriteStringValue(BillingCycle);
            }
            if (Optional.IsDefined(PlanDetails))
            {
                writer.WritePropertyName("planDetails"u8);
                writer.WriteStringValue(PlanDetails);
            }
            if (Optional.IsDefined(EffectiveOn))
            {
                writer.WritePropertyName("effectiveDate"u8);
                writer.WriteStringValue(EffectiveOn.Value, "O");
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

        DynatraceBillingPlanInfo IJsonModel<DynatraceBillingPlanInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceBillingPlanInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceBillingPlanInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceBillingPlanInfo(document.RootElement, options);
        }

        internal static DynatraceBillingPlanInfo DeserializeDynatraceBillingPlanInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string usageType = default;
            string billingCycle = default;
            string planDetails = default;
            DateTimeOffset? effectiveDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usageType"u8))
                {
                    usageType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingCycle"u8))
                {
                    billingCycle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDetails"u8))
                {
                    planDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DynatraceBillingPlanInfo(usageType, billingCycle, planDetails, effectiveDate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceBillingPlanInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceBillingPlanInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceBillingPlanInfo)} does not support '{options.Format}' format.");
            }
        }

        DynatraceBillingPlanInfo IPersistableModel<DynatraceBillingPlanInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceBillingPlanInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceBillingPlanInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceBillingPlanInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceBillingPlanInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
