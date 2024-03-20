// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class WebSiteAnalysisDefinitionListResult : IUtf8JsonSerializable, IJsonModel<WebSiteAnalysisDefinitionListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebSiteAnalysisDefinitionListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebSiteAnalysisDefinitionListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteAnalysisDefinitionListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebSiteAnalysisDefinitionListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        WebSiteAnalysisDefinitionListResult IJsonModel<WebSiteAnalysisDefinitionListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteAnalysisDefinitionListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebSiteAnalysisDefinitionListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebSiteAnalysisDefinitionListResult(document.RootElement, options);
        }

        internal static WebSiteAnalysisDefinitionListResult DeserializeWebSiteAnalysisDefinitionListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<WebSiteAnalysisDefinitionData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<WebSiteAnalysisDefinitionData> array = new List<WebSiteAnalysisDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebSiteAnalysisDefinitionData.DeserializeWebSiteAnalysisDefinitionData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebSiteAnalysisDefinitionListResult(value, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebSiteAnalysisDefinitionListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteAnalysisDefinitionListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebSiteAnalysisDefinitionListResult)} does not support '{options.Format}' format.");
            }
        }

        WebSiteAnalysisDefinitionListResult IPersistableModel<WebSiteAnalysisDefinitionListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteAnalysisDefinitionListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebSiteAnalysisDefinitionListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebSiteAnalysisDefinitionListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebSiteAnalysisDefinitionListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
