// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Specifies how tasks should be run in a job associated with a job
    /// schedule.
    /// </summary>
    public partial class JobScheduleExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobScheduleExecutionInformation
        /// class.
        /// </summary>
        public JobScheduleExecutionInformation() { }

        /// <summary>
        /// Initializes a new instance of the JobScheduleExecutionInformation
        /// class.
        /// </summary>
        /// <param name="nextRunTime">The next time at which a job will be created under this schedule.</param>
        /// <param name="recentJob">Information about the most recent job under the job schedule.</param>
        /// <param name="endTime">The time at which the schedule ended.</param>
        public JobScheduleExecutionInformation(DateTime? nextRunTime = default(DateTime?), RecentJob recentJob = default(RecentJob), DateTime? endTime = default(DateTime?))
        {
            NextRunTime = nextRunTime;
            RecentJob = recentJob;
            EndTime = endTime;
        }

        /// <summary>
        /// Gets or sets the next time at which a job will be created under
        /// this schedule.
        /// </summary>
        [JsonProperty(PropertyName = "nextRunTime")]
        public DateTime? NextRunTime { get; set; }

        /// <summary>
        /// Gets or sets information about the most recent job under the job
        /// schedule.
        /// </summary>
        [JsonProperty(PropertyName = "recentJob")]
        public RecentJob RecentJob { get; set; }

        /// <summary>
        /// Gets or sets the time at which the schedule ended.
        /// </summary>
        /// <remarks>
        /// This property is set only if the job schedule is in the completed
        /// state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

    }
}
