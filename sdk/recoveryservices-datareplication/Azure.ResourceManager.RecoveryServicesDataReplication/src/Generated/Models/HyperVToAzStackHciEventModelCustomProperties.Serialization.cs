// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVToAzStackHciEventModelCustomProperties : IUtf8JsonSerializable, IJsonModel<HyperVToAzStackHciEventModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVToAzStackHciEventModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVToAzStackHciEventModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciEventModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVToAzStackHciEventModelCustomProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(EventSourceFriendlyName))
            {
                writer.WritePropertyName("eventSourceFriendlyName"u8);
                writer.WriteStringValue(EventSourceFriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectedItemFriendlyName))
            {
                writer.WritePropertyName("protectedItemFriendlyName"u8);
                writer.WriteStringValue(ProtectedItemFriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceApplianceName))
            {
                writer.WritePropertyName("sourceApplianceName"u8);
                writer.WriteStringValue(SourceApplianceName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetApplianceName))
            {
                writer.WritePropertyName("targetApplianceName"u8);
                writer.WriteStringValue(TargetApplianceName);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerType))
            {
                writer.WritePropertyName("serverType"u8);
                writer.WriteStringValue(ServerType);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        HyperVToAzStackHciEventModelCustomProperties IJsonModel<HyperVToAzStackHciEventModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciEventModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVToAzStackHciEventModelCustomProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVToAzStackHciEventModelCustomProperties(document.RootElement, options);
        }

        internal static HyperVToAzStackHciEventModelCustomProperties DeserializeHyperVToAzStackHciEventModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventSourceFriendlyName = default;
            string protectedItemFriendlyName = default;
            string sourceApplianceName = default;
            string targetApplianceName = default;
            string serverType = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventSourceFriendlyName"u8))
                {
                    eventSourceFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemFriendlyName"u8))
                {
                    protectedItemFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceApplianceName"u8))
                {
                    sourceApplianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetApplianceName"u8))
                {
                    targetApplianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverType"u8))
                {
                    serverType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVToAzStackHciEventModelCustomProperties(
                instanceType,
                serializedAdditionalRawData,
                eventSourceFriendlyName,
                protectedItemFriendlyName,
                sourceApplianceName,
                targetApplianceName,
                serverType);
        }

        BinaryData IPersistableModel<HyperVToAzStackHciEventModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciEventModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVToAzStackHciEventModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        HyperVToAzStackHciEventModelCustomProperties IPersistableModel<HyperVToAzStackHciEventModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciEventModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVToAzStackHciEventModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVToAzStackHciEventModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVToAzStackHciEventModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
