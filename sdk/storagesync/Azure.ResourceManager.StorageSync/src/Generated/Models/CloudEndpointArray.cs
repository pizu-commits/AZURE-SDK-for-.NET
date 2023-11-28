// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Array of CloudEndpoint. </summary>
    internal partial class CloudEndpointArray
    {
        /// <summary> Initializes a new instance of <see cref="CloudEndpointArray"/>. </summary>
        internal CloudEndpointArray()
        {
            Value = new ChangeTrackingList<CloudEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudEndpointArray"/>. </summary>
        /// <param name="value"> Collection of CloudEndpoint. </param>
        internal CloudEndpointArray(IReadOnlyList<CloudEndpointData> value)
        {
            Value = value;
        }

        /// <summary> Collection of CloudEndpoint. </summary>
        public IReadOnlyList<CloudEndpointData> Value { get; }
    }
}
