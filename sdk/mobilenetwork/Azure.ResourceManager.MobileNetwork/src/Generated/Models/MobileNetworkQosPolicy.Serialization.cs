// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkQosPolicy : IUtf8JsonSerializable, IJsonModel<MobileNetworkQosPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkQosPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkQosPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkQosPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkQosPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FiveQi))
            {
                writer.WritePropertyName("5qi"u8);
                writer.WriteNumberValue(FiveQi.Value);
            }
            if (Optional.IsDefined(AllocationAndRetentionPriorityLevel))
            {
                writer.WritePropertyName("allocationAndRetentionPriorityLevel"u8);
                writer.WriteNumberValue(AllocationAndRetentionPriorityLevel.Value);
            }
            if (Optional.IsDefined(PreemptionCapability))
            {
                writer.WritePropertyName("preemptionCapability"u8);
                writer.WriteStringValue(PreemptionCapability.Value.ToString());
            }
            if (Optional.IsDefined(PreemptionVulnerability))
            {
                writer.WritePropertyName("preemptionVulnerability"u8);
                writer.WriteStringValue(PreemptionVulnerability.Value.ToString());
            }
            writer.WritePropertyName("maximumBitRate"u8);
            writer.WriteObjectValue<Ambr>(MaximumBitRate, options);
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

        MobileNetworkQosPolicy IJsonModel<MobileNetworkQosPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkQosPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkQosPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkQosPolicy(document.RootElement, options);
        }

        internal static MobileNetworkQosPolicy DeserializeMobileNetworkQosPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? _5qi = default;
            int? allocationAndRetentionPriorityLevel = default;
            MobileNetworkPreemptionCapability? preemptionCapability = default;
            MobileNetworkPreemptionVulnerability? preemptionVulnerability = default;
            Ambr maximumBitRate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("5qi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    _5qi = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocationAndRetentionPriorityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationAndRetentionPriorityLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preemptionCapability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionCapability = new MobileNetworkPreemptionCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preemptionVulnerability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionVulnerability = new MobileNetworkPreemptionVulnerability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maximumBitRate"u8))
                {
                    maximumBitRate = Ambr.DeserializeAmbr(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkQosPolicy(
                _5qi,
                allocationAndRetentionPriorityLevel,
                preemptionCapability,
                preemptionVulnerability,
                maximumBitRate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkQosPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkQosPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkQosPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        MobileNetworkQosPolicy IPersistableModel<MobileNetworkQosPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkQosPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkQosPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkQosPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkQosPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
