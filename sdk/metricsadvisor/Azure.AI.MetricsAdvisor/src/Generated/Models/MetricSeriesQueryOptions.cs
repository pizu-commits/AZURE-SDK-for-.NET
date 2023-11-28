// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricSeriesQueryOptions. </summary>
    internal partial class MetricSeriesQueryOptions
    {
        /// <summary> Initializes a new instance of <see cref="MetricSeriesQueryOptions"/>. </summary>
        /// <param name="activeSince"> query series ingested after this time, the format should be yyyy-MM-ddTHH:mm:ssZ. </param>
        public MetricSeriesQueryOptions(DateTimeOffset activeSince)
        {
            ActiveSince = activeSince;
            DimensionFilter = new ChangeTrackingDictionary<string, IList<string>>();
        }

        /// <summary> query series ingested after this time, the format should be yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset ActiveSince { get; }
        /// <summary> filter specific dimension name and values. </summary>
        public IDictionary<string, IList<string>> DimensionFilter { get; }
    }
}
