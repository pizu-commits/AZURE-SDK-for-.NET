// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Build service agent pool size properties. </summary>
    public partial class BuildServiceAgentPoolSizeProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BuildServiceAgentPoolSizeProperties"/>. </summary>
        public BuildServiceAgentPoolSizeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BuildServiceAgentPoolSizeProperties"/>. </summary>
        /// <param name="name"> The name of build service agent pool size. </param>
        /// <param name="cpu"> The cpu property of build service agent pool size. </param>
        /// <param name="memory"> The memory property of build service agent pool size. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildServiceAgentPoolSizeProperties(string name, string cpu, string memory, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Cpu = cpu;
            Memory = memory;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of build service agent pool size. </summary>
        public string Name { get; set; }
        /// <summary> The cpu property of build service agent pool size. </summary>
        public string Cpu { get; }
        /// <summary> The memory property of build service agent pool size. </summary>
        public string Memory { get; }
    }
}
