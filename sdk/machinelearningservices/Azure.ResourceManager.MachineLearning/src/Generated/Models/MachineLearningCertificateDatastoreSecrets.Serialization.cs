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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningCertificateDatastoreSecrets : IUtf8JsonSerializable, IJsonModel<MachineLearningCertificateDatastoreSecrets>, IPersistableModel<MachineLearningCertificateDatastoreSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningCertificateDatastoreSecrets>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningCertificateDatastoreSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCertificateDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningCertificateDatastoreSecrets)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Certificate))
            {
                if (Certificate != null)
                {
                    writer.WritePropertyName("certificate"u8);
                    writer.WriteStringValue(Certificate);
                }
                else
                {
                    writer.WriteNull("certificate");
                }
            }
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
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

        MachineLearningCertificateDatastoreSecrets IJsonModel<MachineLearningCertificateDatastoreSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCertificateDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningCertificateDatastoreSecrets)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningCertificateDatastoreSecrets(document.RootElement, options);
        }

        internal static MachineLearningCertificateDatastoreSecrets DeserializeMachineLearningCertificateDatastoreSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> certificate = default;
            SecretsType secretsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        certificate = null;
                        continue;
                    }
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningCertificateDatastoreSecrets(secretsType, serializedAdditionalRawData, certificate.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Certificate))
            {
                builder.Append("  certificate:");
                builder.AppendLine($" '{Certificate}'");
            }

            if (Optional.IsDefined(SecretsType))
            {
                builder.Append("  secretsType:");
                builder.AppendLine($" '{SecretsType.ToString()}'");
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

        BinaryData IPersistableModel<MachineLearningCertificateDatastoreSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCertificateDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningCertificateDatastoreSecrets)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningCertificateDatastoreSecrets IPersistableModel<MachineLearningCertificateDatastoreSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningCertificateDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningCertificateDatastoreSecrets(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningCertificateDatastoreSecrets)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningCertificateDatastoreSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
