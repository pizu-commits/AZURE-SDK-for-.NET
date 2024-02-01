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
    public partial class GitHubActionWebAppStackSettings : IUtf8JsonSerializable, IJsonModel<GitHubActionWebAppStackSettings>, IPersistableModel<GitHubActionWebAppStackSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GitHubActionWebAppStackSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GitHubActionWebAppStackSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubActionWebAppStackSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IsSupported))
            {
                writer.WritePropertyName("isSupported"u8);
                writer.WriteBooleanValue(IsSupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SupportedVersion))
            {
                writer.WritePropertyName("supportedVersion"u8);
                writer.WriteStringValue(SupportedVersion);
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

        GitHubActionWebAppStackSettings IJsonModel<GitHubActionWebAppStackSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubActionWebAppStackSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubActionWebAppStackSettings(document.RootElement, options);
        }

        internal static GitHubActionWebAppStackSettings DeserializeGitHubActionWebAppStackSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isSupported = default;
            Optional<string> supportedVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedVersion"u8))
                {
                    supportedVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GitHubActionWebAppStackSettings(Optional.ToNullable(isSupported), supportedVersion.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(IsSupported))
            {
                builder.Append("  isSupported:");
                var boolValue = IsSupported.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(SupportedVersion))
            {
                builder.Append("  supportedVersion:");
                builder.AppendLine($" '{SupportedVersion}'");
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

        BinaryData IPersistableModel<GitHubActionWebAppStackSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GitHubActionWebAppStackSettings)} does not support '{options.Format}' format.");
            }
        }

        GitHubActionWebAppStackSettings IPersistableModel<GitHubActionWebAppStackSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGitHubActionWebAppStackSettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(GitHubActionWebAppStackSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GitHubActionWebAppStackSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
