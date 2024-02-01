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
    public partial class NetworkDeviceInterfaceProperties : IUtf8JsonSerializable, IJsonModel<NetworkDeviceInterfaceProperties>, IPersistableModel<NetworkDeviceInterfaceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkDeviceInterfaceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkDeviceInterfaceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkDeviceInterfaceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteStringValue(Identifier);
            }
            if (Optional.IsDefined(InterfaceType))
            {
                writer.WritePropertyName("interfaceType"u8);
                writer.WriteStringValue(InterfaceType);
            }
            if (Optional.IsCollectionDefined(SupportedConnectorTypes))
            {
                writer.WritePropertyName("supportedConnectorTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedConnectorTypes)
                {
                    writer.WriteObjectValue(item);
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

        NetworkDeviceInterfaceProperties IJsonModel<NetworkDeviceInterfaceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkDeviceInterfaceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkDeviceInterfaceProperties(document.RootElement, options);
        }

        internal static NetworkDeviceInterfaceProperties DeserializeNetworkDeviceInterfaceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> identifier = default;
            Optional<string> interfaceType = default;
            Optional<IList<SupportedConnectorProperties>> supportedConnectorTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"u8))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interfaceType"u8))
                {
                    interfaceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedConnectorTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SupportedConnectorProperties> array = new List<SupportedConnectorProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedConnectorProperties.DeserializeSupportedConnectorProperties(item));
                    }
                    supportedConnectorTypes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkDeviceInterfaceProperties(identifier.Value, interfaceType.Value, Optional.ToList(supportedConnectorTypes), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Identifier))
            {
                builder.Append("  identifier:");
                builder.AppendLine($" '{Identifier}'");
            }

            if (Optional.IsDefined(InterfaceType))
            {
                builder.Append("  interfaceType:");
                builder.AppendLine($" '{InterfaceType}'");
            }

            if (Optional.IsCollectionDefined(SupportedConnectorTypes))
            {
                builder.Append("  supportedConnectorTypes:");
                builder.AppendLine(" [");
                foreach (var item in SupportedConnectorTypes)
                {
                    AppendChildObject(builder, item, options, 4);
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

        BinaryData IPersistableModel<NetworkDeviceInterfaceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NetworkDeviceInterfaceProperties)} does not support '{options.Format}' format.");
            }
        }

        NetworkDeviceInterfaceProperties IPersistableModel<NetworkDeviceInterfaceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkDeviceInterfaceProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(NetworkDeviceInterfaceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkDeviceInterfaceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
