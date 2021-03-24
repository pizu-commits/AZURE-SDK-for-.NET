// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The DetectRequest. </summary>
    public partial class DetectRequest
    {
        /// <summary> Initializes a new instance of DetectRequest. </summary>
        /// <param name="series"> Time series data points. Points should be sorted by timestamp in ascending order to match the anomaly detection result. If the data is not sorted correctly or there is duplicated timestamp, the API will not work. In such case, an error message will be returned. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="series"/> is null. </exception>
        public DetectRequest(IEnumerable<TimeSeriesPoint> series)
        {
            if (series == null)
            {
                throw new ArgumentNullException(nameof(series));
            }

            Series = series.ToList();
        }

        /// <summary> Time series data points. Points should be sorted by timestamp in ascending order to match the anomaly detection result. If the data is not sorted correctly or there is duplicated timestamp, the API will not work. In such case, an error message will be returned. </summary>
        public IList<TimeSeriesPoint> Series { get; }
        /// <summary> Optional argument, can be one of yearly, monthly, weekly, daily, hourly, minutely, secondly, microsecond or none. If granularity is not present, it will be none by default. If granularity is none, the timestamp property in time series point can be absent. </summary>
        public TimeGranularity? Granularity { get; set; }
        /// <summary> Custom Interval is used to set non-standard time interval, for example, if the series is 5 minutes, request can be set as {&quot;granularity&quot;:&quot;minutely&quot;, &quot;customInterval&quot;:5}. </summary>
        public int? CustomInterval { get; set; }
        /// <summary> Optional argument, periodic value of a time series. If the value is null or does not present, the API will determine the period automatically. </summary>
        public int? Period { get; set; }
        /// <summary> Optional argument, advanced model parameter, max anomaly ratio in a time series. </summary>
        public float? MaxAnomalyRatio { get; set; }
        /// <summary> Optional argument, advanced model parameter, between 0-99, the lower the value is, the larger the margin value will be which means less anomalies will be accepted. </summary>
        public int? Sensitivity { get; set; }
    }
}
