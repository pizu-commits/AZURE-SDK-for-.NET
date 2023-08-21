// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabServicesScheduleData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startAt"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Core.Optional.IsDefined(StopOn))
            {
                writer.WritePropertyName("stopAt"u8);
                writer.WriteStringValue(StopOn.Value, "O");
            }
            if (Core.Optional.IsDefined(RecurrencePattern))
            {
                writer.WritePropertyName("recurrencePattern"u8);
                writer.WriteObjectValue(RecurrencePattern);
            }
            if (Core.Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId"u8);
                writer.WriteStringValue(TimeZoneId);
            }
            if (Core.Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Notes);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Notes.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LabServicesScheduleData DeserializeLabServicesScheduleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<DateTimeOffset> startAt = default;
            Core.Optional<DateTimeOffset> stopAt = default;
            Core.Optional<LabServicesRecurrencePattern> recurrencePattern = default;
            Core.Optional<string> timeZoneId = default;
            Core.Optional<BinaryData> notes = default;
            Core.Optional<LabServicesProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("startAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("stopAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stopAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recurrencePattern"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recurrencePattern = LabServicesRecurrencePattern.DeserializeLabServicesRecurrencePattern(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"u8))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notes = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToLabServicesProvisioningState();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LabServicesScheduleData(id, name, type, systemData.Value, Core.Optional.ToNullable(startAt), Core.Optional.ToNullable(stopAt), recurrencePattern.Value, timeZoneId.Value, notes.Value, Core.Optional.ToNullable(provisioningState));
        }
    }
}
