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
    public partial class RunFilterContent : IUtf8JsonSerializable, IJsonModel<RunFilterContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunFilterContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RunFilterContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunFilterContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunFilterContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken"u8);
                writer.WriteStringValue(ContinuationToken);
            }
            writer.WritePropertyName("lastUpdatedAfter"u8);
            writer.WriteStringValue(LastUpdatedAfter, "O");
            writer.WritePropertyName("lastUpdatedBefore"u8);
            writer.WriteStringValue(LastUpdatedBefore, "O");
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OrderBy))
            {
                writer.WritePropertyName("orderBy"u8);
                writer.WriteStartArray();
                foreach (var item in OrderBy)
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

        RunFilterContent IJsonModel<RunFilterContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunFilterContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunFilterContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunFilterContent(document.RootElement, options);
        }

        internal static RunFilterContent DeserializeRunFilterContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string continuationToken = default;
            DateTimeOffset lastUpdatedAfter = default;
            DateTimeOffset lastUpdatedBefore = default;
            IList<RunQueryFilter> filters = default;
            IList<RunQueryOrderBy> orderBy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdatedAfter"u8))
                {
                    lastUpdatedAfter = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedBefore"u8))
                {
                    lastUpdatedBefore = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RunQueryFilter> array = new List<RunQueryFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunQueryFilter.DeserializeRunQueryFilter(item, options));
                    }
                    filters = array;
                    continue;
                }
                if (property.NameEquals("orderBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RunQueryOrderBy> array = new List<RunQueryOrderBy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunQueryOrderBy.DeserializeRunQueryOrderBy(item, options));
                    }
                    orderBy = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunFilterContent(
                continuationToken,
                lastUpdatedAfter,
                lastUpdatedBefore,
                filters ?? new ChangeTrackingList<RunQueryFilter>(),
                orderBy ?? new ChangeTrackingList<RunQueryOrderBy>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunFilterContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunFilterContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunFilterContent)} does not support writing '{options.Format}' format.");
            }
        }

        RunFilterContent IPersistableModel<RunFilterContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunFilterContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunFilterContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunFilterContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunFilterContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
