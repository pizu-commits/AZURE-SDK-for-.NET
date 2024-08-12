// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryDataFlowCreateDebugSessionResult : IUtf8JsonSerializable, IJsonModel<DataFactoryDataFlowCreateDebugSessionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryDataFlowCreateDebugSessionResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryDataFlowCreateDebugSessionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowCreateDebugSessionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowCreateDebugSessionResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
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

        DataFactoryDataFlowCreateDebugSessionResult IJsonModel<DataFactoryDataFlowCreateDebugSessionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowCreateDebugSessionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowCreateDebugSessionResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataFlowCreateDebugSessionResult(document.RootElement, options);
        }

        internal static DataFactoryDataFlowCreateDebugSessionResult DeserializeDataFactoryDataFlowCreateDebugSessionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            Guid? sessionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFactoryDataFlowCreateDebugSessionResult(status, sessionId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFactoryDataFlowCreateDebugSessionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowCreateDebugSessionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowCreateDebugSessionResult)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryDataFlowCreateDebugSessionResult IPersistableModel<DataFactoryDataFlowCreateDebugSessionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowCreateDebugSessionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryDataFlowCreateDebugSessionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowCreateDebugSessionResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryDataFlowCreateDebugSessionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
