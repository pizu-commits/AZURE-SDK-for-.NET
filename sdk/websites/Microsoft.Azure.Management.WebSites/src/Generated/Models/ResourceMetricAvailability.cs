// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Metrics availability and retention. </summary>
    public partial class ResourceMetricAvailability
    {
        /// <summary> Initializes a new instance of ResourceMetricAvailability. </summary>
        internal ResourceMetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of ResourceMetricAvailability. </summary>
        /// <param name="timeGrain"> Time grain . </param>
        /// <param name="retention"> Retention period for the current time grain. </param>
        internal ResourceMetricAvailability(string timeGrain, string retention)
        {
            TimeGrain = timeGrain;
            Retention = retention;
        }

        /// <summary> Time grain . </summary>
        public string TimeGrain { get; }
        /// <summary> Retention period for the current time grain. </summary>
        public string Retention { get; }
    }
}
