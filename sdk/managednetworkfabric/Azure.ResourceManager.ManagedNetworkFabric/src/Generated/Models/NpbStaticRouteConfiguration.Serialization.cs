// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NpbStaticRouteConfiguration : IUtf8JsonSerializable, IJsonModel<NpbStaticRouteConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NpbStaticRouteConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NpbStaticRouteConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NpbStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NpbStaticRouteConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BfdConfiguration))
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                writer.WriteObjectValue(BfdConfiguration, options);
            }
            if (Optional.IsCollectionDefined(IPv4Routes))
            {
                writer.WritePropertyName("ipv4Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4Routes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6Routes))
            {
                writer.WritePropertyName("ipv6Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6Routes)
                {
                    writer.WriteObjectValue(item, options);
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

        NpbStaticRouteConfiguration IJsonModel<NpbStaticRouteConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NpbStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NpbStaticRouteConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNpbStaticRouteConfiguration(document.RootElement, options);
        }

        internal static NpbStaticRouteConfiguration DeserializeNpbStaticRouteConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BfdConfiguration bfdConfiguration = default;
            IList<StaticRouteProperties> ipv4Routes = default;
            IList<StaticRouteProperties> ipv6Routes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipv4Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRouteProperties> array = new List<StaticRouteProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRouteProperties.DeserializeStaticRouteProperties(item, options));
                    }
                    ipv4Routes = array;
                    continue;
                }
                if (property.NameEquals("ipv6Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRouteProperties> array = new List<StaticRouteProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRouteProperties.DeserializeStaticRouteProperties(item, options));
                    }
                    ipv6Routes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NpbStaticRouteConfiguration(bfdConfiguration, ipv4Routes ?? new ChangeTrackingList<StaticRouteProperties>(), ipv6Routes ?? new ChangeTrackingList<StaticRouteProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NpbStaticRouteConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NpbStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NpbStaticRouteConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        NpbStaticRouteConfiguration IPersistableModel<NpbStaticRouteConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NpbStaticRouteConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNpbStaticRouteConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NpbStaticRouteConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NpbStaticRouteConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
