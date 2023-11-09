// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Resource request payload of Build Resource. </summary>
    public partial class AppPlatformBuildResourceRequirements
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildResourceRequirements"/>. </summary>
        public AppPlatformBuildResourceRequirements()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildResourceRequirements"/>. </summary>
        /// <param name="cpu">
        /// Optional Cpu allocated to the build resource. 1 core can be represented by 1 or 1000m.
        /// The default value is 1, this should not exceed build service agent pool cpu size.
        /// </param>
        /// <param name="memory">
        /// Optional Memory allocated to the build resource. 1 GB can be represented by 1Gi or 1024Mi.
        /// The default value is 2Gi, this should not exceed build service agent pool memory size.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformBuildResourceRequirements(string cpu, string memory, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Cpu = cpu;
            Memory = memory;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Optional Cpu allocated to the build resource. 1 core can be represented by 1 or 1000m.
        /// The default value is 1, this should not exceed build service agent pool cpu size.
        /// </summary>
        public string Cpu { get; set; }
        /// <summary>
        /// Optional Memory allocated to the build resource. 1 GB can be represented by 1Gi or 1024Mi.
        /// The default value is 2Gi, this should not exceed build service agent pool memory size.
        /// </summary>
        public string Memory { get; set; }
    }
}
