// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    public partial class DataProductNetworkAcls : IUtf8JsonSerializable, IJsonModel<DataProductNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProductNetworkAcls>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataProductNetworkAcls>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProductNetworkAcls)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("virtualNetworkRule"u8);
            writer.WriteStartArray();
            foreach (var item in VirtualNetworkRule)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("ipRules"u8);
            writer.WriteStartArray();
            foreach (var item in IPRules)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("allowedQueryIpRangeList"u8);
            writer.WriteStartArray();
            foreach (var item in AllowedQueryIPRangeList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("defaultAction"u8);
            writer.WriteStringValue(DefaultAction.ToString());
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

        DataProductNetworkAcls IJsonModel<DataProductNetworkAcls>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProductNetworkAcls)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProductNetworkAcls(document.RootElement, options);
        }

        internal static DataProductNetworkAcls DeserializeDataProductNetworkAcls(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<NetworkAnalyticsVirtualNetworkRule> virtualNetworkRule = default;
            IList<NetworkAnalyticsIPRules> ipRules = default;
            IList<string> allowedQueryIPRangeList = default;
            NetworkAclDefaultAction defaultAction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualNetworkRule"u8))
                {
                    List<NetworkAnalyticsVirtualNetworkRule> array = new List<NetworkAnalyticsVirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkAnalyticsVirtualNetworkRule.DeserializeNetworkAnalyticsVirtualNetworkRule(item, options));
                    }
                    virtualNetworkRule = array;
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    List<NetworkAnalyticsIPRules> array = new List<NetworkAnalyticsIPRules>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkAnalyticsIPRules.DeserializeNetworkAnalyticsIPRules(item, options));
                    }
                    ipRules = array;
                    continue;
                }
                if (property.NameEquals("allowedQueryIpRangeList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedQueryIPRangeList = array;
                    continue;
                }
                if (property.NameEquals("defaultAction"u8))
                {
                    defaultAction = new NetworkAclDefaultAction(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataProductNetworkAcls(virtualNetworkRule, ipRules, allowedQueryIPRangeList, defaultAction, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProductNetworkAcls>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProductNetworkAcls)} does not support writing '{options.Format}' format.");
            }
        }

        DataProductNetworkAcls IPersistableModel<DataProductNetworkAcls>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProductNetworkAcls(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProductNetworkAcls)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProductNetworkAcls>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
