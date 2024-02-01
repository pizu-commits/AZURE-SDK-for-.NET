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

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabConnectionProfile : IUtf8JsonSerializable, IJsonModel<LabConnectionProfile>, IPersistableModel<LabConnectionProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabConnectionProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabConnectionProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabConnectionProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WebSshAccess))
            {
                writer.WritePropertyName("webSshAccess"u8);
                writer.WriteStringValue(WebSshAccess.Value.ToSerialString());
            }
            if (Optional.IsDefined(WebRdpAccess))
            {
                writer.WritePropertyName("webRdpAccess"u8);
                writer.WriteStringValue(WebRdpAccess.Value.ToSerialString());
            }
            if (Optional.IsDefined(ClientSshAccess))
            {
                writer.WritePropertyName("clientSshAccess"u8);
                writer.WriteStringValue(ClientSshAccess.Value.ToSerialString());
            }
            if (Optional.IsDefined(ClientRdpAccess))
            {
                writer.WritePropertyName("clientRdpAccess"u8);
                writer.WriteStringValue(ClientRdpAccess.Value.ToSerialString());
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

        LabConnectionProfile IJsonModel<LabConnectionProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabConnectionProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabConnectionProfile(document.RootElement, options);
        }

        internal static LabConnectionProfile DeserializeLabConnectionProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LabVirtualMachineConnectionType> webSshAccess = default;
            Optional<LabVirtualMachineConnectionType> webRdpAccess = default;
            Optional<LabVirtualMachineConnectionType> clientSshAccess = default;
            Optional<LabVirtualMachineConnectionType> clientRdpAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webSshAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webSshAccess = property.Value.GetString().ToLabVirtualMachineConnectionType();
                    continue;
                }
                if (property.NameEquals("webRdpAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webRdpAccess = property.Value.GetString().ToLabVirtualMachineConnectionType();
                    continue;
                }
                if (property.NameEquals("clientSshAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientSshAccess = property.Value.GetString().ToLabVirtualMachineConnectionType();
                    continue;
                }
                if (property.NameEquals("clientRdpAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientRdpAccess = property.Value.GetString().ToLabVirtualMachineConnectionType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LabConnectionProfile(Optional.ToNullable(webSshAccess), Optional.ToNullable(webRdpAccess), Optional.ToNullable(clientSshAccess), Optional.ToNullable(clientRdpAccess), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(WebSshAccess))
            {
                builder.Append("  webSshAccess:");
                builder.AppendLine($" '{WebSshAccess.ToString()}'");
            }

            if (Optional.IsDefined(WebRdpAccess))
            {
                builder.Append("  webRdpAccess:");
                builder.AppendLine($" '{WebRdpAccess.ToString()}'");
            }

            if (Optional.IsDefined(ClientSshAccess))
            {
                builder.Append("  clientSshAccess:");
                builder.AppendLine($" '{ClientSshAccess.ToString()}'");
            }

            if (Optional.IsDefined(ClientRdpAccess))
            {
                builder.Append("  clientRdpAccess:");
                builder.AppendLine($" '{ClientRdpAccess.ToString()}'");
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

        BinaryData IPersistableModel<LabConnectionProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LabConnectionProfile)} does not support '{options.Format}' format.");
            }
        }

        LabConnectionProfile IPersistableModel<LabConnectionProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabConnectionProfile(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LabConnectionProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabConnectionProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
