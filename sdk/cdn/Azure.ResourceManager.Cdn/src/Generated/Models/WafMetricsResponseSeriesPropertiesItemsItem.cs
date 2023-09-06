// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The WafMetricsResponseSeriesPropertiesItemsItem. </summary>
    public partial class WafMetricsResponseSeriesPropertiesItemsItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WafMetricsResponseSeriesPropertiesItemsItem"/>. </summary>
        internal WafMetricsResponseSeriesPropertiesItemsItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WafMetricsResponseSeriesPropertiesItemsItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WafMetricsResponseSeriesPropertiesItemsItem(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
    }
}
