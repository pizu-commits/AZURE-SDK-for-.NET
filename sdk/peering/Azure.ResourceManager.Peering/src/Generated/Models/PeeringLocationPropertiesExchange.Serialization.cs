// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    internal partial class PeeringLocationPropertiesExchange : IUtf8JsonSerializable, IJsonModel<PeeringLocationPropertiesExchange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringLocationPropertiesExchange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeeringLocationPropertiesExchange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLocationPropertiesExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringLocationPropertiesExchange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PeeringFacilities))
            {
                writer.WritePropertyName("peeringFacilities"u8);
                writer.WriteStartArray();
                foreach (var item in PeeringFacilities)
                {
                    writer.WriteObjectValue(item);
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

        PeeringLocationPropertiesExchange IJsonModel<PeeringLocationPropertiesExchange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLocationPropertiesExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringLocationPropertiesExchange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringLocationPropertiesExchange(document.RootElement, options);
        }

        internal static PeeringLocationPropertiesExchange DeserializePeeringLocationPropertiesExchange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ExchangePeeringFacility> peeringFacilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peeringFacilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExchangePeeringFacility> array = new List<ExchangePeeringFacility>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExchangePeeringFacility.DeserializeExchangePeeringFacility(item, options));
                    }
                    peeringFacilities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeeringLocationPropertiesExchange(peeringFacilities ?? new ChangeTrackingList<ExchangePeeringFacility>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringLocationPropertiesExchange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLocationPropertiesExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeeringLocationPropertiesExchange)} does not support '{options.Format}' format.");
            }
        }

        PeeringLocationPropertiesExchange IPersistableModel<PeeringLocationPropertiesExchange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLocationPropertiesExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeeringLocationPropertiesExchange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeeringLocationPropertiesExchange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeeringLocationPropertiesExchange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
