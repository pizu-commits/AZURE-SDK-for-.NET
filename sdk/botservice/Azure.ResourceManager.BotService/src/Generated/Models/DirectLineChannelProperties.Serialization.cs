// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class DirectLineChannelProperties : IUtf8JsonSerializable, IJsonModel<DirectLineChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DirectLineChannelProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DirectLineChannelProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectLineChannelProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Sites))
            {
                writer.WritePropertyName("sites"u8);
                writer.WriteStartArray();
                foreach (var item in Sites)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExtensionKey1))
            {
                writer.WritePropertyName("extensionKey1"u8);
                writer.WriteStringValue(ExtensionKey1);
            }
            if (Optional.IsDefined(ExtensionKey2))
            {
                writer.WritePropertyName("extensionKey2"u8);
                writer.WriteStringValue(ExtensionKey2);
            }
            if (Optional.IsDefined(DirectLineEmbedCode))
            {
                writer.WritePropertyName("DirectLineEmbedCode"u8);
                writer.WriteStringValue(DirectLineEmbedCode);
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

        DirectLineChannelProperties IJsonModel<DirectLineChannelProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectLineChannelProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectLineChannelProperties(document.RootElement, options);
        }

        internal static DirectLineChannelProperties DeserializeDirectLineChannelProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DirectLineSite>> sites = default;
            Optional<string> extensionKey1 = default;
            Optional<string> extensionKey2 = default;
            Optional<string> directLineEmbedCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sites"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DirectLineSite> array = new List<DirectLineSite>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DirectLineSite.DeserializeDirectLineSite(item));
                    }
                    sites = array;
                    continue;
                }
                if (property.NameEquals("extensionKey1"u8))
                {
                    extensionKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extensionKey2"u8))
                {
                    extensionKey2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DirectLineEmbedCode"u8))
                {
                    directLineEmbedCode = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DirectLineChannelProperties(Optional.ToList(sites), extensionKey1.Value, extensionKey2.Value, directLineEmbedCode.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DirectLineChannelProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DirectLineChannelProperties)} does not support '{options.Format}' format.");
            }
        }

        DirectLineChannelProperties IPersistableModel<DirectLineChannelProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDirectLineChannelProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DirectLineChannelProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DirectLineChannelProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
