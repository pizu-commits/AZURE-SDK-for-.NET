// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RankingsResponseTablesPropertiesItemsItem. </summary>
    public partial class RankingsResponseTablesPropertiesItemsItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RankingsResponseTablesPropertiesItemsItem"/>. </summary>
        internal RankingsResponseTablesPropertiesItemsItem()
        {
            Metrics = new ChangeTrackingList<RankingsResponseTablesPropertiesItemsMetricsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="RankingsResponseTablesPropertiesItemsItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="metrics"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RankingsResponseTablesPropertiesItemsItem(string name, IReadOnlyList<RankingsResponseTablesPropertiesItemsMetricsItem> metrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Metrics = metrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the metrics. </summary>
        public IReadOnlyList<RankingsResponseTablesPropertiesItemsMetricsItem> Metrics { get; }
    }
}
