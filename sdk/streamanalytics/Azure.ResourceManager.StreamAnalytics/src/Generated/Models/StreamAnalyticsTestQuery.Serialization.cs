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
    public partial class StreamAnalyticsTestQuery : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsTestQuery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsTestQuery>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamAnalyticsTestQuery>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestQuery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsTestQuery)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("streamingJob"u8);
            writer.WriteObjectValue(StreamingJob);
            writer.WritePropertyName("diagnostics"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WriteUri))
            {
                writer.WritePropertyName("writeUri"u8);
                writer.WriteStringValue(WriteUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
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

        StreamAnalyticsTestQuery IJsonModel<StreamAnalyticsTestQuery>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestQuery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsTestQuery)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsTestQuery(document.RootElement, options);
        }

        internal static StreamAnalyticsTestQuery DeserializeStreamAnalyticsTestQuery(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingJobData streamingJob = default;
            Uri writeUri = default;
            string path = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingJob"u8))
                {
                    streamingJob = StreamingJobData.DeserializeStreamingJobData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("writeUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            writeUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamAnalyticsTestQuery(streamingJob, writeUri, path, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamAnalyticsTestQuery>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestQuery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsTestQuery)} does not support '{options.Format}' format.");
            }
        }

        StreamAnalyticsTestQuery IPersistableModel<StreamAnalyticsTestQuery>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestQuery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsTestQuery(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsTestQuery)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsTestQuery>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
