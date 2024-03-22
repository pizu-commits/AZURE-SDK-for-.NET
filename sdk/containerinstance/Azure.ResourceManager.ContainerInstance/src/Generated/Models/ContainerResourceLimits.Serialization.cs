// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerResourceLimits : IUtf8JsonSerializable, IJsonModel<ContainerResourceLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerResourceLimits>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerResourceLimits>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerResourceLimits)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MemoryInGB))
            {
                writer.WritePropertyName("memoryInGB"u8);
                writer.WriteNumberValue(MemoryInGB.Value);
            }
            if (Optional.IsDefined(Cpu))
            {
                writer.WritePropertyName("cpu"u8);
                writer.WriteNumberValue(Cpu.Value);
            }
            if (Optional.IsDefined(Gpu))
            {
                writer.WritePropertyName("gpu"u8);
                writer.WriteObjectValue(Gpu);
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

        ContainerResourceLimits IJsonModel<ContainerResourceLimits>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerResourceLimits)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerResourceLimits(document.RootElement, options);
        }

        internal static ContainerResourceLimits DeserializeContainerResourceLimits(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? memoryInGB = default;
            double? cpu = default;
            ContainerGpuResourceInfo gpu = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memoryInGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("cpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpu = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("gpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gpu = ContainerGpuResourceInfo.DeserializeContainerGpuResourceInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerResourceLimits(memoryInGB, cpu, gpu, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerResourceLimits>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerResourceLimits)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerResourceLimits IPersistableModel<ContainerResourceLimits>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerResourceLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerResourceLimits(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerResourceLimits)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerResourceLimits>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
