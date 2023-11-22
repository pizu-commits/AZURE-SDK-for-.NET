// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class SnapshotPolicyPatch : IUtf8JsonSerializable, IJsonModel<SnapshotPolicyPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotPolicyPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SnapshotPolicyPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SnapshotPolicyPatch)} does not support '{format}' format.");
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
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule"u8);
                writer.WriteObjectValue(HourlySchedule);
            }
            if (Optional.IsDefined(DailySchedule))
            {
                writer.WritePropertyName("dailySchedule"u8);
                writer.WriteObjectValue(DailySchedule);
            }
            if (Optional.IsDefined(WeeklySchedule))
            {
                writer.WritePropertyName("weeklySchedule"u8);
                writer.WriteObjectValue(WeeklySchedule);
            }
            if (Optional.IsDefined(MonthlySchedule))
            {
                writer.WritePropertyName("monthlySchedule"u8);
                writer.WriteObjectValue(MonthlySchedule);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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

        SnapshotPolicyPatch IJsonModel<SnapshotPolicyPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SnapshotPolicyPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotPolicyPatch(document.RootElement, options);
        }

        internal static SnapshotPolicyPatch DeserializeSnapshotPolicyPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SnapshotPolicyHourlySchedule> hourlySchedule = default;
            Optional<SnapshotPolicyDailySchedule> dailySchedule = default;
            Optional<SnapshotPolicyWeeklySchedule> weeklySchedule = default;
            Optional<SnapshotPolicyMonthlySchedule> monthlySchedule = default;
            Optional<bool> enabled = default;
            Optional<string> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("hourlySchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hourlySchedule = SnapshotPolicyHourlySchedule.DeserializeSnapshotPolicyHourlySchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dailySchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailySchedule = SnapshotPolicyDailySchedule.DeserializeSnapshotPolicyDailySchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("weeklySchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weeklySchedule = SnapshotPolicyWeeklySchedule.DeserializeSnapshotPolicyWeeklySchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("monthlySchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monthlySchedule = SnapshotPolicyMonthlySchedule.DeserializeSnapshotPolicyMonthlySchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
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
            return new SnapshotPolicyPatch(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, hourlySchedule.Value, dailySchedule.Value, weeklySchedule.Value, monthlySchedule.Value, Optional.ToNullable(enabled), provisioningState.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotPolicyPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SnapshotPolicyPatch)} does not support '{options.Format}' format.");
            }
        }

        SnapshotPolicyPatch IPersistableModel<SnapshotPolicyPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotPolicyPatch(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SnapshotPolicyPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotPolicyPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
