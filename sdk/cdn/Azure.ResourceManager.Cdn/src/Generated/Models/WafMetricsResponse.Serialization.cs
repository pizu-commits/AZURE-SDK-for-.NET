// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafMetricsResponse : IUtf8JsonSerializable, IJsonModel<WafMetricsResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WafMetricsResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WafMetricsResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WafMetricsResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DateTimeBegin))
            {
                writer.WritePropertyName("dateTimeBegin"u8);
                writer.WriteStringValue(DateTimeBegin.Value, "O");
            }
            if (Optional.IsDefined(DateTimeEnd))
            {
                writer.WritePropertyName("dateTimeEnd"u8);
                writer.WriteStringValue(DateTimeEnd.Value, "O");
            }
            if (Optional.IsDefined(Granularity))
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Series))
            {
                writer.WritePropertyName("series"u8);
                writer.WriteStartArray();
                foreach (var item in Series)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        WafMetricsResponse IJsonModel<WafMetricsResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WafMetricsResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWafMetricsResponse(document.RootElement, options);
        }

        internal static WafMetricsResponse DeserializeWafMetricsResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> dateTimeBegin = default;
            Optional<DateTimeOffset> dateTimeEnd = default;
            Optional<WafMetricsResponseGranularity> granularity = default;
            Optional<IReadOnlyList<WafMetricsResponseSeriesItem>> series = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTimeBegin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeBegin = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dateTimeEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new WafMetricsResponseGranularity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("series"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WafMetricsResponseSeriesItem> array = new List<WafMetricsResponseSeriesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WafMetricsResponseSeriesItem.DeserializeWafMetricsResponseSeriesItem(item));
                    }
                    series = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WafMetricsResponse(Optional.ToNullable(dateTimeBegin), Optional.ToNullable(dateTimeEnd), Optional.ToNullable(granularity), Optional.ToList(series), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WafMetricsResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WafMetricsResponse)} does not support '{options.Format}' format.");
            }
        }

        WafMetricsResponse IPersistableModel<WafMetricsResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWafMetricsResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WafMetricsResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WafMetricsResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
