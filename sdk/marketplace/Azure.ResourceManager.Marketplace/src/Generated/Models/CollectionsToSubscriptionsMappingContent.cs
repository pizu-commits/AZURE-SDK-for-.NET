// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The subscriptions list to get the related collections. </summary>
    public partial class CollectionsToSubscriptionsMappingContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CollectionsToSubscriptionsMappingContent"/>. </summary>
        public CollectionsToSubscriptionsMappingContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CollectionsToSubscriptionsMappingContent"/>. </summary>
        /// <param name="properties"> Subscriptions ids list. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CollectionsToSubscriptionsMappingContent(CollectionsToSubscriptionsMappingProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Subscriptions ids list. </summary>
        internal CollectionsToSubscriptionsMappingProperties Properties { get; set; }
        /// <summary> Subscriptions ids list. </summary>
        public IList<string> CollectionsToSubscriptionsMappingSubscriptionIds
        {
            get
            {
                if (Properties is null)
                    Properties = new CollectionsToSubscriptionsMappingProperties();
                return Properties.SubscriptionIds;
            }
        }
    }
}
