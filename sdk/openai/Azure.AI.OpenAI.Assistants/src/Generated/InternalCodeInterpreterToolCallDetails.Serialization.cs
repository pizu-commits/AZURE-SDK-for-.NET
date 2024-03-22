// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    internal partial class InternalCodeInterpreterToolCallDetails : IUtf8JsonSerializable, IJsonModel<InternalCodeInterpreterToolCallDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternalCodeInterpreterToolCallDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InternalCodeInterpreterToolCallDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("input"u8);
            writer.WriteStringValue(Input);
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue<RunStepCodeInterpreterToolCallOutput>(item, options);
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

        InternalCodeInterpreterToolCallDetails IJsonModel<InternalCodeInterpreterToolCallDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCodeInterpreterToolCallDetails(document.RootElement, options);
        }

        internal static InternalCodeInterpreterToolCallDetails DeserializeInternalCodeInterpreterToolCallDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string input = default;
            IReadOnlyList<RunStepCodeInterpreterToolCallOutput> outputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    input = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<RunStepCodeInterpreterToolCallOutput> array = new List<RunStepCodeInterpreterToolCallOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunStepCodeInterpreterToolCallOutput.DeserializeRunStepCodeInterpreterToolCallOutput(item, options));
                    }
                    outputs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InternalCodeInterpreterToolCallDetails(input, outputs, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalCodeInterpreterToolCallDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCodeInterpreterToolCallDetails IPersistableModel<InternalCodeInterpreterToolCallDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalCodeInterpreterToolCallDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCodeInterpreterToolCallDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static InternalCodeInterpreterToolCallDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCodeInterpreterToolCallDetails(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<InternalCodeInterpreterToolCallDetails>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
