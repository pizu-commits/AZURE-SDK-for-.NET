// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SnowflakeExportCopyCommandConverter))]
    public partial class SnowflakeExportCopyCommand : IUtf8JsonSerializable, IJsonModel<SnowflakeExportCopyCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnowflakeExportCopyCommand>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SnowflakeExportCopyCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SnowflakeExportCopyCommand>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SnowflakeExportCopyCommand>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdditionalCopyOptions))
            {
                writer.WritePropertyName("additionalCopyOptions"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalCopyOptions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(AdditionalFormatOptions))
            {
                writer.WritePropertyName("additionalFormatOptions"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalFormatOptions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        SnowflakeExportCopyCommand IJsonModel<SnowflakeExportCopyCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SnowflakeExportCopyCommand)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnowflakeExportCopyCommand(document.RootElement, options);
        }

        internal static SnowflakeExportCopyCommand DeserializeSnowflakeExportCopyCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, object>> additionalCopyOptions = default;
            Optional<IDictionary<string, object>> additionalFormatOptions = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalCopyOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    additionalCopyOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("additionalFormatOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    additionalFormatOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SnowflakeExportCopyCommand(type, additionalProperties, Optional.ToDictionary(additionalCopyOptions), Optional.ToDictionary(additionalFormatOptions));
        }

        BinaryData IPersistableModel<SnowflakeExportCopyCommand>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SnowflakeExportCopyCommand)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SnowflakeExportCopyCommand IPersistableModel<SnowflakeExportCopyCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SnowflakeExportCopyCommand)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSnowflakeExportCopyCommand(document.RootElement, options);
        }

        string IPersistableModel<SnowflakeExportCopyCommand>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class SnowflakeExportCopyCommandConverter : JsonConverter<SnowflakeExportCopyCommand>
        {
            public override void Write(Utf8JsonWriter writer, SnowflakeExportCopyCommand model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SnowflakeExportCopyCommand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSnowflakeExportCopyCommand(document.RootElement);
            }
        }
    }
}
