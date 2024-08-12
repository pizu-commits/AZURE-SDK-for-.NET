// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Spark configuration reference. </summary>
    public partial class SparkConfigurationReference
    {
        /// <summary> Initializes a new instance of <see cref="SparkConfigurationReference"/>. </summary>
        /// <param name="type"> Spark configuration reference type. </param>
        /// <param name="referenceName"> Reference spark configuration name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SparkConfigurationReference(SparkConfigurationReferenceType type, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> Spark configuration reference type. </summary>
        public SparkConfigurationReferenceType Type { get; set; }
        /// <summary> Reference spark configuration name. </summary>
        public string ReferenceName { get; set; }
    }
}
