// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The insight chart query. </summary>
    public partial class InsightQueryItemPropertiesDefaultTimeRange
    {
        /// <summary> Initializes a new instance of InsightQueryItemPropertiesDefaultTimeRange. </summary>
        internal InsightQueryItemPropertiesDefaultTimeRange()
        {
        }

        /// <summary> Initializes a new instance of InsightQueryItemPropertiesDefaultTimeRange. </summary>
        /// <param name="beforeRange"> The padding for the start time of the query. </param>
        /// <param name="afterRange"> The padding for the end time of the query. </param>
        internal InsightQueryItemPropertiesDefaultTimeRange(string beforeRange, string afterRange)
        {
            BeforeRange = beforeRange;
            AfterRange = afterRange;
        }

        /// <summary> The padding for the start time of the query. </summary>
        public string BeforeRange { get; }
        /// <summary> The padding for the end time of the query. </summary>
        public string AfterRange { get; }
    }
}
