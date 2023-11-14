// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ContainerCpuStatistics. </summary>
    public partial class ContainerCpuStatistics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerCpuStatistics"/>. </summary>
        public ContainerCpuStatistics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerCpuStatistics"/>. </summary>
        /// <param name="cpuUsage"></param>
        /// <param name="systemCpuUsage"></param>
        /// <param name="onlineCpuCount"></param>
        /// <param name="throttlingData"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerCpuStatistics(ContainerCpuUsage cpuUsage, long? systemCpuUsage, int? onlineCpuCount, ContainerThrottlingInfo throttlingData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CpuUsage = cpuUsage;
            SystemCpuUsage = systemCpuUsage;
            OnlineCpuCount = onlineCpuCount;
            ThrottlingData = throttlingData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the cpu usage. </summary>
        public ContainerCpuUsage CpuUsage { get; set; }
        /// <summary> Gets or sets the system cpu usage. </summary>
        public long? SystemCpuUsage { get; set; }
        /// <summary> Gets or sets the online cpu count. </summary>
        public int? OnlineCpuCount { get; set; }
        /// <summary> Gets or sets the throttling data. </summary>
        public ContainerThrottlingInfo ThrottlingData { get; set; }
    }
}
