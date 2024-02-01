// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AseV3NetworkingConfigurationData : IUtf8JsonSerializable, IJsonModel<AseV3NetworkingConfigurationData>, IPersistableModel<AseV3NetworkingConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AseV3NetworkingConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AseV3NetworkingConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AseV3NetworkingConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AseV3NetworkingConfigurationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(WindowsOutboundIPAddresses))
            {
                writer.WritePropertyName("windowsOutboundIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in WindowsOutboundIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(LinuxOutboundIPAddresses))
            {
                writer.WritePropertyName("linuxOutboundIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in LinuxOutboundIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExternalInboundIPAddresses))
            {
                writer.WritePropertyName("externalInboundIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalInboundIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(InternalInboundIPAddresses))
            {
                writer.WritePropertyName("internalInboundIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in InternalInboundIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowNewPrivateEndpointConnections))
            {
                writer.WritePropertyName("allowNewPrivateEndpointConnections"u8);
                writer.WriteBooleanValue(AllowNewPrivateEndpointConnections.Value);
            }
            writer.WriteEndObject();
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

        AseV3NetworkingConfigurationData IJsonModel<AseV3NetworkingConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AseV3NetworkingConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AseV3NetworkingConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAseV3NetworkingConfigurationData(document.RootElement, options);
        }

        internal static AseV3NetworkingConfigurationData DeserializeAseV3NetworkingConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<IPAddress>> windowsOutboundIPAddresses = default;
            Optional<IReadOnlyList<IPAddress>> linuxOutboundIPAddresses = default;
            Optional<IReadOnlyList<IPAddress>> externalInboundIPAddresses = default;
            Optional<IReadOnlyList<IPAddress>> internalInboundIPAddresses = default;
            Optional<bool> allowNewPrivateEndpointConnections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("windowsOutboundIpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            windowsOutboundIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("linuxOutboundIpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            linuxOutboundIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("externalInboundIpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            externalInboundIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("internalInboundIpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            internalInboundIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("allowNewPrivateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowNewPrivateEndpointConnections = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AseV3NetworkingConfigurationData(id, name, type, systemData.Value, Optional.ToList(windowsOutboundIPAddresses), Optional.ToList(linuxOutboundIPAddresses), Optional.ToList(externalInboundIPAddresses), Optional.ToList(internalInboundIPAddresses), Optional.ToNullable(allowNewPrivateEndpointConnections), kind.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(WindowsOutboundIPAddresses))
            {
                builder.Append("  windowsOutboundIpAddresses:");
                builder.AppendLine(" [");
                foreach (var item in WindowsOutboundIPAddresses)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(LinuxOutboundIPAddresses))
            {
                builder.Append("  linuxOutboundIpAddresses:");
                builder.AppendLine(" [");
                foreach (var item in LinuxOutboundIPAddresses)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(ExternalInboundIPAddresses))
            {
                builder.Append("  externalInboundIpAddresses:");
                builder.AppendLine(" [");
                foreach (var item in ExternalInboundIPAddresses)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsCollectionDefined(InternalInboundIPAddresses))
            {
                builder.Append("  internalInboundIpAddresses:");
                builder.AppendLine(" [");
                foreach (var item in InternalInboundIPAddresses)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item.ToString()}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(AllowNewPrivateEndpointConnections))
            {
                builder.Append("  allowNewPrivateEndpointConnections:");
                var boolValue = AllowNewPrivateEndpointConnections.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
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

        BinaryData IPersistableModel<AseV3NetworkingConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AseV3NetworkingConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AseV3NetworkingConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        AseV3NetworkingConfigurationData IPersistableModel<AseV3NetworkingConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AseV3NetworkingConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAseV3NetworkingConfigurationData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AseV3NetworkingConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AseV3NetworkingConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
