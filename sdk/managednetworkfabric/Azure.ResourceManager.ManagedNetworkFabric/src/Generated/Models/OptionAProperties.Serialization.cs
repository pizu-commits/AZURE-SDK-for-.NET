// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class OptionAProperties : IUtf8JsonSerializable, IJsonModel<OptionAProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OptionAProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OptionAProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionAProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionAProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Mtu))
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteNumberValue(Mtu.Value);
            }
            if (Optional.IsDefined(VlanId))
            {
                writer.WritePropertyName("vlanId"u8);
                writer.WriteNumberValue(VlanId.Value);
            }
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Optional.IsDefined(BfdConfiguration))
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                writer.WriteObjectValue(BfdConfiguration);
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

        OptionAProperties IJsonModel<OptionAProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionAProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionAProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOptionAProperties(document.RootElement, options);
        }

        internal static OptionAProperties DeserializeOptionAProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? mtu = default;
            int? vlanId = default;
            long? peerAsn = default;
            BfdConfiguration bfdConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mtu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mtu = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vlanId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OptionAProperties(mtu, vlanId, peerAsn, bfdConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OptionAProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionAProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OptionAProperties)} does not support '{options.Format}' format.");
            }
        }

        OptionAProperties IPersistableModel<OptionAProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionAProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOptionAProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OptionAProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OptionAProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
