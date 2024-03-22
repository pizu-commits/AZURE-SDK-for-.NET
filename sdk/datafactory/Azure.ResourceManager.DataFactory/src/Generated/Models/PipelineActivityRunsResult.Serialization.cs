// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class PipelineActivityRunsResult : IUtf8JsonSerializable, IJsonModel<PipelineActivityRunsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineActivityRunsResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PipelineActivityRunsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivityRunsResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken"u8);
                writer.WriteStringValue(ContinuationToken);
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

        PipelineActivityRunsResult IJsonModel<PipelineActivityRunsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivityRunsResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineActivityRunsResult(document.RootElement, options);
        }

        internal static PipelineActivityRunsResult DeserializePipelineActivityRunsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PipelineActivityRunInformation> value = default;
            string continuationToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<PipelineActivityRunInformation> array = new List<PipelineActivityRunInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityRunInformation.DeserializePipelineActivityRunInformation(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PipelineActivityRunsResult(value, continuationToken, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PipelineActivityRunsResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineActivityRunsResult)} does not support writing '{options.Format}' format.");
            }
        }

        PipelineActivityRunsResult IPersistableModel<PipelineActivityRunsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePipelineActivityRunsResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineActivityRunsResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineActivityRunsResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
