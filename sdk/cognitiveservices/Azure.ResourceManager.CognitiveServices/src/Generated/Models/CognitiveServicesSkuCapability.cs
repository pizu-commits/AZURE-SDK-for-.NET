// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> SkuCapability indicates the capability of a certain feature. </summary>
    public partial class CognitiveServicesSkuCapability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesSkuCapability"/>. </summary>
        internal CognitiveServicesSkuCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesSkuCapability"/>. </summary>
        /// <param name="name"> The name of the SkuCapability. </param>
        /// <param name="value"> The value of the SkuCapability. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesSkuCapability(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The name of the SkuCapability. </summary>
        public string Name { get; }
        /// <summary> The value of the SkuCapability. </summary>
        public string Value { get; }
    }
}
