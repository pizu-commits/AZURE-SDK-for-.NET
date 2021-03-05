// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureTableDataFeed. </summary>
    internal partial class AzureTableDataFeed : DataFeedDetail
    {
        /// <summary> Initializes a new instance of AzureTableDataFeed. </summary>
        /// <param name="dataFeedName"> data feed name. </param>
        /// <param name="granularityName"> granularity of the time series. </param>
        /// <param name="metrics"> measure list. </param>
        /// <param name="dataStartFrom"> ingestion start time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFeedName"/> or <paramref name="metrics"/> is null. </exception>
        public AzureTableDataFeed(string dataFeedName, DataFeedGranularityType granularityName, IEnumerable<DataFeedMetric> metrics, DateTimeOffset dataStartFrom) : base(dataFeedName, granularityName, metrics, dataStartFrom)
        {
            if (dataFeedName == null)
            {
                throw new ArgumentNullException(nameof(dataFeedName));
            }
            if (metrics == null)
            {
                throw new ArgumentNullException(nameof(metrics));
            }

            DataSourceType = DataFeedSourceType.AzureTable;
        }

        /// <summary> Initializes a new instance of AzureTableDataFeed. </summary>
        /// <param name="dataSourceType"> data source type. </param>
        /// <param name="dataFeedId"> data feed unique id. </param>
        /// <param name="dataFeedName"> data feed name. </param>
        /// <param name="dataFeedDescription"> data feed description. </param>
        /// <param name="granularityName"> granularity of the time series. </param>
        /// <param name="granularityAmount"> if granularity is custom,it is required. </param>
        /// <param name="metrics"> measure list. </param>
        /// <param name="dimension"> dimension list. </param>
        /// <param name="timestampColumn"> user-defined timestamp column. if timestampColumn is null, start time of every time slice will be used as default value. </param>
        /// <param name="dataStartFrom"> ingestion start time. </param>
        /// <param name="startOffsetInSeconds"> the time that the beginning of data ingestion task will delay for every data slice according to this offset. </param>
        /// <param name="maxConcurrency"> the max concurrency of data ingestion queries against user data source. 0 means no limitation. </param>
        /// <param name="minRetryIntervalInSeconds"> the min retry interval for failed data ingestion tasks. </param>
        /// <param name="stopRetryAfterInSeconds"> stop retry data ingestion after the data slice first schedule time in seconds. </param>
        /// <param name="needRollup"> mark if the data feed need rollup. </param>
        /// <param name="rollUpMethod"> roll up method. </param>
        /// <param name="rollUpColumns"> roll up columns. </param>
        /// <param name="allUpIdentification"> the identification value for the row of calculated all-up value. </param>
        /// <param name="fillMissingPointType"> the type of fill missing point for anomaly detection. </param>
        /// <param name="fillMissingPointValue"> the value of fill missing point for anomaly detection. </param>
        /// <param name="viewMode"> data feed access mode, default is Private. </param>
        /// <param name="admins"> data feed administrator. </param>
        /// <param name="viewers"> data feed viewer. </param>
        /// <param name="isAdmin"> the query user is one of data feed administrator or not. </param>
        /// <param name="creator"> data feed creator. </param>
        /// <param name="status"> data feed status. </param>
        /// <param name="createdTime"> data feed created time. </param>
        /// <param name="actionLinkTemplate"> action link for alert. </param>
        /// <param name="dataSourceParameter"> . </param>
        internal AzureTableDataFeed(DataFeedSourceType dataSourceType, string dataFeedId, string dataFeedName, string dataFeedDescription, DataFeedGranularityType granularityName, int? granularityAmount, IList<DataFeedMetric> metrics, IList<DataFeedDimension> dimension, string timestampColumn, DateTimeOffset dataStartFrom, long? startOffsetInSeconds, int? maxConcurrency, long? minRetryIntervalInSeconds, long? stopRetryAfterInSeconds, DataFeedRollupType? needRollup, RollUpMethod? rollUpMethod, IList<string> rollUpColumns, string allUpIdentification, DataFeedMissingDataPointFillType? fillMissingPointType, double? fillMissingPointValue, DataFeedAccessMode? viewMode, IList<string> admins, IList<string> viewers, bool? isAdmin, string creator, EntityStatus? status, DateTimeOffset? createdTime, string actionLinkTemplate, AzureTableParameter dataSourceParameter) : base(dataSourceType, dataFeedId, dataFeedName, dataFeedDescription, granularityName, granularityAmount, metrics, dimension, timestampColumn, dataStartFrom, startOffsetInSeconds, maxConcurrency, minRetryIntervalInSeconds, stopRetryAfterInSeconds, needRollup, rollUpMethod, rollUpColumns, allUpIdentification, fillMissingPointType, fillMissingPointValue, viewMode, admins, viewers, isAdmin, creator, status, createdTime, actionLinkTemplate)
        {
            DataSourceParameter = dataSourceParameter;
            DataSourceType = dataSourceType;
        }

        public AzureTableParameter DataSourceParameter { get; set; }
    }
}
