// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class RecurrenceScheduleOccurrence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Day))
            {
                writer.WritePropertyName("day");
                writer.WriteStringValue(Day.Value.ToSerialString());
            }
            if (Optional.IsDefined(Occurrence))
            {
                writer.WritePropertyName("occurrence");
                writer.WriteNumberValue(Occurrence.Value);
            }
            writer.WriteEndObject();
        }

        internal static RecurrenceScheduleOccurrence DeserializeRecurrenceScheduleOccurrence(JsonElement element)
        {
            Optional<DayOfWeek> day = default;
            Optional<int> occurrence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("day"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    day = property.Value.GetString().ToDayOfWeek();
                    continue;
                }
                if (property.NameEquals("occurrence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    occurrence = property.Value.GetInt32();
                    continue;
                }
            }
            return new RecurrenceScheduleOccurrence(Optional.ToNullable(day), Optional.ToNullable(occurrence));
        }
    }
}
