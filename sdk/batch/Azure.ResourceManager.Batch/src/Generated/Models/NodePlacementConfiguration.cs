// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Allocation configuration used by Batch Service to provision the nodes. </summary>
    internal partial class NodePlacementConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NodePlacementConfiguration"/>. </summary>
        public NodePlacementConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NodePlacementConfiguration"/>. </summary>
        /// <param name="policy"> Allocation policy used by Batch Service to provision the nodes. If not specified, Batch will use the regional policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NodePlacementConfiguration(BatchNodePlacementPolicyType? policy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Policy = policy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Allocation policy used by Batch Service to provision the nodes. If not specified, Batch will use the regional policy. </summary>
        public BatchNodePlacementPolicyType? Policy { get; set; }
    }
}
