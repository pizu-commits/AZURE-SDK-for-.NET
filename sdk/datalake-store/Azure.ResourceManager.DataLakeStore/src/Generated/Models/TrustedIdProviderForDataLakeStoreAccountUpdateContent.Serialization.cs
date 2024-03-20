// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class TrustedIdProviderForDataLakeStoreAccountUpdateContent : IUtf8JsonSerializable, IJsonModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrustedIdProviderForDataLakeStoreAccountUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IdProvider))
            {
                writer.WritePropertyName("idProvider"u8);
                writer.WriteStringValue(IdProvider.AbsoluteUri);
            }
            writer.WriteEndObject();
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

        TrustedIdProviderForDataLakeStoreAccountUpdateContent IJsonModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrustedIdProviderForDataLakeStoreAccountUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrustedIdProviderForDataLakeStoreAccountUpdateContent(document.RootElement, options);
        }

        internal static TrustedIdProviderForDataLakeStoreAccountUpdateContent DeserializeTrustedIdProviderForDataLakeStoreAccountUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Uri idProvider = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("idProvider"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idProvider = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrustedIdProviderForDataLakeStoreAccountUpdateContent(name, idProvider, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrustedIdProviderForDataLakeStoreAccountUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        TrustedIdProviderForDataLakeStoreAccountUpdateContent IPersistableModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrustedIdProviderForDataLakeStoreAccountUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrustedIdProviderForDataLakeStoreAccountUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrustedIdProviderForDataLakeStoreAccountUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
