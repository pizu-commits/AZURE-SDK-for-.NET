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
    public partial class TableVerticalLimitSettings : IUtf8JsonSerializable, IJsonModel<TableVerticalLimitSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TableVerticalLimitSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TableVerticalLimitSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EnableEarlyTermination))
            {
                writer.WritePropertyName("enableEarlyTermination"u8);
                writer.WriteBooleanValue(EnableEarlyTermination.Value);
            }
            if (Optional.IsDefined(ExitScore))
            {
                if (ExitScore != null)
                {
                    writer.WritePropertyName("exitScore"u8);
                    writer.WriteNumberValue(ExitScore.Value);
                }
                else
                {
                    writer.WriteNull("exitScore");
                }
            }
            if (Optional.IsDefined(MaxConcurrentTrials))
            {
                writer.WritePropertyName("maxConcurrentTrials"u8);
                writer.WriteNumberValue(MaxConcurrentTrials.Value);
            }
            if (Optional.IsDefined(MaxCoresPerTrial))
            {
                writer.WritePropertyName("maxCoresPerTrial"u8);
                writer.WriteNumberValue(MaxCoresPerTrial.Value);
            }
            if (Optional.IsDefined(MaxNodes))
            {
                writer.WritePropertyName("maxNodes"u8);
                writer.WriteNumberValue(MaxNodes.Value);
            }
            if (Optional.IsDefined(MaxTrials))
            {
                writer.WritePropertyName("maxTrials"u8);
                writer.WriteNumberValue(MaxTrials.Value);
            }
            if (Optional.IsDefined(SweepConcurrentTrials))
            {
                writer.WritePropertyName("sweepConcurrentTrials"u8);
                writer.WriteNumberValue(SweepConcurrentTrials.Value);
            }
            if (Optional.IsDefined(SweepTrials))
            {
                writer.WritePropertyName("sweepTrials"u8);
                writer.WriteNumberValue(SweepTrials.Value);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
            }
            if (Optional.IsDefined(TrialTimeout))
            {
                writer.WritePropertyName("trialTimeout"u8);
                writer.WriteStringValue(TrialTimeout.Value, "P");
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

        TableVerticalLimitSettings IJsonModel<TableVerticalLimitSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTableVerticalLimitSettings(document.RootElement, options);
        }

        internal static TableVerticalLimitSettings DeserializeTableVerticalLimitSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableEarlyTermination = default;
            double? exitScore = default;
            int? maxConcurrentTrials = default;
            int? maxCoresPerTrial = default;
            int? maxNodes = default;
            int? maxTrials = default;
            int? sweepConcurrentTrials = default;
            int? sweepTrials = default;
            TimeSpan? timeout = default;
            TimeSpan? trialTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableEarlyTermination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableEarlyTermination = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exitScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        exitScore = null;
                        continue;
                    }
                    exitScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxCoresPerTrial"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCoresPerTrial = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sweepConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sweepConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sweepTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sweepTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("trialTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trialTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TableVerticalLimitSettings(
                enableEarlyTermination,
                exitScore,
                maxConcurrentTrials,
                maxCoresPerTrial,
                maxNodes,
                maxTrials,
                sweepConcurrentTrials,
                sweepTrials,
                timeout,
                trialTimeout,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TableVerticalLimitSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support '{options.Format}' format.");
            }
        }

        TableVerticalLimitSettings IPersistableModel<TableVerticalLimitSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTableVerticalLimitSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TableVerticalLimitSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
