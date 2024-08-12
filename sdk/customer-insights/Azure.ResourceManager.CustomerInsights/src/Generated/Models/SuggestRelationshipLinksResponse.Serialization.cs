// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class SuggestRelationshipLinksResponse : IUtf8JsonSerializable, IJsonModel<SuggestRelationshipLinksResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SuggestRelationshipLinksResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SuggestRelationshipLinksResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SuggestRelationshipLinksResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SuggestRelationshipLinksResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(InteractionName))
            {
                writer.WritePropertyName("interactionName"u8);
                writer.WriteStringValue(InteractionName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SuggestedRelationships))
            {
                writer.WritePropertyName("suggestedRelationships"u8);
                writer.WriteStartArray();
                foreach (var item in SuggestedRelationships)
                {
                    writer.WriteObjectValue(item, options);
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

        SuggestRelationshipLinksResponse IJsonModel<SuggestRelationshipLinksResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SuggestRelationshipLinksResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SuggestRelationshipLinksResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSuggestRelationshipLinksResponse(document.RootElement, options);
        }

        internal static SuggestRelationshipLinksResponse DeserializeSuggestRelationshipLinksResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string interactionName = default;
            IReadOnlyList<RelationshipsLookup> suggestedRelationships = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interactionName"u8))
                {
                    interactionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suggestedRelationships"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RelationshipsLookup> array = new List<RelationshipsLookup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RelationshipsLookup.DeserializeRelationshipsLookup(item, options));
                    }
                    suggestedRelationships = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SuggestRelationshipLinksResponse(interactionName, suggestedRelationships ?? new ChangeTrackingList<RelationshipsLookup>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SuggestRelationshipLinksResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SuggestRelationshipLinksResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SuggestRelationshipLinksResponse)} does not support writing '{options.Format}' format.");
            }
        }

        SuggestRelationshipLinksResponse IPersistableModel<SuggestRelationshipLinksResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SuggestRelationshipLinksResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSuggestRelationshipLinksResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SuggestRelationshipLinksResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SuggestRelationshipLinksResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
