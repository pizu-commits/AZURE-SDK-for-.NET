// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IPv6ExpressRouteCircuitPeeringConfig : IUtf8JsonSerializable, IJsonModel<IPv6ExpressRouteCircuitPeeringConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPv6ExpressRouteCircuitPeeringConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IPv6ExpressRouteCircuitPeeringConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IPv6ExpressRouteCircuitPeeringConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryPeerAddressPrefix))
            {
                writer.WritePropertyName("primaryPeerAddressPrefix"u8);
                writer.WriteStringValue(PrimaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SecondaryPeerAddressPrefix))
            {
                writer.WritePropertyName("secondaryPeerAddressPrefix"u8);
                writer.WriteStringValue(SecondaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(MicrosoftPeeringConfig))
            {
                writer.WritePropertyName("microsoftPeeringConfig"u8);
                writer.WriteObjectValue(MicrosoftPeeringConfig);
            }
            if (Optional.IsDefined(RouteFilter))
            {
                writer.WritePropertyName("routeFilter"u8);
                JsonSerializer.Serialize(writer, RouteFilter);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        IPv6ExpressRouteCircuitPeeringConfig IJsonModel<IPv6ExpressRouteCircuitPeeringConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IPv6ExpressRouteCircuitPeeringConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPv6ExpressRouteCircuitPeeringConfig(document.RootElement, options);
        }

        internal static IPv6ExpressRouteCircuitPeeringConfig DeserializeIPv6ExpressRouteCircuitPeeringConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryPeerAddressPrefix = default;
            Optional<string> secondaryPeerAddressPrefix = default;
            Optional<ExpressRouteCircuitPeeringConfig> microsoftPeeringConfig = default;
            Optional<WritableSubResource> routeFilter = default;
            Optional<ExpressRouteCircuitPeeringState> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryPeerAddressPrefix"u8))
                {
                    primaryPeerAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryPeerAddressPrefix"u8))
                {
                    secondaryPeerAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("microsoftPeeringConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftPeeringConfig = ExpressRouteCircuitPeeringConfig.DeserializeExpressRouteCircuitPeeringConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("routeFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routeFilter = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ExpressRouteCircuitPeeringState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IPv6ExpressRouteCircuitPeeringConfig(primaryPeerAddressPrefix.Value, secondaryPeerAddressPrefix.Value, microsoftPeeringConfig.Value, routeFilter, Optional.ToNullable(state), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IPv6ExpressRouteCircuitPeeringConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(IPv6ExpressRouteCircuitPeeringConfig)} does not support '{options.Format}' format.");
            }
        }

        IPv6ExpressRouteCircuitPeeringConfig IPersistableModel<IPv6ExpressRouteCircuitPeeringConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIPv6ExpressRouteCircuitPeeringConfig(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(IPv6ExpressRouteCircuitPeeringConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPv6ExpressRouteCircuitPeeringConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
