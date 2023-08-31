// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Collection name and id. </summary>
    public partial class PrivateStoreCollectionDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateStoreCollectionDetails"/>. </summary>
        internal PrivateStoreCollectionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateStoreCollectionDetails"/>. </summary>
        /// <param name="collectionName"> Collection name. </param>
        /// <param name="collectionId"> Collection id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateStoreCollectionDetails(string collectionName, Guid? collectionId, Dictionary<string, BinaryData> rawData)
        {
            CollectionName = collectionName;
            CollectionId = collectionId;
            _rawData = rawData;
        }

        /// <summary> Collection name. </summary>
        public string CollectionName { get; }
        /// <summary> Collection id. </summary>
        public Guid? CollectionId { get; }
    }
}
