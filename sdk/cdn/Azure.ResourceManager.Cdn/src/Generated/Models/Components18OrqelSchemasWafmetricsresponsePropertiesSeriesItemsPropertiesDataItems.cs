// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems. </summary>
    public partial class Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems"/>. </summary>
        internal Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems"/>. </summary>
        /// <param name="dateOn"></param>
        /// <param name="value"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(DateTimeOffset? dateOn, float? value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DateOn = dateOn;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the date on. </summary>
        public DateTimeOffset? DateOn { get; }
        /// <summary> Gets the value. </summary>
        public float? Value { get; }
    }
}
