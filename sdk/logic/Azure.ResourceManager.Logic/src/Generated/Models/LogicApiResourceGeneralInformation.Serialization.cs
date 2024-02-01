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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiResourceGeneralInformation : IUtf8JsonSerializable, IJsonModel<LogicApiResourceGeneralInformation>, IPersistableModel<LogicApiResourceGeneralInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiResourceGeneralInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicApiResourceGeneralInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceGeneralInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiResourceGeneralInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("iconUrl"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TermsOfUseUri))
            {
                writer.WritePropertyName("termsOfUseUrl"u8);
                writer.WriteStringValue(TermsOfUseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ReleaseTag))
            {
                writer.WritePropertyName("releaseTag"u8);
                writer.WriteStringValue(ReleaseTag);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
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

        LogicApiResourceGeneralInformation IJsonModel<LogicApiResourceGeneralInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceGeneralInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiResourceGeneralInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiResourceGeneralInformation(document.RootElement, options);
        }

        internal static LogicApiResourceGeneralInformation DeserializeLogicApiResourceGeneralInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> iconUrl = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<Uri> termsOfUseUrl = default;
            Optional<string> releaseTag = default;
            Optional<LogicApiTier> tier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("iconUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iconUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termsOfUseUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    termsOfUseUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("releaseTag"u8))
                {
                    releaseTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new LogicApiTier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicApiResourceGeneralInformation(iconUrl.Value, displayName.Value, description.Value, termsOfUseUrl.Value, releaseTag.Value, Optional.ToNullable(tier), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(IconUri))
            {
                builder.Append("  iconUrl:");
                builder.AppendLine($" '{IconUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("  displayName:");
                builder.AppendLine($" '{DisplayName}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(TermsOfUseUri))
            {
                builder.Append("  termsOfUseUrl:");
                builder.AppendLine($" '{TermsOfUseUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(ReleaseTag))
            {
                builder.Append("  releaseTag:");
                builder.AppendLine($" '{ReleaseTag}'");
            }

            if (Optional.IsDefined(Tier))
            {
                builder.Append("  tier:");
                builder.AppendLine($" '{Tier.ToString()}'");
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

        BinaryData IPersistableModel<LogicApiResourceGeneralInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceGeneralInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LogicApiResourceGeneralInformation)} does not support '{options.Format}' format.");
            }
        }

        LogicApiResourceGeneralInformation IPersistableModel<LogicApiResourceGeneralInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceGeneralInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicApiResourceGeneralInformation(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LogicApiResourceGeneralInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicApiResourceGeneralInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
