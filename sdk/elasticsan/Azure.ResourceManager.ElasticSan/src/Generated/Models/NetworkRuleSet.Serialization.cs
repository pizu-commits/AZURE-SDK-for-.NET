// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    internal partial class NetworkRuleSet : IUtf8JsonSerializable, IJsonModel<NetworkRuleSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkRuleSet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkRuleSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkRuleSet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
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

        NetworkRuleSet IJsonModel<NetworkRuleSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkRuleSet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkRuleSet(document.RootElement, options);
        }

        internal static NetworkRuleSet DeserializeNetworkRuleSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ElasticSanVirtualNetworkRule> virtualNetworkRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualNetworkRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticSanVirtualNetworkRule> array = new List<ElasticSanVirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticSanVirtualNetworkRule.DeserializeElasticSanVirtualNetworkRule(item, options));
                    }
                    virtualNetworkRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkRuleSet(virtualNetworkRules ?? new ChangeTrackingList<ElasticSanVirtualNetworkRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkRuleSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkRuleSet)} does not support '{options.Format}' format.");
            }
        }

        NetworkRuleSet IPersistableModel<NetworkRuleSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkRuleSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkRuleSet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkRuleSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
