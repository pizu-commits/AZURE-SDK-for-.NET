// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class AdvancedSecurityObject : IUtf8JsonSerializable, IJsonModel<AdvancedSecurityObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdvancedSecurityObject>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdvancedSecurityObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdvancedSecurityObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdvancedSecurityObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AdvSecurityObjectModelType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AdvSecurityObjectModelType);
            }
            writer.WritePropertyName("entry"u8);
            writer.WriteStartArray();
            foreach (var item in Entry)
            {
                writer.WriteObjectValue<NameDescriptionObject>(item, options);
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

        AdvancedSecurityObject IJsonModel<AdvancedSecurityObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdvancedSecurityObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdvancedSecurityObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdvancedSecurityObject(document.RootElement, options);
        }

        internal static AdvancedSecurityObject DeserializeAdvancedSecurityObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IReadOnlyList<NameDescriptionObject> entry = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entry"u8))
                {
                    List<NameDescriptionObject> array = new List<NameDescriptionObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NameDescriptionObject.DeserializeNameDescriptionObject(item, options));
                    }
                    entry = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AdvancedSecurityObject(type, entry, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdvancedSecurityObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdvancedSecurityObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdvancedSecurityObject)} does not support writing '{options.Format}' format.");
            }
        }

        AdvancedSecurityObject IPersistableModel<AdvancedSecurityObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdvancedSecurityObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdvancedSecurityObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdvancedSecurityObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdvancedSecurityObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
