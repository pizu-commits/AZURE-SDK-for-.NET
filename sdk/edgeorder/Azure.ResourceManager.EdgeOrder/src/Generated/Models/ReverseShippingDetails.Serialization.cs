// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ReverseShippingDetails : IUtf8JsonSerializable, IJsonModel<ReverseShippingDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReverseShippingDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReverseShippingDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseShippingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReverseShippingDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SasKeyForLabel))
            {
                writer.WritePropertyName("sasKeyForLabel"u8);
                writer.WriteStringValue(SasKeyForLabel);
            }
            if (options.Format != "W" && Optional.IsDefined(CarrierName))
            {
                writer.WritePropertyName("carrierName"u8);
                writer.WriteStringValue(CarrierName);
            }
            if (options.Format != "W" && Optional.IsDefined(CarrierDisplayName))
            {
                writer.WritePropertyName("carrierDisplayName"u8);
                writer.WriteStringValue(CarrierDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(TrackingId))
            {
                writer.WritePropertyName("trackingId"u8);
                writer.WriteStringValue(TrackingId);
            }
            if (options.Format != "W" && Optional.IsDefined(TrackingUri))
            {
                writer.WritePropertyName("trackingUrl"u8);
                writer.WriteStringValue(TrackingUri.AbsoluteUri);
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

        ReverseShippingDetails IJsonModel<ReverseShippingDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseShippingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReverseShippingDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseShippingDetails(document.RootElement, options);
        }

        internal static ReverseShippingDetails DeserializeReverseShippingDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sasKeyForLabel = default;
            string carrierName = default;
            string carrierDisplayName = default;
            string trackingId = default;
            Uri trackingUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasKeyForLabel"u8))
                {
                    sasKeyForLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierName"u8))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierDisplayName"u8))
                {
                    carrierDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackingUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReverseShippingDetails(
                sasKeyForLabel,
                carrierName,
                carrierDisplayName,
                trackingId,
                trackingUrl,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReverseShippingDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseShippingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReverseShippingDetails)} does not support '{options.Format}' format.");
            }
        }

        ReverseShippingDetails IPersistableModel<ReverseShippingDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseShippingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReverseShippingDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReverseShippingDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReverseShippingDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
