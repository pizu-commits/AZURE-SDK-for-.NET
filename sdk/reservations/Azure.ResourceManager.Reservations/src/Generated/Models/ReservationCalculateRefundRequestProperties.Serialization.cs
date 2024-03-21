// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationCalculateRefundRequestProperties : IUtf8JsonSerializable, IJsonModel<ReservationCalculateRefundRequestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationCalculateRefundRequestProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationCalculateRefundRequestProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCalculateRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationCalculateRefundRequestProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(ReservationToReturn))
            {
                writer.WritePropertyName("reservationToReturn"u8);
                writer.WriteObjectValue(ReservationToReturn);
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

        ReservationCalculateRefundRequestProperties IJsonModel<ReservationCalculateRefundRequestProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCalculateRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationCalculateRefundRequestProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationCalculateRefundRequestProperties(document.RootElement, options);
        }

        internal static ReservationCalculateRefundRequestProperties DeserializeReservationCalculateRefundRequestProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scope = default;
            ReservationToReturn reservationToReturn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reservationToReturn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationToReturn = ReservationToReturn.DeserializeReservationToReturn(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationCalculateRefundRequestProperties(scope, reservationToReturn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationCalculateRefundRequestProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCalculateRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationCalculateRefundRequestProperties)} does not support '{options.Format}' format.");
            }
        }

        ReservationCalculateRefundRequestProperties IPersistableModel<ReservationCalculateRefundRequestProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCalculateRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationCalculateRefundRequestProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationCalculateRefundRequestProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationCalculateRefundRequestProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
