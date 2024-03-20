// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class BuildDocumentClassifierContent : IUtf8JsonSerializable, IJsonModel<BuildDocumentClassifierContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BuildDocumentClassifierContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BuildDocumentClassifierContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentClassifierContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BuildDocumentClassifierContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("classifierId"u8);
            writer.WriteStringValue(ClassifierId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(BaseClassifierId))
            {
                writer.WritePropertyName("baseClassifierId"u8);
                writer.WriteStringValue(BaseClassifierId);
            }
            writer.WritePropertyName("docTypes"u8);
            writer.WriteStartObject();
            foreach (var item in DocTypes)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
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

        BuildDocumentClassifierContent IJsonModel<BuildDocumentClassifierContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentClassifierContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BuildDocumentClassifierContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBuildDocumentClassifierContent(document.RootElement, options);
        }

        internal static BuildDocumentClassifierContent DeserializeBuildDocumentClassifierContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string classifierId = default;
            string description = default;
            string baseClassifierId = default;
            IDictionary<string, ClassifierDocumentTypeDetails> docTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classifierId"u8))
                {
                    classifierId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseClassifierId"u8))
                {
                    baseClassifierId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("docTypes"u8))
                {
                    Dictionary<string, ClassifierDocumentTypeDetails> dictionary = new Dictionary<string, ClassifierDocumentTypeDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ClassifierDocumentTypeDetails.DeserializeClassifierDocumentTypeDetails(property0.Value, options));
                    }
                    docTypes = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BuildDocumentClassifierContent(classifierId, description, baseClassifierId, docTypes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BuildDocumentClassifierContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentClassifierContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BuildDocumentClassifierContent)} does not support '{options.Format}' format.");
            }
        }

        BuildDocumentClassifierContent IPersistableModel<BuildDocumentClassifierContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentClassifierContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBuildDocumentClassifierContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BuildDocumentClassifierContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BuildDocumentClassifierContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BuildDocumentClassifierContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBuildDocumentClassifierContent(document.RootElement);
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
