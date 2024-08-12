// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class DictionaryTranslation : IUtf8JsonSerializable, IJsonModel<DictionaryTranslation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DictionaryTranslation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DictionaryTranslation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryTranslation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryTranslation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("normalizedTarget"u8);
            writer.WriteStringValue(NormalizedTarget);
            writer.WritePropertyName("displayTarget"u8);
            writer.WriteStringValue(DisplayTarget);
            writer.WritePropertyName("posTag"u8);
            writer.WriteStringValue(PosTag);
            writer.WritePropertyName("confidence"u8);
            writer.WriteNumberValue(Confidence);
            writer.WritePropertyName("prefixWord"u8);
            writer.WriteStringValue(PrefixWord);
            writer.WritePropertyName("backTranslations"u8);
            writer.WriteStartArray();
            foreach (var item in BackTranslations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        DictionaryTranslation IJsonModel<DictionaryTranslation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryTranslation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryTranslation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDictionaryTranslation(document.RootElement, options);
        }

        internal static DictionaryTranslation DeserializeDictionaryTranslation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string normalizedTarget = default;
            string displayTarget = default;
            string posTag = default;
            float confidence = default;
            string prefixWord = default;
            IReadOnlyList<BackTranslation> backTranslations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("normalizedTarget"u8))
                {
                    normalizedTarget = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayTarget"u8))
                {
                    displayTarget = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("posTag"u8))
                {
                    posTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("prefixWord"u8))
                {
                    prefixWord = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backTranslations"u8))
                {
                    List<BackTranslation> array = new List<BackTranslation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackTranslation.DeserializeBackTranslation(item, options));
                    }
                    backTranslations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DictionaryTranslation(
                normalizedTarget,
                displayTarget,
                posTag,
                confidence,
                prefixWord,
                backTranslations,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DictionaryTranslation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryTranslation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DictionaryTranslation)} does not support writing '{options.Format}' format.");
            }
        }

        DictionaryTranslation IPersistableModel<DictionaryTranslation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryTranslation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDictionaryTranslation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DictionaryTranslation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DictionaryTranslation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DictionaryTranslation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDictionaryTranslation(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
