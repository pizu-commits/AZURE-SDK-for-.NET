// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [JsonConverter(typeof(Office365TableOutputColumnConverter))]
    public partial class Office365TableOutputColumn : IUtf8JsonSerializable, IJsonModel<Office365TableOutputColumn>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Office365TableOutputColumn>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Office365TableOutputColumn>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365TableOutputColumn>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Office365TableOutputColumn)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        Office365TableOutputColumn IJsonModel<Office365TableOutputColumn>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365TableOutputColumn>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Office365TableOutputColumn)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOffice365TableOutputColumn(document.RootElement, options);
        }

        internal static Office365TableOutputColumn DeserializeOffice365TableOutputColumn(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Office365TableOutputColumn(name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Office365TableOutputColumn>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365TableOutputColumn>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Office365TableOutputColumn)} does not support writing '{options.Format}' format.");
            }
        }

        Office365TableOutputColumn IPersistableModel<Office365TableOutputColumn>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Office365TableOutputColumn>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOffice365TableOutputColumn(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Office365TableOutputColumn)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Office365TableOutputColumn>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class Office365TableOutputColumnConverter : JsonConverter<Office365TableOutputColumn>
        {
            public override void Write(Utf8JsonWriter writer, Office365TableOutputColumn model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override Office365TableOutputColumn Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeOffice365TableOutputColumn(document.RootElement);
            }
        }
    }
}
