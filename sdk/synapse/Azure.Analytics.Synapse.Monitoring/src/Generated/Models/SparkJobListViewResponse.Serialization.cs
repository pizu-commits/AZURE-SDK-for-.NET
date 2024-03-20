// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Analytics.Synapse.Monitoring.Models
{
    public partial class SparkJobListViewResponse
    {
        internal static SparkJobListViewResponse DeserializeSparkJobListViewResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? nJobs = default;
            IReadOnlyList<SparkJob> sparkJobs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nJobs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sparkJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkJob> array = new List<SparkJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkJob.DeserializeSparkJob(item));
                    }
                    sparkJobs = array;
                    continue;
                }
            }
            return new SparkJobListViewResponse(nJobs, sparkJobs ?? new ChangeTrackingList<SparkJob>());
        }
    }
}
