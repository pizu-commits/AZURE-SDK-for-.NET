// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWorkspaceDefaultIngestionSettings : IUtf8JsonSerializable, IJsonModel<MonitorWorkspaceDefaultIngestionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorWorkspaceDefaultIngestionSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorWorkspaceDefaultIngestionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceDefaultIngestionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceDefaultIngestionSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DataCollectionRuleResourceId))
            {
                writer.WritePropertyName("dataCollectionRuleResourceId"u8);
                writer.WriteStringValue(DataCollectionRuleResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(DataCollectionEndpointResourceId))
            {
                writer.WritePropertyName("dataCollectionEndpointResourceId"u8);
                writer.WriteStringValue(DataCollectionEndpointResourceId);
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

        MonitorWorkspaceDefaultIngestionSettings IJsonModel<MonitorWorkspaceDefaultIngestionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceDefaultIngestionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceDefaultIngestionSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorWorkspaceDefaultIngestionSettings(document.RootElement, options);
        }

        internal static MonitorWorkspaceDefaultIngestionSettings DeserializeMonitorWorkspaceDefaultIngestionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier dataCollectionRuleResourceId = default;
            ResourceIdentifier dataCollectionEndpointResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataCollectionRuleResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCollectionRuleResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataCollectionEndpointResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCollectionEndpointResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorWorkspaceDefaultIngestionSettings(dataCollectionRuleResourceId, dataCollectionEndpointResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorWorkspaceDefaultIngestionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceDefaultIngestionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceDefaultIngestionSettings)} does not support '{options.Format}' format.");
            }
        }

        MonitorWorkspaceDefaultIngestionSettings IPersistableModel<MonitorWorkspaceDefaultIngestionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceDefaultIngestionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorWorkspaceDefaultIngestionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceDefaultIngestionSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorWorkspaceDefaultIngestionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
