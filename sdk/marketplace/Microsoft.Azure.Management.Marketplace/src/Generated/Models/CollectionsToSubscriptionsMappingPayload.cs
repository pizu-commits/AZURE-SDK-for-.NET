// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The subscriptions list to get the related collections
    /// </summary>
    public partial class CollectionsToSubscriptionsMappingPayload
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CollectionsToSubscriptionsMappingPayload class.
        /// </summary>
        public CollectionsToSubscriptionsMappingPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CollectionsToSubscriptionsMappingPayload class.
        /// </summary>
        /// <param name="properties">Subscriptions ids list</param>
        public CollectionsToSubscriptionsMappingPayload(CollectionsToSubscriptionsMappingProperties properties = default(CollectionsToSubscriptionsMappingProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets subscriptions ids list
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CollectionsToSubscriptionsMappingProperties Properties { get; set; }

    }
}
