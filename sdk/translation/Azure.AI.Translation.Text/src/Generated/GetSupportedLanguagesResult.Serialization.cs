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
    public partial class GetSupportedLanguagesResult : IUtf8JsonSerializable, IJsonModel<GetSupportedLanguagesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetSupportedLanguagesResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GetSupportedLanguagesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSupportedLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetSupportedLanguagesResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Translation))
            {
                writer.WritePropertyName("translation"u8);
                writer.WriteStartObject();
                foreach (var item in Translation)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Transliteration))
            {
                writer.WritePropertyName("transliteration"u8);
                writer.WriteStartObject();
                foreach (var item in Transliteration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Dictionary))
            {
                writer.WritePropertyName("dictionary"u8);
                writer.WriteStartObject();
                foreach (var item in Dictionary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        GetSupportedLanguagesResult IJsonModel<GetSupportedLanguagesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSupportedLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetSupportedLanguagesResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetSupportedLanguagesResult(document.RootElement, options);
        }

        internal static GetSupportedLanguagesResult DeserializeGetSupportedLanguagesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, TranslationLanguage> translation = default;
            IReadOnlyDictionary<string, TransliterationLanguage> transliteration = default;
            IReadOnlyDictionary<string, SourceDictionaryLanguage> dictionary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("translation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TranslationLanguage> dictionary0 = new Dictionary<string, TranslationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TranslationLanguage.DeserializeTranslationLanguage(property0.Value, options));
                    }
                    translation = dictionary0;
                    continue;
                }
                if (property.NameEquals("transliteration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TransliterationLanguage> dictionary0 = new Dictionary<string, TransliterationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TransliterationLanguage.DeserializeTransliterationLanguage(property0.Value, options));
                    }
                    transliteration = dictionary0;
                    continue;
                }
                if (property.NameEquals("dictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SourceDictionaryLanguage> dictionary0 = new Dictionary<string, SourceDictionaryLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, SourceDictionaryLanguage.DeserializeSourceDictionaryLanguage(property0.Value, options));
                    }
                    dictionary = dictionary0;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GetSupportedLanguagesResult(translation ?? new ChangeTrackingDictionary<string, TranslationLanguage>(), transliteration ?? new ChangeTrackingDictionary<string, TransliterationLanguage>(), dictionary ?? new ChangeTrackingDictionary<string, SourceDictionaryLanguage>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetSupportedLanguagesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSupportedLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetSupportedLanguagesResult)} does not support writing '{options.Format}' format.");
            }
        }

        GetSupportedLanguagesResult IPersistableModel<GetSupportedLanguagesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSupportedLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetSupportedLanguagesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetSupportedLanguagesResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetSupportedLanguagesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GetSupportedLanguagesResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGetSupportedLanguagesResult(document.RootElement);
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
