// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub
{
    /// <summary> A class representing the IotHubDescription data model. </summary>
    public partial class IotHubDescriptionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IotHubDescriptionData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> IotHub SKU info. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public IotHubDescriptionData(AzureLocation location, IotHubSkuInfo sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
        }

        /// <summary> Initializes a new instance of IotHubDescriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="eTag"> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </param>
        /// <param name="properties"> IotHub properties. </param>
        /// <param name="sku"> IotHub SKU info. </param>
        /// <param name="identity"> The managed identities for the IotHub. </param>
        internal IotHubDescriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? eTag, IotHubProperties properties, IotHubSkuInfo sku, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = eTag;
            Properties = properties;
            Sku = sku;
            Identity = identity;
        }

        /// <summary> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </summary>
        public ETag? ETag { get; set; }
        /// <summary> IotHub properties. </summary>
        public IotHubProperties Properties { get; set; }
        /// <summary> IotHub SKU info. </summary>
        public IotHubSkuInfo Sku { get; set; }
        /// <summary> The managed identities for the IotHub. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
