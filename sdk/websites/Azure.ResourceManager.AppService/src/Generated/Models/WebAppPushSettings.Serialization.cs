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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppPushSettings : IUtf8JsonSerializable, IJsonModel<WebAppPushSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppPushSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppPushSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppPushSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppPushSettings)} does not support '{format}' format.");
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
            if (Optional.IsDefined(IsPushEnabled))
            {
                writer.WritePropertyName("isPushEnabled"u8);
                writer.WriteBooleanValue(IsPushEnabled.Value);
            }
            if (Optional.IsDefined(TagWhitelistJson))
            {
                writer.WritePropertyName("tagWhitelistJson"u8);
                writer.WriteStringValue(TagWhitelistJson);
            }
            if (Optional.IsDefined(TagsRequiringAuth))
            {
                writer.WritePropertyName("tagsRequiringAuth"u8);
                writer.WriteStringValue(TagsRequiringAuth);
            }
            if (Optional.IsDefined(DynamicTagsJson))
            {
                writer.WritePropertyName("dynamicTagsJson"u8);
                writer.WriteStringValue(DynamicTagsJson);
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

        WebAppPushSettings IJsonModel<WebAppPushSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppPushSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppPushSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppPushSettings(document.RootElement, options);
        }

        internal static WebAppPushSettings DeserializeWebAppPushSettings(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<bool> isPushEnabled = default;
            Optional<string> tagWhitelistJson = default;
            Optional<string> tagsRequiringAuth = default;
            Optional<string> dynamicTagsJson = default;
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
                        if (property0.NameEquals("isPushEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPushEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("tagWhitelistJson"u8))
                        {
                            tagWhitelistJson = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tagsRequiringAuth"u8))
                        {
                            tagsRequiringAuth = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dynamicTagsJson"u8))
                        {
                            dynamicTagsJson = property0.Value.GetString();
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
            return new WebAppPushSettings(id, name, type, systemData.Value, Optional.ToNullable(isPushEnabled), tagWhitelistJson.Value, tagsRequiringAuth.Value, dynamicTagsJson.Value, kind.Value, serializedAdditionalRawData);
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
            if (Optional.IsDefined(IsPushEnabled))
            {
                builder.Append("    isPushEnabled:");
                var boolValue = IsPushEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(TagWhitelistJson))
            {
                builder.Append("    tagWhitelistJson:");
                builder.AppendLine($" '{TagWhitelistJson}'");
            }

            if (Optional.IsDefined(TagsRequiringAuth))
            {
                builder.Append("    tagsRequiringAuth:");
                builder.AppendLine($" '{TagsRequiringAuth}'");
            }

            if (Optional.IsDefined(DynamicTagsJson))
            {
                builder.Append("    dynamicTagsJson:");
                builder.AppendLine($" '{DynamicTagsJson}'");
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

        BinaryData IPersistableModel<WebAppPushSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppPushSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebAppPushSettings)} does not support '{options.Format}' format.");
            }
        }

        WebAppPushSettings IPersistableModel<WebAppPushSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppPushSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppPushSettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WebAppPushSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppPushSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
