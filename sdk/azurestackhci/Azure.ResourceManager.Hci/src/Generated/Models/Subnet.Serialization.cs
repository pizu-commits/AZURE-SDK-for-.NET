// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class Subnet : IUtf8JsonSerializable, IJsonModel<Subnet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Subnet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Subnet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Subnet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Subnet)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPAllocationMethod))
            {
                writer.WritePropertyName("ipAllocationMethod"u8);
                writer.WriteStringValue(IPAllocationMethod.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPConfigurationReferences))
            {
                writer.WritePropertyName("ipConfigurationReferences"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurationReferences)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RouteTable))
            {
                writer.WritePropertyName("routeTable"u8);
                writer.WriteObjectValue<RouteTable>(RouteTable, options);
            }
            if (Optional.IsCollectionDefined(IPPools))
            {
                writer.WritePropertyName("ipPools"u8);
                writer.WriteStartArray();
                foreach (var item in IPPools)
                {
                    writer.WriteObjectValue<IPPool>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Vlan))
            {
                writer.WritePropertyName("vlan"u8);
                writer.WriteNumberValue(Vlan.Value);
            }
            writer.WriteEndObject();
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

        Subnet IJsonModel<Subnet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Subnet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Subnet)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubnet(document.RootElement, options);
        }

        internal static Subnet DeserializeSubnet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string addressPrefix = default;
            IList<string> addressPrefixes = default;
            IPAllocationMethodEnum? ipAllocationMethod = default;
            IList<WritableSubResource> ipConfigurationReferences = default;
            RouteTable routeTable = default;
            IList<IPPool> ipPools = default;
            int? vlan = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressPrefix"u8))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("addressPrefixes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            addressPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("ipAllocationMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipAllocationMethod = new IPAllocationMethodEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ipConfigurationReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("routeTable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeTable = RouteTable.DeserializeRouteTable(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPPool> array = new List<IPPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPPool.DeserializeIPPool(item, options));
                            }
                            ipPools = array;
                            continue;
                        }
                        if (property0.NameEquals("vlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vlan = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Subnet(
                name,
                addressPrefix,
                addressPrefixes ?? new ChangeTrackingList<string>(),
                ipAllocationMethod,
                ipConfigurationReferences ?? new ChangeTrackingList<WritableSubResource>(),
                routeTable,
                ipPools ?? new ChangeTrackingList<IPPool>(),
                vlan,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Subnet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Subnet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Subnet)} does not support writing '{options.Format}' format.");
            }
        }

        Subnet IPersistableModel<Subnet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Subnet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubnet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Subnet)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Subnet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
