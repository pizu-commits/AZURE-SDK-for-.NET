// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RankingsResponseTablesPropertiesItemsMetricsItem. </summary>
    public partial class RankingsResponseTablesPropertiesItemsMetricsItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RankingsResponseTablesPropertiesItemsMetricsItem"/>. </summary>
        internal RankingsResponseTablesPropertiesItemsMetricsItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RankingsResponseTablesPropertiesItemsMetricsItem"/>. </summary>
        /// <param name="metric"></param>
        /// <param name="value"></param>
        /// <param name="percentage"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RankingsResponseTablesPropertiesItemsMetricsItem(string metric, long? value, float? percentage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metric = metric;
            Value = value;
            Percentage = percentage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the metric. </summary>
        public string Metric { get; }
        /// <summary> Gets the value. </summary>
        public long? Value { get; }
        /// <summary> Gets the percentage. </summary>
        public float? Percentage { get; }
    }
}
