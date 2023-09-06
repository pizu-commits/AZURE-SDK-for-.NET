// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The EdgeUsageDataCollectionPolicy. </summary>
    public partial class EdgeUsageDataCollectionPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeUsageDataCollectionPolicy"/>. </summary>
        internal EdgeUsageDataCollectionPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeUsageDataCollectionPolicy"/>. </summary>
        /// <param name="dataCollectionFrequency"> Usage data collection frequency in ISO 8601 duration format e.g. PT10M , PT5H. </param>
        /// <param name="dataReportingFrequency"> Usage data reporting frequency in ISO 8601 duration format e.g. PT10M , PT5H. </param>
        /// <param name="maxAllowedUnreportedUsageDuration"> Maximum time for which the functionality of the device will not be hampered for not reporting the usage data. </param>
        /// <param name="eventHubDetails"> Details of Event Hub where the usage will be reported. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeUsageDataCollectionPolicy(string dataCollectionFrequency, string dataReportingFrequency, TimeSpan? maxAllowedUnreportedUsageDuration, EdgeUsageDataEventHub eventHubDetails, Dictionary<string, BinaryData> rawData)
        {
            DataCollectionFrequency = dataCollectionFrequency;
            DataReportingFrequency = dataReportingFrequency;
            MaxAllowedUnreportedUsageDuration = maxAllowedUnreportedUsageDuration;
            EventHubDetails = eventHubDetails;
            _rawData = rawData;
        }

        /// <summary> Usage data collection frequency in ISO 8601 duration format e.g. PT10M , PT5H. </summary>
        public string DataCollectionFrequency { get; }
        /// <summary> Usage data reporting frequency in ISO 8601 duration format e.g. PT10M , PT5H. </summary>
        public string DataReportingFrequency { get; }
        /// <summary> Maximum time for which the functionality of the device will not be hampered for not reporting the usage data. </summary>
        public TimeSpan? MaxAllowedUnreportedUsageDuration { get; }
        /// <summary> Details of Event Hub where the usage will be reported. </summary>
        public EdgeUsageDataEventHub EventHubDetails { get; }
    }
}
