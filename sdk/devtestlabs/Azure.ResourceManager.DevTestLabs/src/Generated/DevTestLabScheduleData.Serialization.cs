// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabScheduleData : IUtf8JsonSerializable, IJsonModel<DevTestLabScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabScheduleData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabScheduleData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(TaskType))
            {
                writer.WritePropertyName("taskType"u8);
                writer.WriteStringValue(TaskType);
            }
            if (Optional.IsDefined(WeeklyRecurrence))
            {
                writer.WritePropertyName("weeklyRecurrence"u8);
                writer.WriteObjectValue(WeeklyRecurrence, options);
            }
            if (Optional.IsDefined(DailyRecurrence))
            {
                writer.WritePropertyName("dailyRecurrence"u8);
                writer.WriteObjectValue(DailyRecurrence, options);
            }
            if (Optional.IsDefined(HourlyRecurrence))
            {
                writer.WritePropertyName("hourlyRecurrence"u8);
                writer.WriteObjectValue(HourlyRecurrence, options);
            }
            if (Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId"u8);
                writer.WriteStringValue(TimeZoneId);
            }
            if (Optional.IsDefined(NotificationSettings))
            {
                writer.WritePropertyName("notificationSettings"u8);
                writer.WriteObjectValue(NotificationSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueIdentifier))
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
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

        DevTestLabScheduleData IJsonModel<DevTestLabScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabScheduleData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabScheduleData(document.RootElement, options);
        }

        internal static DevTestLabScheduleData DeserializeDevTestLabScheduleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DevTestLabEnableStatus? status = default;
            string taskType = default;
            DevTestLabWeekDetails weeklyRecurrence = default;
            DayDetails dailyRecurrence = default;
            HourDetails hourlyRecurrence = default;
            string timeZoneId = default;
            DevTestLabNotificationSettings notificationSettings = default;
            DateTimeOffset? createdDate = default;
            string targetResourceId = default;
            string provisioningState = default;
            Guid? uniqueIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new DevTestLabEnableStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("taskType"u8))
                        {
                            taskType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("weeklyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weeklyRecurrence = DevTestLabWeekDetails.DeserializeDevTestLabWeekDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dailyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailyRecurrence = DayDetails.DeserializeDayDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hourlyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hourlyRecurrence = HourDetails.DeserializeHourDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"u8))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notificationSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationSettings = DevTestLabNotificationSettings.DeserializeDevTestLabNotificationSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            targetResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabScheduleData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                status,
                taskType,
                weeklyRecurrence,
                dailyRecurrence,
                hourlyRecurrence,
                timeZoneId,
                notificationSettings,
                createdDate,
                targetResourceId,
                provisioningState,
                uniqueIdentifier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabScheduleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabScheduleData)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabScheduleData IPersistableModel<DevTestLabScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabScheduleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabScheduleData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
