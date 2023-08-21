// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> Opening hours for a POI (Points of Interest). </summary>
    public partial class OperatingHours
    {
        /// <summary> Initializes a new instance of OperatingHours. </summary>
        internal OperatingHours()
        {
            TimeRanges = new Core.ChangeTrackingList<OperatingHoursTimeRange>();
        }

        /// <summary> Initializes a new instance of OperatingHours. </summary>
        /// <param name="mode"> Value used in the request: none or "nextSevenDays". </param>
        /// <param name="timeRanges"> List of time ranges for the next 7 days. </param>
        internal OperatingHours(string mode, IReadOnlyList<OperatingHoursTimeRange> timeRanges)
        {
            Mode = mode;
            TimeRanges = timeRanges;
        }

        /// <summary> Value used in the request: none or "nextSevenDays". </summary>
        public string Mode { get; }
        /// <summary> List of time ranges for the next 7 days. </summary>
        public IReadOnlyList<OperatingHoursTimeRange> TimeRanges { get; }
    }
}
