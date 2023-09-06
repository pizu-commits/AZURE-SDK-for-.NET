// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component feature capabilities. </summary>
    public partial class ApplicationInsightsComponentFeatureCapabilities
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFeatureCapabilities"/>. </summary>
        internal ApplicationInsightsComponentFeatureCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFeatureCapabilities"/>. </summary>
        /// <param name="supportExportData"> Whether allow to use continuous export feature. </param>
        /// <param name="burstThrottlePolicy"> Reserved, not used now. </param>
        /// <param name="metadataClass"> Reserved, not used now. </param>
        /// <param name="liveStreamMetrics"> Reserved, not used now. </param>
        /// <param name="applicationMap"> Reserved, not used now. </param>
        /// <param name="workItemIntegration"> Whether allow to use work item integration feature. </param>
        /// <param name="powerBIIntegration"> Reserved, not used now. </param>
        /// <param name="openSchema"> Reserved, not used now. </param>
        /// <param name="proactiveDetection"> Reserved, not used now. </param>
        /// <param name="analyticsIntegration"> Reserved, not used now. </param>
        /// <param name="multipleStepWebTest"> Whether allow to use multiple steps web test feature. </param>
        /// <param name="apiAccessLevel"> Reserved, not used now. </param>
        /// <param name="trackingType"> The application insights component used tracking type. </param>
        /// <param name="dailyCap"> Daily data volume cap in GB. </param>
        /// <param name="dailyCapResetTime"> Daily data volume cap UTC reset hour. </param>
        /// <param name="throttleRate"> Reserved, not used now. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentFeatureCapabilities(bool? supportExportData, string burstThrottlePolicy, string metadataClass, bool? liveStreamMetrics, bool? applicationMap, bool? workItemIntegration, bool? powerBIIntegration, bool? openSchema, bool? proactiveDetection, bool? analyticsIntegration, bool? multipleStepWebTest, string apiAccessLevel, string trackingType, float? dailyCap, float? dailyCapResetTime, float? throttleRate, Dictionary<string, BinaryData> rawData)
        {
            SupportExportData = supportExportData;
            BurstThrottlePolicy = burstThrottlePolicy;
            MetadataClass = metadataClass;
            LiveStreamMetrics = liveStreamMetrics;
            ApplicationMap = applicationMap;
            WorkItemIntegration = workItemIntegration;
            PowerBIIntegration = powerBIIntegration;
            OpenSchema = openSchema;
            ProactiveDetection = proactiveDetection;
            AnalyticsIntegration = analyticsIntegration;
            MultipleStepWebTest = multipleStepWebTest;
            ApiAccessLevel = apiAccessLevel;
            TrackingType = trackingType;
            DailyCap = dailyCap;
            DailyCapResetTime = dailyCapResetTime;
            ThrottleRate = throttleRate;
            _rawData = rawData;
        }

        /// <summary> Whether allow to use continuous export feature. </summary>
        public bool? SupportExportData { get; }
        /// <summary> Reserved, not used now. </summary>
        public string BurstThrottlePolicy { get; }
        /// <summary> Reserved, not used now. </summary>
        public string MetadataClass { get; }
        /// <summary> Reserved, not used now. </summary>
        public bool? LiveStreamMetrics { get; }
        /// <summary> Reserved, not used now. </summary>
        public bool? ApplicationMap { get; }
        /// <summary> Whether allow to use work item integration feature. </summary>
        public bool? WorkItemIntegration { get; }
        /// <summary> Reserved, not used now. </summary>
        public bool? PowerBIIntegration { get; }
        /// <summary> Reserved, not used now. </summary>
        public bool? OpenSchema { get; }
        /// <summary> Reserved, not used now. </summary>
        public bool? ProactiveDetection { get; }
        /// <summary> Reserved, not used now. </summary>
        public bool? AnalyticsIntegration { get; }
        /// <summary> Whether allow to use multiple steps web test feature. </summary>
        public bool? MultipleStepWebTest { get; }
        /// <summary> Reserved, not used now. </summary>
        public string ApiAccessLevel { get; }
        /// <summary> The application insights component used tracking type. </summary>
        public string TrackingType { get; }
        /// <summary> Daily data volume cap in GB. </summary>
        public float? DailyCap { get; }
        /// <summary> Daily data volume cap UTC reset hour. </summary>
        public float? DailyCapResetTime { get; }
        /// <summary> Reserved, not used now. </summary>
        public float? ThrottleRate { get; }
    }
}
