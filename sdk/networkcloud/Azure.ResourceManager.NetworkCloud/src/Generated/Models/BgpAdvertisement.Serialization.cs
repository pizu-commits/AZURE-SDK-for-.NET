// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BgpAdvertisement : IUtf8JsonSerializable, IJsonModel<BgpAdvertisement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BgpAdvertisement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BgpAdvertisement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpAdvertisement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BgpAdvertisement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AdvertiseToFabric))
            {
                writer.WritePropertyName("advertiseToFabric"u8);
                writer.WriteStringValue(AdvertiseToFabric.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Communities))
            {
                writer.WritePropertyName("communities"u8);
                writer.WriteStartArray();
                foreach (var item in Communities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("ipAddressPools"u8);
            writer.WriteStartArray();
            foreach (var item in IPAddressPools)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Peers))
            {
                writer.WritePropertyName("peers"u8);
                writer.WriteStartArray();
                foreach (var item in Peers)
                {
                    writer.WriteStringValue(item);
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

        BgpAdvertisement IJsonModel<BgpAdvertisement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpAdvertisement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BgpAdvertisement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBgpAdvertisement(document.RootElement, options);
        }

        internal static BgpAdvertisement DeserializeBgpAdvertisement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AdvertiseToFabric> advertiseToFabric = default;
            Optional<IList<string>> communities = default;
            IList<string> ipAddressPools = default;
            Optional<IList<string>> peers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("advertiseToFabric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    advertiseToFabric = new AdvertiseToFabric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("communities"u8))
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
                    communities = array;
                    continue;
                }
                if (property.NameEquals("ipAddressPools"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipAddressPools = array;
                    continue;
                }
                if (property.NameEquals("peers"u8))
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
                    peers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BgpAdvertisement(Optional.ToNullable(advertiseToFabric), Optional.ToList(communities), ipAddressPools, Optional.ToList(peers), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BgpAdvertisement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpAdvertisement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BgpAdvertisement)} does not support '{options.Format}' format.");
            }
        }

        BgpAdvertisement IPersistableModel<BgpAdvertisement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpAdvertisement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBgpAdvertisement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BgpAdvertisement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BgpAdvertisement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
