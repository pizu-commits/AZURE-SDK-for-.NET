// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    internal partial class AutoUpgradeNodeImageSelection : IUtf8JsonSerializable, IJsonModel<AutoUpgradeNodeImageSelection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoUpgradeNodeImageSelection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutoUpgradeNodeImageSelection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradeNodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoUpgradeNodeImageSelection)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SelectionType.ToString());
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

        AutoUpgradeNodeImageSelection IJsonModel<AutoUpgradeNodeImageSelection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradeNodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoUpgradeNodeImageSelection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoUpgradeNodeImageSelection(document.RootElement, options);
        }

        internal static AutoUpgradeNodeImageSelection DeserializeAutoUpgradeNodeImageSelection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutoUpgradeNodeImageSelectionType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new AutoUpgradeNodeImageSelectionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutoUpgradeNodeImageSelection(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoUpgradeNodeImageSelection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradeNodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoUpgradeNodeImageSelection)} does not support writing '{options.Format}' format.");
            }
        }

        AutoUpgradeNodeImageSelection IPersistableModel<AutoUpgradeNodeImageSelection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradeNodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoUpgradeNodeImageSelection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoUpgradeNodeImageSelection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoUpgradeNodeImageSelection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
