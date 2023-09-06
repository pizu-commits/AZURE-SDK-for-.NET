// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The JobRequest. </summary>
    public partial class JobRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="JobRequest"/>. </summary>
        public JobRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JobRequest"/>. </summary>
        /// <param name="jobId"> The unique identifier of the job. </param>
        /// <param name="type"> The job type. </param>
        /// <param name="cloudToDeviceMethod"> The method type and parameters. This is required if the job type is cloudToDeviceMethod. </param>
        /// <param name="updateTwin"> The state information for a device or module. This is implicitly created and deleted when the corresponding device/ module identity is created or deleted in the IoT Hub. </param>
        /// <param name="queryCondition"> The condition for devices to execute the job. This is required if the job type is updateTwin or cloudToDeviceMethod. </param>
        /// <param name="startTime"> The start date and time of the job in ISO 8601 standard. </param>
        /// <param name="maxExecutionTimeInSeconds"> The maximum execution time in secounds. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal JobRequest(string jobId, JobRequestType? type, CloudToDeviceMethodRequest cloudToDeviceMethod, TwinData updateTwin, string queryCondition, DateTimeOffset? startTime, long? maxExecutionTimeInSeconds, Dictionary<string, BinaryData> rawData)
        {
            JobId = jobId;
            Type = type;
            CloudToDeviceMethod = cloudToDeviceMethod;
            UpdateTwin = updateTwin;
            QueryCondition = queryCondition;
            StartTime = startTime;
            MaxExecutionTimeInSeconds = maxExecutionTimeInSeconds;
            _rawData = rawData;
        }

        /// <summary> The unique identifier of the job. </summary>
        public string JobId { get; set; }
        /// <summary> The job type. </summary>
        public JobRequestType? Type { get; set; }
        /// <summary> The method type and parameters. This is required if the job type is cloudToDeviceMethod. </summary>
        public CloudToDeviceMethodRequest CloudToDeviceMethod { get; set; }
        /// <summary> The state information for a device or module. This is implicitly created and deleted when the corresponding device/ module identity is created or deleted in the IoT Hub. </summary>
        public TwinData UpdateTwin { get; set; }
        /// <summary> The condition for devices to execute the job. This is required if the job type is updateTwin or cloudToDeviceMethod. </summary>
        public string QueryCondition { get; set; }
        /// <summary> The start date and time of the job in ISO 8601 standard. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> The maximum execution time in secounds. </summary>
        public long? MaxExecutionTimeInSeconds { get; set; }
    }
}
