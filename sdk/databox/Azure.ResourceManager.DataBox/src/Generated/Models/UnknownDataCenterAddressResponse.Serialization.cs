// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class UnknownDataCenterAddressResponse : IUtf8JsonSerializable, IJsonModel<DataCenterAddressResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCenterAddressResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCenterAddressResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCenterAddressResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("datacenterAddressType"u8);
            writer.WriteStringValue(DataCenterAddressType.ToSerialString());
            if (options.Format != "W" && !(SupportedCarriersForReturnShipment is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedCarriersForReturnShipment"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedCarriersForReturnShipment)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DataCenterAzureLocation))
            {
                writer.WritePropertyName("dataCenterAzureLocation"u8);
                writer.WriteStringValue(DataCenterAzureLocation.Value);
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

        DataCenterAddressResult IJsonModel<DataCenterAddressResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCenterAddressResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCenterAddressResult(document.RootElement, options);
        }

        internal static UnknownDataCenterAddressResponse DeserializeUnknownDataCenterAddressResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataCenterAddressType dataCenterAddressType = default;
            Optional<IReadOnlyList<string>> supportedCarriersForReturnShipment = default;
            Optional<AzureLocation> dataCenterAzureLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datacenterAddressType"u8))
                {
                    dataCenterAddressType = property.Value.GetString().ToDataCenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"u8))
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
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAzureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownDataCenterAddressResponse(dataCenterAddressType, Optional.ToList(supportedCarriersForReturnShipment), Optional.ToNullable(dataCenterAzureLocation), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCenterAddressResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCenterAddressResult)} does not support '{options.Format}' format.");
            }
        }

        DataCenterAddressResult IPersistableModel<DataCenterAddressResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCenterAddressResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCenterAddressResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCenterAddressResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
