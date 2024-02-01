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
    public partial class DataCollectionConfiguration : IUtf8JsonSerializable, IJsonModel<DataCollectionConfiguration>, IPersistableModel<DataCollectionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (Optional.IsDefined(DataCollectionMode))
            {
                writer.WritePropertyName("dataCollectionMode"u8);
                writer.WriteStringValue(DataCollectionMode.Value.ToString());
            }
            if (Optional.IsDefined(DataId))
            {
                if (DataId != null)
                {
                    writer.WritePropertyName("dataId"u8);
                    writer.WriteStringValue(DataId);
                }
                else
                {
                    writer.WriteNull("dataId");
                }
            }
            if (Optional.IsDefined(SamplingRate))
            {
                writer.WritePropertyName("samplingRate"u8);
                writer.WriteNumberValue(SamplingRate.Value);
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

        DataCollectionConfiguration IJsonModel<DataCollectionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionConfiguration(document.RootElement, options);
        }

        internal static DataCollectionConfiguration DeserializeDataCollectionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientId = default;
            Optional<DataCollectionMode> dataCollectionMode = default;
            Optional<string> dataId = default;
            Optional<double> samplingRate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataCollectionMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCollectionMode = new DataCollectionMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataId = null;
                        continue;
                    }
                    dataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("samplingRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingRate = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionConfiguration(clientId.Value, Optional.ToNullable(dataCollectionMode), dataId.Value, Optional.ToNullable(samplingRate), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ClientId))
            {
                builder.Append("  clientId:");
                builder.AppendLine($" '{ClientId}'");
            }

            if (Optional.IsDefined(DataCollectionMode))
            {
                builder.Append("  dataCollectionMode:");
                builder.AppendLine($" '{DataCollectionMode.ToString()}'");
            }

            if (Optional.IsDefined(DataId))
            {
                builder.Append("  dataId:");
                builder.AppendLine($" '{DataId}'");
            }

            if (Optional.IsDefined(SamplingRate))
            {
                builder.Append("  samplingRate:");
                builder.AppendLine($" '{SamplingRate.Value.ToString()}'");
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

        BinaryData IPersistableModel<DataCollectionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DataCollectionConfiguration IPersistableModel<DataCollectionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionConfiguration(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataCollectionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
