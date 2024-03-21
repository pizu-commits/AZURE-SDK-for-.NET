// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabVmDetachDataDiskContent : IUtf8JsonSerializable, IJsonModel<DevTestLabVmDetachDataDiskContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabVmDetachDataDiskContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabVmDetachDataDiskContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmDetachDataDiskContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmDetachDataDiskContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExistingLabDiskId))
            {
                writer.WritePropertyName("existingLabDiskId"u8);
                writer.WriteStringValue(ExistingLabDiskId);
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

        DevTestLabVmDetachDataDiskContent IJsonModel<DevTestLabVmDetachDataDiskContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmDetachDataDiskContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmDetachDataDiskContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabVmDetachDataDiskContent(document.RootElement, options);
        }

        internal static DevTestLabVmDetachDataDiskContent DeserializeDevTestLabVmDetachDataDiskContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier existingLabDiskId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("existingLabDiskId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    existingLabDiskId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabVmDetachDataDiskContent(existingLabDiskId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabVmDetachDataDiskContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmDetachDataDiskContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmDetachDataDiskContent)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabVmDetachDataDiskContent IPersistableModel<DevTestLabVmDetachDataDiskContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmDetachDataDiskContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabVmDetachDataDiskContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmDetachDataDiskContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabVmDetachDataDiskContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
