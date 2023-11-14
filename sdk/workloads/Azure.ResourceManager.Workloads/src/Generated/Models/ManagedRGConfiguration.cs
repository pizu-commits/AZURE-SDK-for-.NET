// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Managed resource group configuration. </summary>
    internal partial class ManagedRGConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRGConfiguration"/>. </summary>
        public ManagedRGConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRGConfiguration"/>. </summary>
        /// <param name="name"> Managed resource group name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRGConfiguration(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Managed resource group name. </summary>
        public string Name { get; set; }
    }
}
