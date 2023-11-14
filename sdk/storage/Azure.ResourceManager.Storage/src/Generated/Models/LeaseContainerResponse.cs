// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Lease Container response schema. </summary>
    public partial class LeaseContainerResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LeaseContainerResponse"/>. </summary>
        internal LeaseContainerResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LeaseContainerResponse"/>. </summary>
        /// <param name="leaseId"> Returned unique lease ID that must be included with any request to delete the container, or to renew, change, or release the lease. </param>
        /// <param name="leaseTimeSeconds"> Approximate time remaining in the lease period, in seconds. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LeaseContainerResponse(string leaseId, string leaseTimeSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LeaseId = leaseId;
            LeaseTimeSeconds = leaseTimeSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Returned unique lease ID that must be included with any request to delete the container, or to renew, change, or release the lease. </summary>
        public string LeaseId { get; }
        /// <summary> Approximate time remaining in the lease period, in seconds. </summary>
        public string LeaseTimeSeconds { get; }
    }
}
