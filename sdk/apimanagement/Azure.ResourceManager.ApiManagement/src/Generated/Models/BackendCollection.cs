// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Backend list representation. </summary>
    internal partial class BackendCollection
    {
        /// <summary> Initializes a new instance of BackendCollection. </summary>
        internal BackendCollection()
        {
            Value = new ChangeTrackingList<BackendContractData>();
        }

        /// <summary> Initializes a new instance of BackendCollection. </summary>
        /// <param name="value"> Backend values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal BackendCollection(IReadOnlyList<BackendContractData> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> Backend values. </summary>
        public IReadOnlyList<BackendContractData> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
