// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MetricValue
    {
        internal static MetricValue DeserializeMetricValue(JsonElement element)
        {
            Optional<int> Count = default;
            Optional<double> average = default;
            Optional<double> maximum = default;
            Optional<double> minimum = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<double> total = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_count"))
                {
                    Count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("average"))
                {
                    average = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maximum"))
                {
                    maximum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("minimum"))
                {
                    minimum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    total = property.Value.GetDouble();
                    continue;
                }
            }
            return new MetricValue(Optional.ToNullable(Count), Optional.ToNullable(average), Optional.ToNullable(maximum), Optional.ToNullable(minimum), Optional.ToNullable(timestamp), Optional.ToNullable(total));
        }
    }
}
