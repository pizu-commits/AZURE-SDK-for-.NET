// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Runtime properties of this Capability Type. </summary>
    internal partial class CapabilityTypePropertiesRuntimeProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CapabilityTypePropertiesRuntimeProperties"/>. </summary>
        public CapabilityTypePropertiesRuntimeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CapabilityTypePropertiesRuntimeProperties"/>. </summary>
        /// <param name="kind"> String of the kind of the resource's action type (continuous or discrete). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CapabilityTypePropertiesRuntimeProperties(string kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> String of the kind of the resource's action type (continuous or discrete). </summary>
        public string Kind { get; }
    }
}
