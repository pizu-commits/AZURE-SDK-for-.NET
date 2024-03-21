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
    public partial class CustomerSubscriptionDetails : IUtf8JsonSerializable, IJsonModel<CustomerSubscriptionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomerSubscriptionDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomerSubscriptionDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerSubscriptionDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RegisteredFeatures))
            {
                writer.WritePropertyName("registeredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RegisteredFeatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LocationPlacementId))
            {
                writer.WritePropertyName("locationPlacementId"u8);
                writer.WriteStringValue(LocationPlacementId);
            }
            writer.WritePropertyName("quotaId"u8);
            writer.WriteStringValue(QuotaId);
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

        CustomerSubscriptionDetails IJsonModel<CustomerSubscriptionDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerSubscriptionDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomerSubscriptionDetails(document.RootElement, options);
        }

        internal static CustomerSubscriptionDetails DeserializeCustomerSubscriptionDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CustomerSubscriptionRegisteredFeatures> registeredFeatures = default;
            string locationPlacementId = default;
            string quotaId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registeredFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerSubscriptionRegisteredFeatures> array = new List<CustomerSubscriptionRegisteredFeatures>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomerSubscriptionRegisteredFeatures.DeserializeCustomerSubscriptionRegisteredFeatures(item, options));
                    }
                    registeredFeatures = array;
                    continue;
                }
                if (property.NameEquals("locationPlacementId"u8))
                {
                    locationPlacementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaId"u8))
                {
                    quotaId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomerSubscriptionDetails(registeredFeatures ?? new ChangeTrackingList<CustomerSubscriptionRegisteredFeatures>(), locationPlacementId, quotaId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomerSubscriptionDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomerSubscriptionDetails)} does not support '{options.Format}' format.");
            }
        }

        CustomerSubscriptionDetails IPersistableModel<CustomerSubscriptionDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomerSubscriptionDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomerSubscriptionDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomerSubscriptionDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
