// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ServiceImpactingEvent : IUtf8JsonSerializable, IJsonModel<ServiceImpactingEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceImpactingEvent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceImpactingEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceImpactingEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceImpactingEvent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EventStartOn))
            {
                writer.WritePropertyName("eventStartTime"u8);
                writer.WriteStringValue(EventStartOn.Value, "O");
            }
            if (Optional.IsDefined(EventStatusLastModifiedOn))
            {
                writer.WritePropertyName("eventStatusLastModifiedTime"u8);
                writer.WriteStringValue(EventStatusLastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (Optional.IsDefined(IncidentProperties))
            {
                writer.WritePropertyName("incidentProperties"u8);
                writer.WriteObjectValue(IncidentProperties);
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

        ServiceImpactingEvent IJsonModel<ServiceImpactingEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceImpactingEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceImpactingEvent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceImpactingEvent(document.RootElement, options);
        }

        internal static ServiceImpactingEvent DeserializeServiceImpactingEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? eventStartTime = default;
            DateTimeOffset? eventStatusLastModifiedTime = default;
            string correlationId = default;
            ServiceImpactingEventStatus status = default;
            ServiceImpactingEventIncidentProperties incidentProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eventStatusLastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventStatusLastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ServiceImpactingEventStatus.DeserializeServiceImpactingEventStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("incidentProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    incidentProperties = ServiceImpactingEventIncidentProperties.DeserializeServiceImpactingEventIncidentProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceImpactingEvent(
                eventStartTime,
                eventStatusLastModifiedTime,
                correlationId,
                status,
                incidentProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceImpactingEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceImpactingEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceImpactingEvent)} does not support '{options.Format}' format.");
            }
        }

        ServiceImpactingEvent IPersistableModel<ServiceImpactingEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceImpactingEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceImpactingEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceImpactingEvent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceImpactingEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
