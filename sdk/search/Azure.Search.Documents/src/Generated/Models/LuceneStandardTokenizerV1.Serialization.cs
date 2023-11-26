// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    internal partial class LuceneStandardTokenizerV1 : IUtf8JsonSerializable, IJsonModel<LuceneStandardTokenizerV1>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LuceneStandardTokenizerV1>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LuceneStandardTokenizerV1>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuceneStandardTokenizerV1>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LuceneStandardTokenizerV1)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxTokenLength))
            {
                writer.WritePropertyName("maxTokenLength"u8);
                writer.WriteNumberValue(MaxTokenLength.Value);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        LuceneStandardTokenizerV1 IJsonModel<LuceneStandardTokenizerV1>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuceneStandardTokenizerV1>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LuceneStandardTokenizerV1)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLuceneStandardTokenizerV1(document.RootElement, options);
        }

        internal static LuceneStandardTokenizerV1 DeserializeLuceneStandardTokenizerV1(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxTokenLength = default;
            string odataType = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTokenLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokenLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LuceneStandardTokenizerV1(odataType, name, serializedAdditionalRawData, Optional.ToNullable(maxTokenLength));
        }

        BinaryData IPersistableModel<LuceneStandardTokenizerV1>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuceneStandardTokenizerV1>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(LuceneStandardTokenizerV1)} does not support '{options.Format}' format.");
            }
        }

        LuceneStandardTokenizerV1 IPersistableModel<LuceneStandardTokenizerV1>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuceneStandardTokenizerV1>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLuceneStandardTokenizerV1(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(LuceneStandardTokenizerV1)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LuceneStandardTokenizerV1>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
