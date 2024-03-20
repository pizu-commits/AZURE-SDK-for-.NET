// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomMonitoringSignal : IUtf8JsonSerializable, IJsonModel<CustomMonitoringSignal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomMonitoringSignal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomMonitoringSignal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomMonitoringSignal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("componentId"u8);
            writer.WriteStringValue(ComponentId);
            if (Optional.IsCollectionDefined(InputAssets))
            {
                if (InputAssets != null)
                {
                    writer.WritePropertyName("inputAssets"u8);
                    writer.WriteStartObject();
                    foreach (var item in InputAssets)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("inputAssets");
                }
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                if (Inputs != null)
                {
                    writer.WritePropertyName("inputs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Inputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("inputs");
                }
            }
            writer.WritePropertyName("metricThresholds"u8);
            writer.WriteStartArray();
            foreach (var item in MetricThresholds)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("workspaceConnection"u8);
            writer.WriteObjectValue(WorkspaceConnection);
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WritePropertyName("signalType"u8);
            writer.WriteStringValue(SignalType.ToString());
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

        CustomMonitoringSignal IJsonModel<CustomMonitoringSignal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomMonitoringSignal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomMonitoringSignal(document.RootElement, options);
        }

        internal static CustomMonitoringSignal DeserializeCustomMonitoringSignal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string componentId = default;
            IDictionary<string, MonitoringInputDataBase> inputAssets = default;
            IDictionary<string, MachineLearningJobInput> inputs = default;
            IList<CustomMetricThreshold> metricThresholds = default;
            MonitoringWorkspaceConnection workspaceConnection = default;
            MonitoringNotificationMode? mode = default;
            IDictionary<string, string> properties = default;
            MonitoringSignalType signalType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("componentId"u8))
                {
                    componentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputAssets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputAssets = null;
                        continue;
                    }
                    Dictionary<string, MonitoringInputDataBase> dictionary = new Dictionary<string, MonitoringInputDataBase>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property0.Value, options));
                    }
                    inputAssets = dictionary;
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputs = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobInput> dictionary = new Dictionary<string, MachineLearningJobInput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobInput.DeserializeMachineLearningJobInput(property0.Value, options));
                    }
                    inputs = dictionary;
                    continue;
                }
                if (property.NameEquals("metricThresholds"u8))
                {
                    List<CustomMetricThreshold> array = new List<CustomMetricThreshold>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomMetricThreshold.DeserializeCustomMetricThreshold(item, options));
                    }
                    metricThresholds = array;
                    continue;
                }
                if (property.NameEquals("workspaceConnection"u8))
                {
                    workspaceConnection = MonitoringWorkspaceConnection.DeserializeMonitoringWorkspaceConnection(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MonitoringNotificationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    signalType = new MonitoringSignalType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomMonitoringSignal(
                mode,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                signalType,
                serializedAdditionalRawData,
                componentId,
                inputAssets ?? new ChangeTrackingDictionary<string, MonitoringInputDataBase>(),
                inputs ?? new ChangeTrackingDictionary<string, MachineLearningJobInput>(),
                metricThresholds,
                workspaceConnection);
        }

        BinaryData IPersistableModel<CustomMonitoringSignal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomMonitoringSignal)} does not support '{options.Format}' format.");
            }
        }

        CustomMonitoringSignal IPersistableModel<CustomMonitoringSignal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomMonitoringSignal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomMonitoringSignal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomMonitoringSignal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
