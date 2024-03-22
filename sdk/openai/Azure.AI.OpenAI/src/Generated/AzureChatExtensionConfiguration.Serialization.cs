// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    [PersistableModelProxy(typeof(UnknownAzureChatExtensionConfiguration))]
    public partial class AzureChatExtensionConfiguration : IUtf8JsonSerializable, IJsonModel<AzureChatExtensionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureChatExtensionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureChatExtensionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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

        AzureChatExtensionConfiguration IJsonModel<AzureChatExtensionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatExtensionConfiguration(document.RootElement, options);
        }

        internal static AzureChatExtensionConfiguration DeserializeAzureChatExtensionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "azure_cosmos_db": return AzureCosmosDBChatExtensionConfiguration.DeserializeAzureCosmosDBChatExtensionConfiguration(element, options);
                    case "azure_ml_index": return AzureMachineLearningIndexChatExtensionConfiguration.DeserializeAzureMachineLearningIndexChatExtensionConfiguration(element, options);
                    case "azure_search": return AzureSearchChatExtensionConfiguration.DeserializeAzureSearchChatExtensionConfiguration(element, options);
                    case "elasticsearch": return ElasticsearchChatExtensionConfiguration.DeserializeElasticsearchChatExtensionConfiguration(element, options);
                    case "pinecone": return PineconeChatExtensionConfiguration.DeserializePineconeChatExtensionConfiguration(element, options);
                }
            }
            return UnknownAzureChatExtensionConfiguration.DeserializeUnknownAzureChatExtensionConfiguration(element, options);
        }

        BinaryData IPersistableModel<AzureChatExtensionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        AzureChatExtensionConfiguration IPersistableModel<AzureChatExtensionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureChatExtensionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureChatExtensionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureChatExtensionConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureChatExtensionConfiguration(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<AzureChatExtensionConfiguration>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
