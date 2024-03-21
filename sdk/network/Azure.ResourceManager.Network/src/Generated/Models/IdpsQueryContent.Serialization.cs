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
    public partial class IdpsQueryContent : IUtf8JsonSerializable, IJsonModel<IdpsQueryContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IdpsQueryContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IdpsQueryContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsQueryContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Search))
            {
                writer.WritePropertyName("search"u8);
                writer.WriteStringValue(Search);
            }
            if (Optional.IsDefined(OrderBy))
            {
                writer.WritePropertyName("orderBy"u8);
                writer.WriteObjectValue(OrderBy);
            }
            if (Optional.IsDefined(ResultsPerPage))
            {
                writer.WritePropertyName("resultsPerPage"u8);
                writer.WriteNumberValue(ResultsPerPage.Value);
            }
            if (Optional.IsDefined(Skip))
            {
                writer.WritePropertyName("skip"u8);
                writer.WriteNumberValue(Skip.Value);
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

        IdpsQueryContent IJsonModel<IdpsQueryContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsQueryContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIdpsQueryContent(document.RootElement, options);
        }

        internal static IdpsQueryContent DeserializeIdpsQueryContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IdpsQueryFilterItems> filters = default;
            string search = default;
            IdpsQueryOrderBy orderBy = default;
            int? resultsPerPage = default;
            int? skip = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdpsQueryFilterItems> array = new List<IdpsQueryFilterItems>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IdpsQueryFilterItems.DeserializeIdpsQueryFilterItems(item, options));
                    }
                    filters = array;
                    continue;
                }
                if (property.NameEquals("search"u8))
                {
                    search = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orderBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orderBy = IdpsQueryOrderBy.DeserializeIdpsQueryOrderBy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resultsPerPage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultsPerPage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IdpsQueryContent(
                filters ?? new ChangeTrackingList<IdpsQueryFilterItems>(),
                search,
                orderBy,
                resultsPerPage,
                skip,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IdpsQueryContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IdpsQueryContent)} does not support '{options.Format}' format.");
            }
        }

        IdpsQueryContent IPersistableModel<IdpsQueryContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIdpsQueryContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IdpsQueryContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IdpsQueryContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
