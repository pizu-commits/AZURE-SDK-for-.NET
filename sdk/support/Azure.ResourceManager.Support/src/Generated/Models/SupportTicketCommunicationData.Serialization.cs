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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    public partial class SupportTicketCommunicationData : IUtf8JsonSerializable, IJsonModel<SupportTicketCommunicationData>, IPersistableModel<SupportTicketCommunicationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SupportTicketCommunicationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SupportTicketCommunicationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportTicketCommunicationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportTicketCommunicationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && Optional.IsDefined(CommunicationType))
            {
                writer.WritePropertyName("communicationType"u8);
                writer.WriteStringValue(CommunicationType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CommunicationDirection))
            {
                writer.WritePropertyName("communicationDirection"u8);
                writer.WriteStringValue(CommunicationDirection.Value.ToString());
            }
            if (Optional.IsDefined(Sender))
            {
                writer.WritePropertyName("sender"u8);
                writer.WriteStringValue(Sender);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStringValue(Body);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
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

        SupportTicketCommunicationData IJsonModel<SupportTicketCommunicationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportTicketCommunicationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportTicketCommunicationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportTicketCommunicationData(document.RootElement, options);
        }

        internal static SupportTicketCommunicationData DeserializeSupportTicketCommunicationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SupportTicketCommunicationType> communicationType = default;
            Optional<SupportTicketCommunicationDirection> communicationDirection = default;
            Optional<string> sender = default;
            Optional<string> subject = default;
            Optional<string> body = default;
            Optional<DateTimeOffset> createdDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("communicationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            communicationType = new SupportTicketCommunicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("communicationDirection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            communicationDirection = new SupportTicketCommunicationDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sender"u8))
                        {
                            sender = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subject"u8))
                        {
                            subject = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("body"u8))
                        {
                            body = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
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
            return new SupportTicketCommunicationData(id, name, type, systemData.Value, Optional.ToNullable(communicationType), Optional.ToNullable(communicationDirection), sender.Value, subject.Value, body.Value, Optional.ToNullable(createdDate), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CommunicationType))
            {
                builder.Append("  communicationType:");
                builder.AppendLine($" '{CommunicationType.ToString()}'");
            }

            if (Optional.IsDefined(CommunicationDirection))
            {
                builder.Append("  communicationDirection:");
                builder.AppendLine($" '{CommunicationDirection.ToString()}'");
            }

            if (Optional.IsDefined(Sender))
            {
                builder.Append("  sender:");
                builder.AppendLine($" '{Sender}'");
            }

            if (Optional.IsDefined(Subject))
            {
                builder.Append("  subject:");
                builder.AppendLine($" '{Subject}'");
            }

            if (Optional.IsDefined(Body))
            {
                builder.Append("  body:");
                builder.AppendLine($" '{Body}'");
            }

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("  createdDate:");
                builder.AppendLine($" '{CreatedOn.Value.ToString()}'");
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

        BinaryData IPersistableModel<SupportTicketCommunicationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportTicketCommunicationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SupportTicketCommunicationData)} does not support '{options.Format}' format.");
            }
        }

        SupportTicketCommunicationData IPersistableModel<SupportTicketCommunicationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportTicketCommunicationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSupportTicketCommunicationData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SupportTicketCommunicationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SupportTicketCommunicationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
