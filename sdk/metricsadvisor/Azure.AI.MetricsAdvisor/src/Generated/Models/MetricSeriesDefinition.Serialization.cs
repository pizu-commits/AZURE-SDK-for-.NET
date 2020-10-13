// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricSeriesDefinition
    {
        internal static MetricSeriesDefinition DeserializeMetricSeriesDefinition(JsonElement element)
        {
            Optional<string> metricId = default;
            Optional<IReadOnlyDictionary<string, string>> dimension = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimension"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    dimension = dictionary;
                    continue;
                }
            }
            return new MetricSeriesDefinition(metricId.Value, Optional.ToDictionary(dimension));
        }
    }
}
