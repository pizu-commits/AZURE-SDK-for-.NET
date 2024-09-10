// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class CancelSubscriptionContent : IUtf8JsonSerializable, IJsonModel<CancelSubscriptionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CancelSubscriptionContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CancelSubscriptionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelSubscriptionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CancelSubscriptionContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("cancellationReason"u8);
            writer.WriteStringValue(CancellationReason.ToString());
            if (Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId"u8);
                writer.WriteStringValue(CustomerId);
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

        CancelSubscriptionContent IJsonModel<CancelSubscriptionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelSubscriptionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CancelSubscriptionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCancelSubscriptionContent(document.RootElement, options);
        }

        internal static CancelSubscriptionContent DeserializeCancelSubscriptionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CustomerSubscriptionCancellationReason cancellationReason = default;
            ResourceIdentifier customerId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cancellationReason"u8))
                {
                    cancellationReason = new CustomerSubscriptionCancellationReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CancelSubscriptionContent(cancellationReason, customerId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CancelSubscriptionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelSubscriptionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CancelSubscriptionContent)} does not support writing '{options.Format}' format.");
            }
        }

        CancelSubscriptionContent IPersistableModel<CancelSubscriptionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelSubscriptionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCancelSubscriptionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CancelSubscriptionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CancelSubscriptionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
