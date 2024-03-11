// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchTaskContainerSettings : IUtf8JsonSerializable, IJsonModel<BatchTaskContainerSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchTaskContainerSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchTaskContainerSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskContainerSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchTaskContainerSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerRunOptions))
            {
                writer.WritePropertyName("containerRunOptions"u8);
                writer.WriteStringValue(ContainerRunOptions);
            }
            writer.WritePropertyName("imageName"u8);
            writer.WriteStringValue(ImageName);
            if (Optional.IsDefined(Registry))
            {
                writer.WritePropertyName("registry"u8);
                writer.WriteObjectValue(Registry);
            }
            if (Optional.IsDefined(WorkingDirectory))
            {
                writer.WritePropertyName("workingDirectory"u8);
                writer.WriteStringValue(WorkingDirectory.Value.ToSerialString());
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

        BatchTaskContainerSettings IJsonModel<BatchTaskContainerSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskContainerSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchTaskContainerSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchTaskContainerSettings(document.RootElement, options);
        }

        internal static BatchTaskContainerSettings DeserializeBatchTaskContainerSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string containerRunOptions = default;
            string imageName = default;
            BatchVmContainerRegistry registry = default;
            BatchContainerWorkingDirectory? workingDirectory = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerRunOptions"u8))
                {
                    containerRunOptions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registry = BatchVmContainerRegistry.DeserializeBatchVmContainerRegistry(property.Value, options);
                    continue;
                }
                if (property.NameEquals("workingDirectory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workingDirectory = property.Value.GetString().ToBatchContainerWorkingDirectory();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchTaskContainerSettings(containerRunOptions, imageName, registry, workingDirectory, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchTaskContainerSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskContainerSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchTaskContainerSettings)} does not support '{options.Format}' format.");
            }
        }

        BatchTaskContainerSettings IPersistableModel<BatchTaskContainerSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskContainerSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchTaskContainerSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchTaskContainerSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchTaskContainerSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
