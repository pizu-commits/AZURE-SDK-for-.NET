// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class ResourceUri : IUtf8JsonSerializable, IJsonModel<ResourceUri>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceUri>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceUri>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceUri>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceUri)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirstSeen))
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (Optional.IsDefined(LastSeen))
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(Recent))
            {
                writer.WritePropertyName("recent"u8);
                writer.WriteBooleanValue(Recent.Value);
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

        ResourceUri IJsonModel<ResourceUri>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceUri>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceUri)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceUri(document.RootElement, options);
        }

        internal static ResourceUri DeserializeResourceUri(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri url = default;
            IReadOnlyList<DependentResource> resources = default;
            DateTimeOffset? firstSeen = default;
            DateTimeOffset? lastSeen = default;
            long? count = default;
            bool? recent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DependentResource> array = new List<DependentResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DependentResource.DeserializeDependentResource(item, options));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recent = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceUri(
                url,
                resources ?? new ChangeTrackingList<DependentResource>(),
                firstSeen,
                lastSeen,
                count,
                recent,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceUri>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceUri>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceUri)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceUri IPersistableModel<ResourceUri>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceUri>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceUri(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceUri)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceUri>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ResourceUri FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeResourceUri(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
