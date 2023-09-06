// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> TensorFlow distribution configuration. </summary>
    public partial class TensorFlowDistributionConfiguration : MachineLearningDistributionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="TensorFlowDistributionConfiguration"/>. </summary>
        public TensorFlowDistributionConfiguration()
        {
            DistributionType = DistributionType.TensorFlow;
        }

        /// <summary> Initializes a new instance of <see cref="TensorFlowDistributionConfiguration"/>. </summary>
        /// <param name="distributionType"> [Required] Specifies the type of distribution framework. </param>
        /// <param name="parameterServerCount"> Number of parameter server tasks. </param>
        /// <param name="workerCount"> Number of workers. If not specified, will default to the instance count. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TensorFlowDistributionConfiguration(DistributionType distributionType, int? parameterServerCount, int? workerCount, Dictionary<string, BinaryData> rawData) : base(distributionType, rawData)
        {
            ParameterServerCount = parameterServerCount;
            WorkerCount = workerCount;
            DistributionType = distributionType;
        }

        /// <summary> Number of parameter server tasks. </summary>
        public int? ParameterServerCount { get; set; }
        /// <summary> Number of workers. If not specified, will default to the instance count. </summary>
        public int? WorkerCount { get; set; }
    }
}
