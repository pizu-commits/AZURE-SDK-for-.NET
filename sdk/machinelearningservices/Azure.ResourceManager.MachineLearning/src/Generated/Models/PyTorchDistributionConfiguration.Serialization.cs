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
    public partial class PyTorchDistributionConfiguration : IUtf8JsonSerializable, IJsonModel<PyTorchDistributionConfiguration>, IPersistableModel<PyTorchDistributionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PyTorchDistributionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PyTorchDistributionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PyTorchDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PyTorchDistributionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProcessCountPerInstance))
            {
                if (ProcessCountPerInstance != null)
                {
                    writer.WritePropertyName("processCountPerInstance"u8);
                    writer.WriteNumberValue(ProcessCountPerInstance.Value);
                }
                else
                {
                    writer.WriteNull("processCountPerInstance");
                }
            }
            writer.WritePropertyName("distributionType"u8);
            writer.WriteStringValue(DistributionType.ToString());
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

        PyTorchDistributionConfiguration IJsonModel<PyTorchDistributionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PyTorchDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PyTorchDistributionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePyTorchDistributionConfiguration(document.RootElement, options);
        }

        internal static PyTorchDistributionConfiguration DeserializePyTorchDistributionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int?> processCountPerInstance = default;
            DistributionType distributionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processCountPerInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        processCountPerInstance = null;
                        continue;
                    }
                    processCountPerInstance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("distributionType"u8))
                {
                    distributionType = new DistributionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PyTorchDistributionConfiguration(distributionType, serializedAdditionalRawData, Optional.ToNullable(processCountPerInstance));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ProcessCountPerInstance))
            {
                builder.Append("  processCountPerInstance:");
                builder.AppendLine($" '{ProcessCountPerInstance.Value.ToString()}'");
            }

            if (Optional.IsDefined(DistributionType))
            {
                builder.Append("  distributionType:");
                builder.AppendLine($" '{DistributionType.ToString()}'");
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

        BinaryData IPersistableModel<PyTorchDistributionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PyTorchDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PyTorchDistributionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        PyTorchDistributionConfiguration IPersistableModel<PyTorchDistributionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PyTorchDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePyTorchDistributionConfiguration(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PyTorchDistributionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PyTorchDistributionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
