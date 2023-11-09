// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> The StorageQoSPolicyDetails definition. </summary>
    public partial class StorageQoSPolicyDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageQoSPolicyDetails"/>. </summary>
        public StorageQoSPolicyDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageQoSPolicyDetails"/>. </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="id"> The ID of the QoS policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageQoSPolicyDetails(string name, string id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the policy. </summary>
        public string Name { get; set; }
        /// <summary> The ID of the QoS policy. </summary>
        public string Id { get; set; }
    }
}
