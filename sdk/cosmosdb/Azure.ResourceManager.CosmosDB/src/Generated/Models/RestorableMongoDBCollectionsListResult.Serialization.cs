// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableMongoDBCollectionsListResult : IUtf8JsonSerializable, IJsonModel<RestorableMongoDBCollectionsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestorableMongoDBCollectionsListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestorableMongoDBCollectionsListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBCollectionsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableMongoDBCollectionsListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(Value is ChangeTrackingList<RestorableMongoDBCollection> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        RestorableMongoDBCollectionsListResult IJsonModel<RestorableMongoDBCollectionsListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBCollectionsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableMongoDBCollectionsListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableMongoDBCollectionsListResult(document.RootElement, options);
        }

        internal static RestorableMongoDBCollectionsListResult DeserializeRestorableMongoDBCollectionsListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RestorableMongoDBCollection>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorableMongoDBCollection> array = new List<RestorableMongoDBCollection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableMongoDBCollection.DeserializeRestorableMongoDBCollection(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestorableMongoDBCollectionsListResult(Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestorableMongoDBCollectionsListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBCollectionsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestorableMongoDBCollectionsListResult)} does not support '{options.Format}' format.");
            }
        }

        RestorableMongoDBCollectionsListResult IPersistableModel<RestorableMongoDBCollectionsListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableMongoDBCollectionsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestorableMongoDBCollectionsListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestorableMongoDBCollectionsListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestorableMongoDBCollectionsListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
