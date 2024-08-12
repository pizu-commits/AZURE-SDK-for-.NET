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
    public partial class MachineLearningFlavorData : IUtf8JsonSerializable, IJsonModel<MachineLearningFlavorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningFlavorData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningFlavorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFlavorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningFlavorData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Data))
            {
                if (Data != null)
                {
                    writer.WritePropertyName("data"u8);
                    writer.WriteStartObject();
                    foreach (var item in Data)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("data");
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

        MachineLearningFlavorData IJsonModel<MachineLearningFlavorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFlavorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningFlavorData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningFlavorData(document.RootElement, options);
        }

        internal static MachineLearningFlavorData DeserializeMachineLearningFlavorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        data = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    data = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningFlavorData(data ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningFlavorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFlavorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningFlavorData)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningFlavorData IPersistableModel<MachineLearningFlavorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFlavorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningFlavorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningFlavorData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningFlavorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
