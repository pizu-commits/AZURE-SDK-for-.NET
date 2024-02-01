// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class EdgeUsageDataEventHub : IUtf8JsonSerializable, IJsonModel<EdgeUsageDataEventHub>, IPersistableModel<EdgeUsageDataEventHub>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeUsageDataEventHub>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeUsageDataEventHub>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataEventHub>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeUsageDataEventHub)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
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

        EdgeUsageDataEventHub IJsonModel<EdgeUsageDataEventHub>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataEventHub>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeUsageDataEventHub)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeUsageDataEventHub(document.RootElement, options);
        }

        internal static EdgeUsageDataEventHub DeserializeEdgeUsageDataEventHub(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> @namespace = default;
            Optional<string> token = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeUsageDataEventHub(name.Value, @namespace.Value, token.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(Namespace))
            {
                builder.Append("  namespace:");
                builder.AppendLine($" '{Namespace}'");
            }

            if (Optional.IsDefined(Token))
            {
                builder.Append("  token:");
                builder.AppendLine($" '{Token}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<EdgeUsageDataEventHub>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataEventHub>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EdgeUsageDataEventHub)} does not support '{options.Format}' format.");
            }
        }

        EdgeUsageDataEventHub IPersistableModel<EdgeUsageDataEventHub>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataEventHub>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeUsageDataEventHub(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(EdgeUsageDataEventHub)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeUsageDataEventHub>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
