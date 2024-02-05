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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SingleServerFullResourceNames : IUtf8JsonSerializable, IJsonModel<SingleServerFullResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingleServerFullResourceNames>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SingleServerFullResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualMachine))
            {
                writer.WritePropertyName("virtualMachine"u8);
                writer.WriteObjectValue(VirtualMachine);
            }
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

        SingleServerFullResourceNames IJsonModel<SingleServerFullResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingleServerFullResourceNames(document.RootElement, options);
        }

        internal static SingleServerFullResourceNames DeserializeSingleServerFullResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualMachineResourceNames> virtualMachine = default;
            SapNamingPatternType namingPatternType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachine = VirtualMachineResourceNames.DeserializeVirtualMachineResourceNames(property.Value);
                    continue;
                }
                if (property.NameEquals("namingPatternType"u8))
                {
                    namingPatternType = new SapNamingPatternType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SingleServerFullResourceNames(namingPatternType, serializedAdditionalRawData, virtualMachine.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(VirtualMachine))
            {
                builder.Append("  virtualMachine:");
                AppendChildObject(builder, VirtualMachine, options, 2, false);
            }

            if (Optional.IsDefined(NamingPatternType))
            {
                builder.Append("  namingPatternType:");
                builder.AppendLine($" '{NamingPatternType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<SingleServerFullResourceNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support '{options.Format}' format.");
            }
        }

        SingleServerFullResourceNames IPersistableModel<SingleServerFullResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSingleServerFullResourceNames(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingleServerFullResourceNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
