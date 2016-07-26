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
    /// Specifies how the Batch service should respond when the task completes.
    /// </summary>
    public partial class ExitConditions
    {
        /// <summary>
        /// Initializes a new instance of the ExitConditions class.
        /// </summary>
        public ExitConditions() { }

        /// <summary>
        /// Initializes a new instance of the ExitConditions class.
        /// </summary>
        public ExitConditions(IList<ExitCodeMapping> exitCodes = default(IList<ExitCodeMapping>), IList<ExitCodeRangeMapping> exitCodeRanges = default(IList<ExitCodeRangeMapping>), ExitOptions schedulingError = default(ExitOptions), ExitOptions defaultProperty = default(ExitOptions))
        {
            ExitCodes = exitCodes;
            ExitCodeRanges = exitCodeRanges;
            SchedulingError = schedulingError;
            DefaultProperty = defaultProperty;
        }

        /// <summary>
        /// Gets or sets a list of individual task exit codes and how the
        /// Batch service should respond to them.
        /// </summary>
        [JsonProperty(PropertyName = "exitCodes")]
        public IList<ExitCodeMapping> ExitCodes { get; set; }

        /// <summary>
        /// Gets or sets a list of task exit code ranges and how the Batch
        /// service should respond to them.
        /// </summary>
        [JsonProperty(PropertyName = "exitCodeRanges")]
        public IList<ExitCodeRangeMapping> ExitCodeRanges { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task
        /// fails with a scheduling error.
        /// </summary>
        [JsonProperty(PropertyName = "schedulingError")]
        public ExitOptions SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task
        /// fails with an exit condition not covered by any of the other
        /// properties - that is, any nonzero exit code not listed in the
        /// exitCodes or exitCodeRanges collection, or a scheduling error if
        /// the schedulingError property is not present.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public ExitOptions DefaultProperty { get; set; }

    }
}
