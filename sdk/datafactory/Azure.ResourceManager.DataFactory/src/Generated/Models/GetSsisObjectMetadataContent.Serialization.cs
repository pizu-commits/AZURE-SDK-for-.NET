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
    public partial class GetSsisObjectMetadataContent : IUtf8JsonSerializable, IJsonModel<GetSsisObjectMetadataContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetSsisObjectMetadataContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetSsisObjectMetadataContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetSsisObjectMetadataContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MetadataPath))
            {
                writer.WritePropertyName("metadataPath"u8);
                writer.WriteStringValue(MetadataPath);
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

        GetSsisObjectMetadataContent IJsonModel<GetSsisObjectMetadataContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetSsisObjectMetadataContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetSsisObjectMetadataContent(document.RootElement, options);
        }

        internal static GetSsisObjectMetadataContent DeserializeGetSsisObjectMetadataContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metadataPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataPath"u8))
                {
                    metadataPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetSsisObjectMetadataContent(metadataPath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetSsisObjectMetadataContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetSsisObjectMetadataContent)} does not support writing '{options.Format}' format.");
            }
        }

        GetSsisObjectMetadataContent IPersistableModel<GetSsisObjectMetadataContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetSsisObjectMetadataContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetSsisObjectMetadataContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetSsisObjectMetadataContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
