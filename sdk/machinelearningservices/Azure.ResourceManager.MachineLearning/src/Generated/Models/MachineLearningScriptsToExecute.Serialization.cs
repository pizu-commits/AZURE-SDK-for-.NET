// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningScriptsToExecute : IUtf8JsonSerializable, IJsonModel<MachineLearningScriptsToExecute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningScriptsToExecute>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningScriptsToExecute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptsToExecute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScriptsToExecute)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StartupScript))
            {
                writer.WritePropertyName("startupScript"u8);
                writer.WriteObjectValue(StartupScript);
            }
            if (Optional.IsDefined(CreationScript))
            {
                writer.WritePropertyName("creationScript"u8);
                writer.WriteObjectValue(CreationScript);
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

        MachineLearningScriptsToExecute IJsonModel<MachineLearningScriptsToExecute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptsToExecute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScriptsToExecute)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningScriptsToExecute(document.RootElement, options);
        }

        internal static MachineLearningScriptsToExecute DeserializeMachineLearningScriptsToExecute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningScriptReference> startupScript = default;
            Optional<MachineLearningScriptReference> creationScript = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startupScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startupScript = MachineLearningScriptReference.DeserializeMachineLearningScriptReference(property.Value);
                    continue;
                }
                if (property.NameEquals("creationScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationScript = MachineLearningScriptReference.DeserializeMachineLearningScriptReference(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningScriptsToExecute(startupScript.Value, creationScript.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningScriptsToExecute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptsToExecute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScriptsToExecute)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningScriptsToExecute IPersistableModel<MachineLearningScriptsToExecute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptsToExecute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningScriptsToExecute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScriptsToExecute)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningScriptsToExecute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
