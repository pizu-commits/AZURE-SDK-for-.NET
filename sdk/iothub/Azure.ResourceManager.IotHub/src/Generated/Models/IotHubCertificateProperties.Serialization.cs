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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubCertificateProperties : IUtf8JsonSerializable, IJsonModel<IotHubCertificateProperties>, IPersistableModel<IotHubCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubCertificateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotHubCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubCertificateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(ExpireOn.Value, "R");
            }
            if (options.Format != "W" && Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (Optional.IsDefined(IsVerified))
            {
                writer.WritePropertyName("isVerified"u8);
                writer.WriteBooleanValue(IsVerified.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "R");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "R");
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Certificate);
#else
                using (JsonDocument document = JsonDocument.Parse(Certificate))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        IotHubCertificateProperties IJsonModel<IotHubCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubCertificateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubCertificateProperties(document.RootElement, options);
        }

        internal static IotHubCertificateProperties DeserializeIotHubCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subject = default;
            Optional<DateTimeOffset> expiry = default;
            Optional<string> thumbprint = default;
            Optional<bool> isVerified = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Optional<BinaryData> certificate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isVerified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("updated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updated = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubCertificateProperties(subject.Value, Optional.ToNullable(expiry), thumbprint.Value, Optional.ToNullable(isVerified), Optional.ToNullable(created), Optional.ToNullable(updated), certificate.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Subject))
            {
                builder.Append("  subject:");
                builder.AppendLine($" '{Subject}'");
            }

            if (Optional.IsDefined(ExpireOn))
            {
                builder.Append("  expiry:");
                builder.AppendLine($" '{ExpireOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(ThumbprintString))
            {
                builder.Append("  thumbprint:");
                builder.AppendLine($" '{ThumbprintString}'");
            }

            if (Optional.IsDefined(IsVerified))
            {
                builder.Append("  isVerified:");
                var boolValue = IsVerified.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("  created:");
                builder.AppendLine($" '{CreatedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(UpdatedOn))
            {
                builder.Append("  updated:");
                builder.AppendLine($" '{UpdatedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(Certificate))
            {
                builder.Append("  certificate:");
                builder.AppendLine($" '{Certificate.ToString()}'");
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

        BinaryData IPersistableModel<IotHubCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IotHubCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        IotHubCertificateProperties IPersistableModel<IotHubCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubCertificateProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(IotHubCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
