// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryLogicalNetworkProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryLogicalNetworkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryLogicalNetworkProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryLogicalNetworkProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryLogicalNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryLogicalNetworkProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(NetworkVirtualizationStatus))
            {
                writer.WritePropertyName("networkVirtualizationStatus"u8);
                writer.WriteStringValue(NetworkVirtualizationStatus);
            }
            if (Optional.IsDefined(LogicalNetworkUsage))
            {
                writer.WritePropertyName("logicalNetworkUsage"u8);
                writer.WriteStringValue(LogicalNetworkUsage);
            }
            if (Optional.IsDefined(LogicalNetworkDefinitionsStatus))
            {
                writer.WritePropertyName("logicalNetworkDefinitionsStatus"u8);
                writer.WriteStringValue(LogicalNetworkDefinitionsStatus);
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

        SiteRecoveryLogicalNetworkProperties IJsonModel<SiteRecoveryLogicalNetworkProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryLogicalNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryLogicalNetworkProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryLogicalNetworkProperties(document.RootElement, options);
        }

        internal static SiteRecoveryLogicalNetworkProperties DeserializeSiteRecoveryLogicalNetworkProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            string networkVirtualizationStatus = default;
            string logicalNetworkUsage = default;
            string logicalNetworkDefinitionsStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkVirtualizationStatus"u8))
                {
                    networkVirtualizationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logicalNetworkUsage"u8))
                {
                    logicalNetworkUsage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logicalNetworkDefinitionsStatus"u8))
                {
                    logicalNetworkDefinitionsStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryLogicalNetworkProperties(friendlyName, networkVirtualizationStatus, logicalNetworkUsage, logicalNetworkDefinitionsStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryLogicalNetworkProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryLogicalNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryLogicalNetworkProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryLogicalNetworkProperties IPersistableModel<SiteRecoveryLogicalNetworkProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryLogicalNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryLogicalNetworkProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryLogicalNetworkProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryLogicalNetworkProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
