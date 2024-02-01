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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class AccessControlListPortCondition : IUtf8JsonSerializable, IJsonModel<AccessControlListPortCondition>, IPersistableModel<AccessControlListPortCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessControlListPortCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessControlListPortCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListPortCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlListPortCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Flags))
            {
                writer.WritePropertyName("flags"u8);
                writer.WriteStartArray();
                foreach (var item in Flags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PortType))
            {
                writer.WritePropertyName("portType"u8);
                writer.WriteStringValue(PortType.Value.ToString());
            }
            writer.WritePropertyName("layer4Protocol"u8);
            writer.WriteStringValue(Layer4Protocol.ToString());
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PortGroupNames))
            {
                writer.WritePropertyName("portGroupNames"u8);
                writer.WriteStartArray();
                foreach (var item in PortGroupNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AccessControlListPortCondition IJsonModel<AccessControlListPortCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListPortCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlListPortCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessControlListPortCondition(document.RootElement, options);
        }

        internal static AccessControlListPortCondition DeserializeAccessControlListPortCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> flags = default;
            Optional<NetworkFabricPortType> portType = default;
            Layer4Protocol layer4Protocol = default;
            Optional<IList<string>> ports = default;
            Optional<IList<string>> portGroupNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("flags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    flags = array;
                    continue;
                }
                if (property.NameEquals("portType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portType = new NetworkFabricPortType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("layer4Protocol"u8))
                {
                    layer4Protocol = new Layer4Protocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
                if (property.NameEquals("portGroupNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    portGroupNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessControlListPortCondition(Optional.ToNullable(portType), layer4Protocol, Optional.ToList(ports), Optional.ToList(portGroupNames), serializedAdditionalRawData, Optional.ToList(flags));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Flags))
            {
                builder.Append("  flags:");
                builder.AppendLine(" [");
                foreach (var item in Flags)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(PortType))
            {
                builder.Append("  portType:");
                builder.AppendLine($" '{PortType.ToString()}'");
            }

            if (Optional.IsDefined(Layer4Protocol))
            {
                builder.Append("  layer4Protocol:");
                builder.AppendLine($" '{Layer4Protocol.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Ports))
            {
                builder.Append("  ports:");
                builder.AppendLine(" [");
                foreach (var item in Ports)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(PortGroupNames))
            {
                builder.Append("  portGroupNames:");
                builder.AppendLine(" [");
                foreach (var item in PortGroupNames)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<AccessControlListPortCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListPortCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AccessControlListPortCondition)} does not support '{options.Format}' format.");
            }
        }

        AccessControlListPortCondition IPersistableModel<AccessControlListPortCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListPortCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessControlListPortCondition(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AccessControlListPortCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessControlListPortCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
