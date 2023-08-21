// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Collection name and related subscriptions list. </summary>
    public partial class CollectionsSubscriptionsMappingDetails
    {
        /// <summary> Initializes a new instance of CollectionsSubscriptionsMappingDetails. </summary>
        internal CollectionsSubscriptionsMappingDetails()
        {
            Subscriptions = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CollectionsSubscriptionsMappingDetails. </summary>
        /// <param name="collectionName"> Collection name. </param>
        /// <param name="subscriptions"> Subscriptions ids list. </param>
        internal CollectionsSubscriptionsMappingDetails(string collectionName, IReadOnlyList<string> subscriptions)
        {
            CollectionName = collectionName;
            Subscriptions = subscriptions;
        }

        /// <summary> Collection name. </summary>
        public string CollectionName { get; }
        /// <summary> Subscriptions ids list. </summary>
        public IReadOnlyList<string> Subscriptions { get; }
    }
}
