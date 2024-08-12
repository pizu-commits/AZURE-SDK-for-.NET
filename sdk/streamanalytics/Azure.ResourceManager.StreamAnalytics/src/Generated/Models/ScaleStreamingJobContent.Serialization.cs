// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ScaleStreamingJobContent : IUtf8JsonSerializable, IJsonModel<ScaleStreamingJobContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScaleStreamingJobContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScaleStreamingJobContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScaleStreamingJobContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StreamingUnits))
            {
                writer.WritePropertyName("streamingUnits"u8);
                writer.WriteNumberValue(StreamingUnits.Value);
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

        ScaleStreamingJobContent IJsonModel<ScaleStreamingJobContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScaleStreamingJobContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScaleStreamingJobContent(document.RootElement, options);
        }

        internal static ScaleStreamingJobContent DeserializeScaleStreamingJobContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? streamingUnits = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    streamingUnits = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScaleStreamingJobContent(streamingUnits, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScaleStreamingJobContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScaleStreamingJobContent)} does not support writing '{options.Format}' format.");
            }
        }

        ScaleStreamingJobContent IPersistableModel<ScaleStreamingJobContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScaleStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScaleStreamingJobContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScaleStreamingJobContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScaleStreamingJobContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
