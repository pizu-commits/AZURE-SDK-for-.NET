// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ElasticsearchChatExtensionConfiguration : IUtf8JsonSerializable, IJsonModel<ElasticsearchChatExtensionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticsearchChatExtensionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticsearchChatExtensionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticsearchChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticsearchChatExtensionConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue<ElasticsearchChatExtensionParameters>(Parameters, options);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        ElasticsearchChatExtensionConfiguration IJsonModel<ElasticsearchChatExtensionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticsearchChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticsearchChatExtensionConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticsearchChatExtensionConfiguration(document.RootElement, options);
        }

        internal static ElasticsearchChatExtensionConfiguration DeserializeElasticsearchChatExtensionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ElasticsearchChatExtensionParameters parameters = default;
            AzureChatExtensionType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = ElasticsearchChatExtensionParameters.DeserializeElasticsearchChatExtensionParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new AzureChatExtensionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ElasticsearchChatExtensionConfiguration(type, serializedAdditionalRawData, parameters);
        }

        BinaryData IPersistableModel<ElasticsearchChatExtensionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticsearchChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticsearchChatExtensionConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticsearchChatExtensionConfiguration IPersistableModel<ElasticsearchChatExtensionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticsearchChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticsearchChatExtensionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticsearchChatExtensionConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticsearchChatExtensionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ElasticsearchChatExtensionConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeElasticsearchChatExtensionConfiguration(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ElasticsearchChatExtensionConfiguration>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
