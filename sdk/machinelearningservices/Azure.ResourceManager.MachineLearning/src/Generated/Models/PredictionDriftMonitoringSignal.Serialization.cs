// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class PredictionDriftMonitoringSignal : IUtf8JsonSerializable, IJsonModel<PredictionDriftMonitoringSignal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictionDriftMonitoringSignal>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PredictionDriftMonitoringSignal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("metricThresholds"u8);
            writer.WriteStartArray();
            foreach (var item in MetricThresholds)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("productionData"u8);
            writer.WriteObjectValue(ProductionData, options);
            writer.WritePropertyName("referenceData"u8);
            writer.WriteObjectValue(ReferenceData, options);
            if (Optional.IsCollectionDefined(FeatureDataTypeOverride))
            {
                if (FeatureDataTypeOverride != null)
                {
                    writer.WritePropertyName("featureDataTypeOverride"u8);
                    writer.WriteStartObject();
                    foreach (var item in FeatureDataTypeOverride)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value.ToString());
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("featureDataTypeOverride");
                }
            }
            writer.WritePropertyName("signalType"u8);
            writer.WriteStringValue(SignalType.ToString());
            if (Optional.IsCollectionDefined(NotificationTypes))
            {
                if (NotificationTypes != null)
                {
                    writer.WritePropertyName("notificationTypes"u8);
                    writer.WriteStartArray();
                    foreach (var item in NotificationTypes)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("notificationTypes");
                }
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

        PredictionDriftMonitoringSignal IJsonModel<PredictionDriftMonitoringSignal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionDriftMonitoringSignal(document.RootElement, options);
        }

        internal static PredictionDriftMonitoringSignal DeserializePredictionDriftMonitoringSignal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PredictionDriftMetricThresholdBase> metricThresholds = default;
            MonitoringInputDataBase productionData = default;
            MonitoringInputDataBase referenceData = default;
            IDictionary<string, MonitoringFeatureDataType> featureDataTypeOverride = default;
            MonitoringSignalType signalType = default;
            IList<MonitoringNotificationType> notificationTypes = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricThresholds"u8))
                {
                    List<PredictionDriftMetricThresholdBase> array = new List<PredictionDriftMetricThresholdBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredictionDriftMetricThresholdBase.DeserializePredictionDriftMetricThresholdBase(item, options));
                    }
                    metricThresholds = array;
                    continue;
                }
                if (property.NameEquals("productionData"u8))
                {
                    productionData = MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("referenceData"u8))
                {
                    referenceData = MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("featureDataTypeOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featureDataTypeOverride = null;
                        continue;
                    }
                    Dictionary<string, MonitoringFeatureDataType> dictionary = new Dictionary<string, MonitoringFeatureDataType>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, new MonitoringFeatureDataType(property0.Value.GetString()));
                    }
                    featureDataTypeOverride = dictionary;
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    signalType = new MonitoringSignalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notificationTypes = null;
                        continue;
                    }
                    List<MonitoringNotificationType> array = new List<MonitoringNotificationType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MonitoringNotificationType(item.GetString()));
                    }
                    notificationTypes = array;
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
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PredictionDriftMonitoringSignal(
                signalType,
                notificationTypes ?? new ChangeTrackingList<MonitoringNotificationType>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                metricThresholds,
                productionData,
                referenceData,
                featureDataTypeOverride ?? new ChangeTrackingDictionary<string, MonitoringFeatureDataType>());
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetricThresholds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metricThresholds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(MetricThresholds))
                {
                    if (MetricThresholds.Any())
                    {
                        builder.Append("  metricThresholds: ");
                        builder.AppendLine("[");
                        foreach (var item in MetricThresholds)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  metricThresholds: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProductionData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  productionData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProductionData))
                {
                    builder.Append("  productionData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ProductionData, options, 2, false, "  productionData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReferenceData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  referenceData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReferenceData))
                {
                    builder.Append("  referenceData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ReferenceData, options, 2, false, "  referenceData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FeatureDataTypeOverride), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  featureDataTypeOverride: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(FeatureDataTypeOverride))
                {
                    if (FeatureDataTypeOverride.Any())
                    {
                        builder.Append("  featureDataTypeOverride: ");
                        builder.AppendLine("{");
                        foreach (var item in FeatureDataTypeOverride)
                        {
                            builder.Append($"    '{item.Key}': ");
                            builder.AppendLine($"'{item.Value.ToString()}'");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SignalType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  signalType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  signalType: ");
                builder.AppendLine($"'{SignalType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotificationTypes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notificationTypes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NotificationTypes))
                {
                    if (NotificationTypes.Any())
                    {
                        builder.Append("  notificationTypes: ");
                        builder.AppendLine("[");
                        foreach (var item in NotificationTypes)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  properties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Properties))
                {
                    if (Properties.Any())
                    {
                        builder.Append("  properties: ");
                        builder.AppendLine("{");
                        foreach (var item in Properties)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PredictionDriftMonitoringSignal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support writing '{options.Format}' format.");
            }
        }

        PredictionDriftMonitoringSignal IPersistableModel<PredictionDriftMonitoringSignal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictionDriftMonitoringSignal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictionDriftMonitoringSignal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
