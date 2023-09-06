// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Base for resource properties. </summary>
    public partial class ResourceProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceProperties"/>. </summary>
        public ResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceProperties(ProvisioningState? provisioningState, ETag? etag, Dictionary<string, BinaryData> rawData)
        {
            ProvisioningState = provisioningState;
            ETag = etag;
            _rawData = rawData;
        }

        /// <summary> Provisioning state of the ManagedNetwork resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
