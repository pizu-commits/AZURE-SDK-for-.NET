// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SparkScheduler
    {
        internal static SparkScheduler DeserializeSparkScheduler(JsonElement element)
        {
            Optional<DateTimeOffset?> submittedAt = default;
            Optional<DateTimeOffset?> scheduledAt = default;
            Optional<DateTimeOffset?> endedAt = default;
            Optional<DateTimeOffset?> cancellationRequestedAt = default;
            Optional<SchedulerCurrentState> currentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("submittedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        submittedAt = null;
                        continue;
                    }
                    submittedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduledAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scheduledAt = null;
                        continue;
                    }
                    scheduledAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endedAt = null;
                        continue;
                    }
                    endedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cancellationRequestedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancellationRequestedAt = null;
                        continue;
                    }
                    cancellationRequestedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentState = new SchedulerCurrentState(property.Value.GetString());
                    continue;
                }
            }
            return new SparkScheduler(Optional.ToNullable(submittedAt), Optional.ToNullable(scheduledAt), Optional.ToNullable(endedAt), Optional.ToNullable(cancellationRequestedAt), Optional.ToNullable(currentState));
        }
    }
}
