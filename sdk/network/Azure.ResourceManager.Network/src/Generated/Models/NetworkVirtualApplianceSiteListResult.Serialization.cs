// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkVirtualApplianceSiteListResult : IUtf8JsonSerializable, IJsonModel<NetworkVirtualApplianceSiteListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkVirtualApplianceSiteListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkVirtualApplianceSiteListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceSiteListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceSiteListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue<VirtualApplianceSiteData>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        NetworkVirtualApplianceSiteListResult IJsonModel<NetworkVirtualApplianceSiteListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceSiteListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceSiteListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkVirtualApplianceSiteListResult(document.RootElement, options);
        }

        internal static NetworkVirtualApplianceSiteListResult DeserializeNetworkVirtualApplianceSiteListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<VirtualApplianceSiteData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualApplianceSiteData> array = new List<VirtualApplianceSiteData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkVirtualApplianceSiteListResult(value ?? new ChangeTrackingList<VirtualApplianceSiteData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkVirtualApplianceSiteListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceSiteListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkVirtualApplianceSiteListResult)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkVirtualApplianceSiteListResult IPersistableModel<NetworkVirtualApplianceSiteListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceSiteListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkVirtualApplianceSiteListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkVirtualApplianceSiteListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkVirtualApplianceSiteListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
