// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusNameAvailabilityResult : IUtf8JsonSerializable, IJsonModel<ServiceBusNameAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusNameAvailabilityResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusNameAvailabilityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusNameAvailabilityResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(IsNameAvailable))
            {
                writer.WritePropertyName("nameAvailable"u8);
                writer.WriteBooleanValue(IsNameAvailable.Value);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason.Value.ToSerialString());
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

        ServiceBusNameAvailabilityResult IJsonModel<ServiceBusNameAvailabilityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusNameAvailabilityResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusNameAvailabilityResult(document.RootElement, options);
        }

        internal static ServiceBusNameAvailabilityResult DeserializeServiceBusNameAvailabilityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string message = default;
            bool? nameAvailable = default;
            ServiceBusNameUnavailableReason? reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = property.Value.GetString().ToServiceBusNameUnavailableReason();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusNameAvailabilityResult(message, nameAvailable, reason, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusNameAvailabilityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusNameAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        ServiceBusNameAvailabilityResult IPersistableModel<ServiceBusNameAvailabilityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusNameAvailabilityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusNameAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusNameAvailabilityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
