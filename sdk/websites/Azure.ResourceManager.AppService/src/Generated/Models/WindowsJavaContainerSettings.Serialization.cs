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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WindowsJavaContainerSettings : IUtf8JsonSerializable, IJsonModel<WindowsJavaContainerSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsJavaContainerSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WindowsJavaContainerSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsJavaContainerSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsJavaContainerSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(JavaContainer))
            {
                writer.WritePropertyName("javaContainer"u8);
                writer.WriteStringValue(JavaContainer);
            }
            if (options.Format != "W" && Optional.IsDefined(JavaContainerVersion))
            {
                writer.WritePropertyName("javaContainerVersion"u8);
                writer.WriteStringValue(JavaContainerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteBooleanValue(IsDeprecated.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("isHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsAutoUpdate))
            {
                writer.WritePropertyName("isAutoUpdate"u8);
                writer.WriteBooleanValue(IsAutoUpdate.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsEarlyAccess))
            {
                writer.WritePropertyName("isEarlyAccess"u8);
                writer.WriteBooleanValue(IsEarlyAccess.Value);
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

        WindowsJavaContainerSettings IJsonModel<WindowsJavaContainerSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsJavaContainerSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsJavaContainerSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsJavaContainerSettings(document.RootElement, options);
        }

        internal static WindowsJavaContainerSettings DeserializeWindowsJavaContainerSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> javaContainer = default;
            Optional<string> javaContainerVersion = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<bool> isAutoUpdate = default;
            Optional<bool> isEarlyAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("javaContainer"u8))
                {
                    javaContainer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("javaContainerVersion"u8))
                {
                    javaContainerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isAutoUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEarlyAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEarlyAccess = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsJavaContainerSettings(javaContainer.Value, javaContainerVersion.Value, Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(isAutoUpdate), Optional.ToNullable(isEarlyAccess), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(JavaContainer))
            {
                builder.Append("  javaContainer:");
                builder.AppendLine($" '{JavaContainer}'");
            }

            if (Optional.IsDefined(JavaContainerVersion))
            {
                builder.Append("  javaContainerVersion:");
                builder.AppendLine($" '{JavaContainerVersion}'");
            }

            if (Optional.IsDefined(IsPreview))
            {
                builder.Append("  isPreview:");
                var boolValue = IsPreview.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsDeprecated))
            {
                builder.Append("  isDeprecated:");
                var boolValue = IsDeprecated.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsHidden))
            {
                builder.Append("  isHidden:");
                var boolValue = IsHidden.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(EndOfLifeOn))
            {
                builder.Append("  endOfLifeDate:");
                var formattedDateTimeString = TypeFormatters.ToString(EndOfLifeOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(IsAutoUpdate))
            {
                builder.Append("  isAutoUpdate:");
                var boolValue = IsAutoUpdate.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsEarlyAccess))
            {
                builder.Append("  isEarlyAccess:");
                var boolValue = IsEarlyAccess.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
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

        BinaryData IPersistableModel<WindowsJavaContainerSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsJavaContainerSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WindowsJavaContainerSettings)} does not support '{options.Format}' format.");
            }
        }

        WindowsJavaContainerSettings IPersistableModel<WindowsJavaContainerSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsJavaContainerSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsJavaContainerSettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WindowsJavaContainerSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsJavaContainerSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
