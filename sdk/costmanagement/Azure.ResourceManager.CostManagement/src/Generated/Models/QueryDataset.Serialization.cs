// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class QueryDataset : IUtf8JsonSerializable, IJsonModel<QueryDataset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryDataset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<QueryDataset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryDataset)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Granularity))
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration, options);
            }
            if (Optional.IsCollectionDefined(Aggregation))
            {
                writer.WritePropertyName("aggregation"u8);
                writer.WriteStartObject();
                foreach (var item in Aggregation)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Grouping))
            {
                writer.WritePropertyName("grouping"u8);
                writer.WriteStartArray();
                foreach (var item in Grouping)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter, options);
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

        QueryDataset IJsonModel<QueryDataset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryDataset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryDataset(document.RootElement, options);
        }

        internal static QueryDataset DeserializeQueryDataset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GranularityType? granularity = default;
            QueryDatasetConfiguration configuration = default;
            IDictionary<string, QueryAggregation> aggregation = default;
            IList<QueryGrouping> grouping = default;
            QueryFilter filter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new GranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = QueryDatasetConfiguration.DeserializeQueryDatasetConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("aggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, QueryAggregation> dictionary = new Dictionary<string, QueryAggregation>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, QueryAggregation.DeserializeQueryAggregation(property0.Value, options));
                    }
                    aggregation = dictionary;
                    continue;
                }
                if (property.NameEquals("grouping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryGrouping> array = new List<QueryGrouping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryGrouping.DeserializeQueryGrouping(item, options));
                    }
                    grouping = array;
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = QueryFilter.DeserializeQueryFilter(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new QueryDataset(
                granularity,
                configuration,
                aggregation ?? new ChangeTrackingDictionary<string, QueryAggregation>(),
                grouping ?? new ChangeTrackingList<QueryGrouping>(),
                filter,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryDataset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueryDataset)} does not support writing '{options.Format}' format.");
            }
        }

        QueryDataset IPersistableModel<QueryDataset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryDataset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryDataset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryDataset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
