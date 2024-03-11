// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptParameter : IUtf8JsonSerializable, IJsonModel<ScriptParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScriptParameter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScriptParameter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptParameter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Avs.Optional.IsDefined(ParameterType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ParameterType.Value.ToString());
            }
            if (Avs.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Avs.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Avs.Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility.Value.ToString());
            }
            if (options.Format != "W" && Avs.Optional.IsDefined(Optional))
            {
                writer.WritePropertyName("optional"u8);
                writer.WriteStringValue(Optional.Value.ToString());
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

        ScriptParameter IJsonModel<ScriptParameter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptParameter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptParameter(document.RootElement, options);
        }

        internal static ScriptParameter DeserializeScriptParameter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScriptParameterType? type = default;
            string name = default;
            string description = default;
            ParameterVisibilityStatus? visibility = default;
            ParameterOptionalityStatus? optional = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ScriptParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    visibility = new ParameterVisibilityStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optional"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optional = new ParameterOptionalityStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScriptParameter(
                type,
                name,
                description,
                visibility,
                optional,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScriptParameter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScriptParameter)} does not support '{options.Format}' format.");
            }
        }

        ScriptParameter IPersistableModel<ScriptParameter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScriptParameter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScriptParameter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScriptParameter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
