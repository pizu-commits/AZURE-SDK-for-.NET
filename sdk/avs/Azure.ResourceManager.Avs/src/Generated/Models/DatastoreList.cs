// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A paged list of datastores. </summary>
    internal partial class DatastoreList
    {
        /// <summary> Initializes a new instance of DatastoreList. </summary>
        internal DatastoreList()
        {
            Value = new Core.ChangeTrackingList<AvsPrivateCloudDatastoreData>();
        }

        /// <summary> Initializes a new instance of DatastoreList. </summary>
        /// <param name="value"> The items on a page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal DatastoreList(IReadOnlyList<AvsPrivateCloudDatastoreData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on a page. </summary>
        public IReadOnlyList<AvsPrivateCloudDatastoreData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
