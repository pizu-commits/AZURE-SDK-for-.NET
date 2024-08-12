// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureReachabilityReportLatencyInfo : IUtf8JsonSerializable, IJsonModel<AzureReachabilityReportLatencyInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureReachabilityReportLatencyInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureReachabilityReportLatencyInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLatencyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureReachabilityReportLatencyInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeStamp))
            {
                writer.WritePropertyName("timeStamp"u8);
                writer.WriteStringValue(TimeStamp.Value, "O");
            }
            if (Optional.IsDefined(Score))
            {
                writer.WritePropertyName("score"u8);
                writer.WriteNumberValue(Score.Value);
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

        AzureReachabilityReportLatencyInfo IJsonModel<AzureReachabilityReportLatencyInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLatencyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureReachabilityReportLatencyInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureReachabilityReportLatencyInfo(document.RootElement, options);
        }

        internal static AzureReachabilityReportLatencyInfo DeserializeAzureReachabilityReportLatencyInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timeStamp = default;
            int? score = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("score"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    score = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureReachabilityReportLatencyInfo(timeStamp, score, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureReachabilityReportLatencyInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLatencyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureReachabilityReportLatencyInfo)} does not support writing '{options.Format}' format.");
            }
        }

        AzureReachabilityReportLatencyInfo IPersistableModel<AzureReachabilityReportLatencyInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLatencyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureReachabilityReportLatencyInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureReachabilityReportLatencyInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureReachabilityReportLatencyInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
