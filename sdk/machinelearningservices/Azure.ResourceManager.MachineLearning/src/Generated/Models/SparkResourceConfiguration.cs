// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The SparkResourceConfiguration. </summary>
    public partial class SparkResourceConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SparkResourceConfiguration"/>. </summary>
        public SparkResourceConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SparkResourceConfiguration"/>. </summary>
        /// <param name="instanceType"> Optional type of VM used as supported by the compute target. </param>
        /// <param name="runtimeVersion"> Version of spark runtime used for the job. </param>
        internal SparkResourceConfiguration(string instanceType, string runtimeVersion)
        {
            InstanceType = instanceType;
            RuntimeVersion = runtimeVersion;
        }

        /// <summary> Optional type of VM used as supported by the compute target. </summary>
        public string InstanceType { get; set; }
        /// <summary> Version of spark runtime used for the job. </summary>
        public string RuntimeVersion { get; set; }
    }
}
