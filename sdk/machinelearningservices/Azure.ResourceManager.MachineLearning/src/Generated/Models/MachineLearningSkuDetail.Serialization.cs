// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSkuDetail : IUtf8JsonSerializable, IJsonModel<MachineLearningSkuDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSkuDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningSkuDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSkuDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSkuDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Capacity))
            {
                if (Capacity != null)
                {
                    writer.WritePropertyName("capacity"u8);
                    writer.WriteObjectValue(Capacity);
                }
                else
                {
                    writer.WriteNull("capacity");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                if (ResourceType != null)
                {
                    writer.WritePropertyName("resourceType"u8);
                    writer.WriteStringValue(ResourceType);
                }
                else
                {
                    writer.WriteNull("resourceType");
                }
            }
            if (Optional.IsDefined(Sku))
            {
                if (Sku != null)
                {
                    writer.WritePropertyName("sku"u8);
                    writer.WriteObjectValue(Sku);
                }
                else
                {
                    writer.WriteNull("sku");
                }
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

        MachineLearningSkuDetail IJsonModel<MachineLearningSkuDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSkuDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSkuDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSkuDetail(document.RootElement, options);
        }

        internal static MachineLearningSkuDetail DeserializeMachineLearningSkuDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningSkuCapacity capacity = default;
            string resourceType = default;
            MachineLearningSkuSetting sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        capacity = null;
                        continue;
                    }
                    capacity = MachineLearningSkuCapacity.DeserializeMachineLearningSkuCapacity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceType = null;
                        continue;
                    }
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sku = null;
                        continue;
                    }
                    sku = MachineLearningSkuSetting.DeserializeMachineLearningSkuSetting(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningSkuDetail(capacity, resourceType, sku, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningSkuDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSkuDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSkuDetail)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningSkuDetail IPersistableModel<MachineLearningSkuDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSkuDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningSkuDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSkuDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSkuDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
