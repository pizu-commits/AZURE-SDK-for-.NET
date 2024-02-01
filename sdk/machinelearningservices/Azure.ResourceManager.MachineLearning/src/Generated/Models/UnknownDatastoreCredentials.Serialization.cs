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
    internal partial class UnknownDatastoreCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningDatastoreCredentials>, IPersistableModel<MachineLearningDatastoreCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDatastoreCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningDatastoreCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
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

        MachineLearningDatastoreCredentials IJsonModel<MachineLearningDatastoreCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownDatastoreCredentials(document.RootElement, options);
        }

        internal static UnknownDatastoreCredentials DeserializeUnknownDatastoreCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CredentialsType credentialsType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownDatastoreCredentials(credentialsType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CredentialsType))
            {
                builder.Append("  credentialsType:");
                builder.AppendLine($" '{CredentialsType.ToString()}'");
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

        BinaryData IPersistableModel<MachineLearningDatastoreCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningDatastoreCredentials IPersistableModel<MachineLearningDatastoreCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownDatastoreCredentials(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatastoreCredentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningDatastoreCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
