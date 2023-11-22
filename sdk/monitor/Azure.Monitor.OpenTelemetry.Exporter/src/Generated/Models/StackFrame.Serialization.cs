// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class StackFrame : IUtf8JsonSerializable, IJsonModel<StackFrame>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StackFrame>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StackFrame>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackFrame>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(StackFrame)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("level"u8);
            writer.WriteNumberValue(Level);
            writer.WritePropertyName("method"u8);
            writer.WriteStringValue(Method);
            if (Optional.IsDefined(Assembly))
            {
                writer.WritePropertyName("assembly"u8);
                writer.WriteStringValue(Assembly);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Line))
            {
                writer.WritePropertyName("line"u8);
                writer.WriteNumberValue(Line.Value);
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

        StackFrame IJsonModel<StackFrame>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackFrame>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(StackFrame)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStackFrame(document.RootElement, options);
        }

        internal static StackFrame DeserializeStackFrame(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int level = default;
            string method = default;
            Optional<string> assembly = default;
            Optional<string> fileName = default;
            Optional<int> line = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    method = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assembly"u8))
                {
                    assembly = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("line"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    line = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StackFrame(level, method, assembly.Value, fileName.Value, Optional.ToNullable(line), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StackFrame>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackFrame>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(StackFrame)} does not support '{options.Format}' format.");
            }
        }

        StackFrame IPersistableModel<StackFrame>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackFrame>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStackFrame(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(StackFrame)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StackFrame>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
