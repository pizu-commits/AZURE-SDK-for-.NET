// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyAlertingConfigurationList
    {
        internal static AnomalyAlertingConfigurationList DeserializeAnomalyAlertingConfigurationList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AnomalyAlertConfiguration> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnomalyAlertConfiguration> array = new List<AnomalyAlertConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnomalyAlertConfiguration.DeserializeAnomalyAlertConfiguration(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AnomalyAlertingConfigurationList(value ?? new ChangeTrackingList<AnomalyAlertConfiguration>(), nextLink);
        }
    }
}
