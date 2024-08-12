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
    public partial class AzureFirewallPacketCaptureFlags : IUtf8JsonSerializable, IJsonModel<AzureFirewallPacketCaptureFlags>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureFirewallPacketCaptureFlags>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureFirewallPacketCaptureFlags>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallPacketCaptureFlags>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFirewallPacketCaptureFlags)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FlagsType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(FlagsType.Value.ToString());
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

        AzureFirewallPacketCaptureFlags IJsonModel<AzureFirewallPacketCaptureFlags>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallPacketCaptureFlags>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFirewallPacketCaptureFlags)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureFirewallPacketCaptureFlags(document.RootElement, options);
        }

        internal static AzureFirewallPacketCaptureFlags DeserializeAzureFirewallPacketCaptureFlags(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureFirewallPacketCaptureFlagsType? type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AzureFirewallPacketCaptureFlagsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureFirewallPacketCaptureFlags(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureFirewallPacketCaptureFlags>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallPacketCaptureFlags>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureFirewallPacketCaptureFlags)} does not support writing '{options.Format}' format.");
            }
        }

        AzureFirewallPacketCaptureFlags IPersistableModel<AzureFirewallPacketCaptureFlags>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallPacketCaptureFlags>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureFirewallPacketCaptureFlags(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureFirewallPacketCaptureFlags)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureFirewallPacketCaptureFlags>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
