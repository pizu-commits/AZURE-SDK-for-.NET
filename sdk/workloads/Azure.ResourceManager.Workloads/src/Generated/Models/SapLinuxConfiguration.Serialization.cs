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
    public partial class SapLinuxConfiguration : IUtf8JsonSerializable, IJsonModel<SapLinuxConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapLinuxConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapLinuxConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapLinuxConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisablePasswordAuthentication))
            {
                writer.WritePropertyName("disablePasswordAuthentication"u8);
                writer.WriteBooleanValue(DisablePasswordAuthentication.Value);
            }
            if (Optional.IsDefined(Ssh))
            {
                writer.WritePropertyName("ssh"u8);
                writer.WriteObjectValue(Ssh);
            }
            if (Optional.IsDefined(SshKeyPair))
            {
                writer.WritePropertyName("sshKeyPair"u8);
                writer.WriteObjectValue(SshKeyPair);
            }
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
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

        SapLinuxConfiguration IJsonModel<SapLinuxConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapLinuxConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapLinuxConfiguration(document.RootElement, options);
        }

        internal static SapLinuxConfiguration DeserializeSapLinuxConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> disablePasswordAuthentication = default;
            Optional<SapSshConfiguration> ssh = default;
            Optional<SapSshKeyPair> sshKeyPair = default;
            SapOSType osType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disablePasswordAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePasswordAuthentication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ssh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssh = SapSshConfiguration.DeserializeSapSshConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("sshKeyPair"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshKeyPair = SapSshKeyPair.DeserializeSapSshKeyPair(property.Value);
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new SapOSType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapLinuxConfiguration(osType, serializedAdditionalRawData, Optional.ToNullable(disablePasswordAuthentication), ssh.Value, sshKeyPair.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(DisablePasswordAuthentication))
            {
                builder.Append("  disablePasswordAuthentication:");
                var boolValue = DisablePasswordAuthentication.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(Ssh))
            {
                builder.Append("  ssh:");
                AppendChildObject(builder, Ssh, options, 2, false);
            }

            if (Optional.IsDefined(SshKeyPair))
            {
                builder.Append("  sshKeyPair:");
                AppendChildObject(builder, SshKeyPair, options, 2, false);
            }

            if (Optional.IsDefined(OSType))
            {
                builder.Append("  osType:");
                builder.AppendLine($" '{OSType.ToString()}'");
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

        BinaryData IPersistableModel<SapLinuxConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SapLinuxConfiguration)} does not support '{options.Format}' format.");
            }
        }

        SapLinuxConfiguration IPersistableModel<SapLinuxConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapLinuxConfiguration(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SapLinuxConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapLinuxConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
