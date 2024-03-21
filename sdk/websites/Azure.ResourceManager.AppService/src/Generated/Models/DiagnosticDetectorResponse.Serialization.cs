// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticDetectorResponse : IUtf8JsonSerializable, IJsonModel<DiagnosticDetectorResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticDetectorResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiagnosticDetectorResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(IssueDetected))
            {
                writer.WritePropertyName("issueDetected"u8);
                writer.WriteBooleanValue(IssueDetected.Value);
            }
            if (Optional.IsDefined(DetectorDefinition))
            {
                writer.WritePropertyName("detectorDefinition"u8);
                writer.WriteObjectValue(DetectorDefinition);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AbnormalTimePeriods))
            {
                writer.WritePropertyName("abnormalTimePeriods"u8);
                writer.WriteStartArray();
                foreach (var item in AbnormalTimePeriods)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResponseMetaData))
            {
                writer.WritePropertyName("responseMetaData"u8);
                writer.WriteObjectValue(ResponseMetaData);
            }
            writer.WriteEndObject();
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

        DiagnosticDetectorResponse IJsonModel<DiagnosticDetectorResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticDetectorResponse(document.RootElement, options);
        }

        internal static DiagnosticDetectorResponse DeserializeDiagnosticDetectorResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            bool? issueDetected = default;
            DetectorDefinition detectorDefinition = default;
            IList<DiagnosticMetricSet> metrics = default;
            IList<DetectorAbnormalTimePeriod> abnormalTimePeriods = default;
            IList<IList<AppServiceNameValuePair>> data = default;
            DetectorMetadata responseMetaData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("issueDetected"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            issueDetected = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("detectorDefinition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detectorDefinition = DetectorDefinition.DeserializeDetectorDefinition(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DiagnosticMetricSet> array = new List<DiagnosticMetricSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiagnosticMetricSet.DeserializeDiagnosticMetricSet(item, options));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("abnormalTimePeriods"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DetectorAbnormalTimePeriod> array = new List<DetectorAbnormalTimePeriod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DetectorAbnormalTimePeriod.DeserializeDetectorAbnormalTimePeriod(item, options));
                            }
                            abnormalTimePeriods = array;
                            continue;
                        }
                        if (property0.NameEquals("data"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IList<AppServiceNameValuePair>> array = new List<IList<AppServiceNameValuePair>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    List<AppServiceNameValuePair> array0 = new List<AppServiceNameValuePair>();
                                    foreach (var item0 in item.EnumerateArray())
                                    {
                                        array0.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item0, options));
                                    }
                                    array.Add(array0);
                                }
                            }
                            data = array;
                            continue;
                        }
                        if (property0.NameEquals("responseMetaData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            responseMetaData = DetectorMetadata.DeserializeDetectorMetadata(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiagnosticDetectorResponse(
                id,
                name,
                type,
                systemData,
                startTime,
                endTime,
                issueDetected,
                detectorDefinition,
                metrics ?? new ChangeTrackingList<DiagnosticMetricSet>(),
                abnormalTimePeriods ?? new ChangeTrackingList<DetectorAbnormalTimePeriod>(),
                data ?? new ChangeTrackingList<IList<AppServiceNameValuePair>>(),
                responseMetaData,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiagnosticDetectorResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support '{options.Format}' format.");
            }
        }

        DiagnosticDetectorResponse IPersistableModel<DiagnosticDetectorResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiagnosticDetectorResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiagnosticDetectorResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
