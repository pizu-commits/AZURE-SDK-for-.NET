// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetIPTag : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetIPTag>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetIPTag>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineScaleSetIPTag>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPTag>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPTag)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IPTagType))
            {
                writer.WritePropertyName("ipTagType"u8);
                writer.WriteStringValue(IPTagType);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag"u8);
                writer.WriteStringValue(Tag);
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

        VirtualMachineScaleSetIPTag IJsonModel<VirtualMachineScaleSetIPTag>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPTag>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPTag)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetIPTag(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetIPTag DeserializeVirtualMachineScaleSetIPTag(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ipTagType = default;
            string tag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipTagType"u8))
                {
                    ipTagType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineScaleSetIPTag(ipTagType, tag, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetIPTag>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPTag>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPTag)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetIPTag IPersistableModel<VirtualMachineScaleSetIPTag>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPTag>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetIPTag(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPTag)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetIPTag>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
