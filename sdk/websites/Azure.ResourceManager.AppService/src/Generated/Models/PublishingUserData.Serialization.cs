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

namespace Azure.ResourceManager.AppService
{
    public partial class PublishingUserData : IUtf8JsonSerializable, IJsonModel<PublishingUserData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublishingUserData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PublishingUserData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishingUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublishingUserData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(PublishingUserName))
            {
                writer.WritePropertyName("publishingUserName"u8);
                writer.WriteStringValue(PublishingUserName);
            }
            if (Optional.IsDefined(PublishingPassword))
            {
                writer.WritePropertyName("publishingPassword"u8);
                writer.WriteStringValue(PublishingPassword);
            }
            if (Optional.IsDefined(PublishingPasswordHash))
            {
                writer.WritePropertyName("publishingPasswordHash"u8);
                writer.WriteStringValue(PublishingPasswordHash);
            }
            if (Optional.IsDefined(PublishingPasswordHashSalt))
            {
                writer.WritePropertyName("publishingPasswordHashSalt"u8);
                writer.WriteStringValue(PublishingPasswordHashSalt);
            }
            if (Optional.IsDefined(ScmUri))
            {
                writer.WritePropertyName("scmUri"u8);
                writer.WriteStringValue(ScmUri.AbsoluteUri);
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

        PublishingUserData IJsonModel<PublishingUserData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishingUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublishingUserData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublishingUserData(document.RootElement, options);
        }

        internal static PublishingUserData DeserializePublishingUserData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> publishingUserName = default;
            Optional<string> publishingPassword = default;
            Optional<string> publishingPasswordHash = default;
            Optional<string> publishingPasswordHashSalt = default;
            Optional<Uri> scmUri = default;
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
                        if (property0.NameEquals("publishingUserName"u8))
                        {
                            publishingUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPassword"u8))
                        {
                            publishingPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPasswordHash"u8))
                        {
                            publishingPasswordHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPasswordHashSalt"u8))
                        {
                            publishingPasswordHashSalt = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scmUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scmUri = new Uri(property0.Value.GetString());
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
            return new PublishingUserData(id, name, type, systemData.Value, publishingUserName.Value, publishingPassword.Value, publishingPasswordHash.Value, publishingPasswordHashSalt.Value, scmUri.Value, kind.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

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

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(PublishingUserName))
            {
                builder.Append("    publishingUserName:");
                builder.AppendLine($" '{PublishingUserName}'");
            }

            if (Optional.IsDefined(PublishingPassword))
            {
                builder.Append("    publishingPassword:");
                builder.AppendLine($" '{PublishingPassword}'");
            }

            if (Optional.IsDefined(PublishingPasswordHash))
            {
                builder.Append("    publishingPasswordHash:");
                builder.AppendLine($" '{PublishingPasswordHash}'");
            }

            if (Optional.IsDefined(PublishingPasswordHashSalt))
            {
                builder.Append("    publishingPasswordHashSalt:");
                builder.AppendLine($" '{PublishingPasswordHashSalt}'");
            }

            if (Optional.IsDefined(ScmUri))
            {
                builder.Append("    scmUri:");
                builder.AppendLine($" '{ScmUri.AbsoluteUri}'");
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<PublishingUserData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishingUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PublishingUserData)} does not support '{options.Format}' format.");
            }
        }

        PublishingUserData IPersistableModel<PublishingUserData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublishingUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePublishingUserData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PublishingUserData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublishingUserData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
