// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ReportableException : IUtf8JsonSerializable, IJsonModel<ReportableException>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportableException>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReportableException>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportableException>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportableException)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(ActionableMessage))
            {
                writer.WritePropertyName("actionableMessage"u8);
                writer.WriteStringValue(ActionableMessage);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(LineNumber))
            {
                writer.WritePropertyName("lineNumber"u8);
                writer.WriteStringValue(LineNumber);
            }
            if (Optional.IsDefined(HResult))
            {
                writer.WritePropertyName("hResult"u8);
                writer.WriteNumberValue(HResult.Value);
            }
            if (Optional.IsDefined(StackTrace))
            {
                writer.WritePropertyName("stackTrace"u8);
                writer.WriteStringValue(StackTrace);
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

        ReportableException IJsonModel<ReportableException>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportableException>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportableException)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportableException(document.RootElement, options);
        }

        internal static ReportableException DeserializeReportableException(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string message = default;
            string actionableMessage = default;
            string filePath = default;
            string lineNumber = default;
            int? hResult = default;
            string stackTrace = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionableMessage"u8))
                {
                    actionableMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"u8))
                {
                    filePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lineNumber"u8))
                {
                    lineNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hResult = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stackTrace"u8))
                {
                    stackTrace = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReportableException(
                message,
                actionableMessage,
                filePath,
                lineNumber,
                hResult,
                stackTrace,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportableException>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportableException>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportableException)} does not support writing '{options.Format}' format.");
            }
        }

        ReportableException IPersistableModel<ReportableException>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportableException>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportableException(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportableException)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportableException>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
