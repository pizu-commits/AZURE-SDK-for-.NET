// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    [PersistableModelProxy(typeof(UnknownSingleServerCustomResourceNames))]
    public partial class SingleServerCustomResourceNames : IUtf8JsonSerializable, IJsonModel<SingleServerCustomResourceNames>, IPersistableModel<SingleServerCustomResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingleServerCustomResourceNames>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SingleServerCustomResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerCustomResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerCustomResourceNames)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("namingPatternType"u8);
            writer.WriteStringValue(NamingPatternType.ToString());
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

        SingleServerCustomResourceNames IJsonModel<SingleServerCustomResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerCustomResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerCustomResourceNames)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingleServerCustomResourceNames(document.RootElement, options);
        }

        internal static SingleServerCustomResourceNames DeserializeSingleServerCustomResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("namingPatternType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FullResourceName": return SingleServerFullResourceNames.DeserializeSingleServerFullResourceNames(element);
                }
            }
            return UnknownSingleServerCustomResourceNames.DeserializeUnknownSingleServerCustomResourceNames(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(NamingPatternType))
            {
                builder.Append("  namingPatternType:");
                builder.AppendLine($" '{NamingPatternType.ToString()}'");
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

        BinaryData IPersistableModel<SingleServerCustomResourceNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerCustomResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SingleServerCustomResourceNames)} does not support '{options.Format}' format.");
            }
        }

        SingleServerCustomResourceNames IPersistableModel<SingleServerCustomResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerCustomResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSingleServerCustomResourceNames(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SingleServerCustomResourceNames)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingleServerCustomResourceNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
