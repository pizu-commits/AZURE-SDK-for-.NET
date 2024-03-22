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
    public partial class CreateAndRunThreadOptions : IUtf8JsonSerializable, IJsonModel<CreateAndRunThreadOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateAndRunThreadOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateAndRunThreadOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndRunThreadOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateAndRunThreadOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
            if (Optional.IsDefined(Thread))
            {
                writer.WritePropertyName("thread"u8);
                writer.WriteObjectValue<AssistantThreadCreationOptions>(Thread, options);
            }
            if (Optional.IsDefined(OverrideModelName))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(OverrideModelName);
            }
            if (Optional.IsDefined(OverrideInstructions))
            {
                writer.WritePropertyName("instructions"u8);
                writer.WriteStringValue(OverrideInstructions);
            }
            if (Optional.IsCollectionDefined(OverrideTools))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (var item in OverrideTools)
                {
                    writer.WriteObjectValue<ToolDefinition>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                if (Metadata != null)
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata");
                }
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

        CreateAndRunThreadOptions IJsonModel<CreateAndRunThreadOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndRunThreadOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateAndRunThreadOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateAndRunThreadOptions(document.RootElement, options);
        }

        internal static CreateAndRunThreadOptions DeserializeCreateAndRunThreadOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assistantId = default;
            AssistantThreadCreationOptions thread = default;
            string model = default;
            string instructions = default;
            IList<ToolDefinition> tools = default;
            IDictionary<string, string> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assistant_id"u8))
                {
                    assistantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thread"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thread = AssistantThreadCreationOptions.DeserializeAssistantThreadCreationOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instructions"u8))
                {
                    instructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ToolDefinition> array = new List<ToolDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ToolDefinition.DeserializeToolDefinition(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateAndRunThreadOptions(
                assistantId,
                thread,
                model,
                instructions,
                tools ?? new ChangeTrackingList<ToolDefinition>(),
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateAndRunThreadOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndRunThreadOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateAndRunThreadOptions)} does not support writing '{options.Format}' format.");
            }
        }

        CreateAndRunThreadOptions IPersistableModel<CreateAndRunThreadOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndRunThreadOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateAndRunThreadOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateAndRunThreadOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateAndRunThreadOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CreateAndRunThreadOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateAndRunThreadOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<CreateAndRunThreadOptions>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
