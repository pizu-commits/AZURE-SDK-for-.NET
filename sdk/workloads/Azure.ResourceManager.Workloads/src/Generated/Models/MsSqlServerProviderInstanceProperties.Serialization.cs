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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class MsSqlServerProviderInstanceProperties : IUtf8JsonSerializable, IJsonModel<MsSqlServerProviderInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MsSqlServerProviderInstanceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MsSqlServerProviderInstanceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsSqlServerProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsSqlServerProviderInstanceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(DBPort))
            {
                writer.WritePropertyName("dbPort"u8);
                writer.WriteStringValue(DBPort);
            }
            if (Optional.IsDefined(DBUsername))
            {
                writer.WritePropertyName("dbUsername"u8);
                writer.WriteStringValue(DBUsername);
            }
            if (Optional.IsDefined(DBPassword))
            {
                writer.WritePropertyName("dbPassword"u8);
                writer.WriteStringValue(DBPassword);
            }
            if (Optional.IsDefined(DBPasswordUri))
            {
                writer.WritePropertyName("dbPasswordUri"u8);
                writer.WriteStringValue(DBPasswordUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SapSid))
            {
                writer.WritePropertyName("sapSid"u8);
                writer.WriteStringValue(SapSid);
            }
            if (Optional.IsDefined(SslPreference))
            {
                writer.WritePropertyName("sslPreference"u8);
                writer.WriteStringValue(SslPreference.Value.ToString());
            }
            if (Optional.IsDefined(SslCertificateUri))
            {
                writer.WritePropertyName("sslCertificateUri"u8);
                writer.WriteStringValue(SslCertificateUri.AbsoluteUri);
            }
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
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

        MsSqlServerProviderInstanceProperties IJsonModel<MsSqlServerProviderInstanceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsSqlServerProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsSqlServerProviderInstanceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMsSqlServerProviderInstanceProperties(document.RootElement, options);
        }

        internal static MsSqlServerProviderInstanceProperties DeserializeMsSqlServerProviderInstanceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hostname = default;
            Optional<string> dbPort = default;
            Optional<string> dbUsername = default;
            Optional<string> dbPassword = default;
            Optional<Uri> dbPasswordUri = default;
            Optional<string> sapSid = default;
            Optional<SapSslPreference> sslPreference = default;
            Optional<Uri> sslCertificateUri = default;
            string providerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPort"u8))
                {
                    dbPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbUsername"u8))
                {
                    dbUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPassword"u8))
                {
                    dbPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPasswordUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbPasswordUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapSid"u8))
                {
                    sapSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPreference = new SapSslPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslCertificateUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MsSqlServerProviderInstanceProperties(providerType, serializedAdditionalRawData, hostname.Value, dbPort.Value, dbUsername.Value, dbPassword.Value, dbPasswordUri.Value, sapSid.Value, Optional.ToNullable(sslPreference), sslCertificateUri.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Hostname))
            {
                builder.Append("  hostname:");
                builder.AppendLine($" '{Hostname}'");
            }

            if (Optional.IsDefined(DBPort))
            {
                builder.Append("  dbPort:");
                builder.AppendLine($" '{DBPort}'");
            }

            if (Optional.IsDefined(DBUsername))
            {
                builder.Append("  dbUsername:");
                builder.AppendLine($" '{DBUsername}'");
            }

            if (Optional.IsDefined(DBPassword))
            {
                builder.Append("  dbPassword:");
                builder.AppendLine($" '{DBPassword}'");
            }

            if (Optional.IsDefined(DBPasswordUri))
            {
                builder.Append("  dbPasswordUri:");
                builder.AppendLine($" '{DBPasswordUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(SapSid))
            {
                builder.Append("  sapSid:");
                builder.AppendLine($" '{SapSid}'");
            }

            if (Optional.IsDefined(SslPreference))
            {
                builder.Append("  sslPreference:");
                builder.AppendLine($" '{SslPreference.ToString()}'");
            }

            if (Optional.IsDefined(SslCertificateUri))
            {
                builder.Append("  sslCertificateUri:");
                builder.AppendLine($" '{SslCertificateUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(ProviderType))
            {
                builder.Append("  providerType:");
                builder.AppendLine($" '{ProviderType}'");
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

        BinaryData IPersistableModel<MsSqlServerProviderInstanceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsSqlServerProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MsSqlServerProviderInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        MsSqlServerProviderInstanceProperties IPersistableModel<MsSqlServerProviderInstanceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsSqlServerProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMsSqlServerProviderInstanceProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MsSqlServerProviderInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MsSqlServerProviderInstanceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
