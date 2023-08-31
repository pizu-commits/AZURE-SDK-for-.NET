// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> List of subscription Ids in the private store. </summary>
    public partial class SubscriptionsContextList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SubscriptionsContextList"/>. </summary>
        internal SubscriptionsContextList()
        {
            SubscriptionsIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionsContextList"/>. </summary>
        /// <param name="subscriptionsIds"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionsContextList(IReadOnlyList<string> subscriptionsIds, Dictionary<string, BinaryData> rawData)
        {
            SubscriptionsIds = subscriptionsIds;
            _rawData = rawData;
        }

        /// <summary> Gets the subscriptions ids. </summary>
        public IReadOnlyList<string> SubscriptionsIds { get; }
    }
}
