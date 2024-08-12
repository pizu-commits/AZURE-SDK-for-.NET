// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class HybridContainerServiceNetworkStatus : IUtf8JsonSerializable, IJsonModel<HybridContainerServiceNetworkStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridContainerServiceNetworkStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HybridContainerServiceNetworkStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceNetworkStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceNetworkStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OperationStatus))
            {
                writer.WritePropertyName("operationStatus"u8);
                writer.WriteObjectValue(OperationStatus, options);
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

        HybridContainerServiceNetworkStatus IJsonModel<HybridContainerServiceNetworkStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceNetworkStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceNetworkStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridContainerServiceNetworkStatus(document.RootElement, options);
        }

        internal static HybridContainerServiceNetworkStatus DeserializeHybridContainerServiceNetworkStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VirtualNetworkPropertiesStatusOperationStatus operationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationStatus = VirtualNetworkPropertiesStatusOperationStatus.DeserializeVirtualNetworkPropertiesStatusOperationStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HybridContainerServiceNetworkStatus(operationStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridContainerServiceNetworkStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceNetworkStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceNetworkStatus)} does not support writing '{options.Format}' format.");
            }
        }

        HybridContainerServiceNetworkStatus IPersistableModel<HybridContainerServiceNetworkStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceNetworkStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridContainerServiceNetworkStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceNetworkStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridContainerServiceNetworkStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
