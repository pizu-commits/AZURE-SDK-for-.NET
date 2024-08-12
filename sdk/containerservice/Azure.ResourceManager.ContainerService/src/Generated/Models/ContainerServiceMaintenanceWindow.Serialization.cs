// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceWindow : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceWindow>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceMaintenanceWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("schedule"u8);
            writer.WriteObjectValue(Schedule, options);
            writer.WritePropertyName("durationHours"u8);
            writer.WriteNumberValue(DurationHours);
            if (Optional.IsDefined(UtcOffset))
            {
                writer.WritePropertyName("utcOffset"u8);
                writer.WriteStringValue(UtcOffset);
            }
            if (Optional.IsDefined(StartDate))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartDate);
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime);
            if (Optional.IsCollectionDefined(NotAllowedDates))
            {
                writer.WritePropertyName("notAllowedDates"u8);
                writer.WriteStartArray();
                foreach (var item in NotAllowedDates)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ContainerServiceMaintenanceWindow IJsonModel<ContainerServiceMaintenanceWindow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceWindow(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceWindow DeserializeContainerServiceMaintenanceWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerServiceMaintenanceSchedule schedule = default;
            int durationHours = default;
            string utcOffset = default;
            string startDate = default;
            string startTime = default;
            IList<ContainerServiceDateSpan> notAllowedDates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schedule"u8))
                {
                    schedule = ContainerServiceMaintenanceSchedule.DeserializeContainerServiceMaintenanceSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("durationHours"u8))
                {
                    durationHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("utcOffset"u8))
                {
                    utcOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    startDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notAllowedDates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceDateSpan> array = new List<ContainerServiceDateSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceDateSpan.DeserializeContainerServiceDateSpan(item, options));
                    }
                    notAllowedDates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerServiceMaintenanceWindow(
                schedule,
                durationHours,
                utcOffset,
                startDate,
                startTime,
                notAllowedDates ?? new ChangeTrackingList<ContainerServiceDateSpan>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceWindow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceWindow IPersistableModel<ContainerServiceMaintenanceWindow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceMaintenanceWindow(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceWindow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
