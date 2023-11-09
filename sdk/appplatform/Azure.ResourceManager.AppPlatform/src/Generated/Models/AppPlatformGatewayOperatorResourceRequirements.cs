// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Properties of the Spring Cloud Gateway Operator. </summary>
    public partial class AppPlatformGatewayOperatorResourceRequirements
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayOperatorResourceRequirements"/>. </summary>
        internal AppPlatformGatewayOperatorResourceRequirements()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayOperatorResourceRequirements"/>. </summary>
        /// <param name="cpu"> Cpu allocated to each Spring Cloud Gateway Operator instance. </param>
        /// <param name="memory"> Memory allocated to each Spring Cloud Gateway Operator instance. </param>
        /// <param name="instanceCount"> Instance count of the Spring Cloud Gateway Operator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformGatewayOperatorResourceRequirements(string cpu, string memory, int? instanceCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Cpu = cpu;
            Memory = memory;
            InstanceCount = instanceCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Cpu allocated to each Spring Cloud Gateway Operator instance. </summary>
        public string Cpu { get; }
        /// <summary> Memory allocated to each Spring Cloud Gateway Operator instance. </summary>
        public string Memory { get; }
        /// <summary> Instance count of the Spring Cloud Gateway Operator. </summary>
        public int? InstanceCount { get; }
    }
}
