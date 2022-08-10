// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class PipelineElapsedTimeMetricPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration");
                writer.WriteStringValue(Duration.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static PipelineElapsedTimeMetricPolicy DeserializePipelineElapsedTimeMetricPolicy(JsonElement element)
        {
            Optional<TimeSpan> duration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new PipelineElapsedTimeMetricPolicy(Optional.ToNullable(duration));
        }
    }
}
