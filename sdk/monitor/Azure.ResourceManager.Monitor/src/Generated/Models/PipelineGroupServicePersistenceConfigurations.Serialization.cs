// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class PipelineGroupServicePersistenceConfigurations : IUtf8JsonSerializable, IJsonModel<PipelineGroupServicePersistenceConfigurations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineGroupServicePersistenceConfigurations>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PipelineGroupServicePersistenceConfigurations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurations)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("persistentVolumeName"u8);
            writer.WriteStringValue(PersistentVolumeName);
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

        PipelineGroupServicePersistenceConfigurations IJsonModel<PipelineGroupServicePersistenceConfigurations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurations)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineGroupServicePersistenceConfigurations(document.RootElement, options);
        }

        internal static PipelineGroupServicePersistenceConfigurations DeserializePipelineGroupServicePersistenceConfigurations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string persistentVolumeName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("persistentVolumeName"u8))
                {
                    persistentVolumeName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PipelineGroupServicePersistenceConfigurations(persistentVolumeName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PipelineGroupServicePersistenceConfigurations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurations)} does not support writing '{options.Format}' format.");
            }
        }

        PipelineGroupServicePersistenceConfigurations IPersistableModel<PipelineGroupServicePersistenceConfigurations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePipelineGroupServicePersistenceConfigurations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurations)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineGroupServicePersistenceConfigurations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
