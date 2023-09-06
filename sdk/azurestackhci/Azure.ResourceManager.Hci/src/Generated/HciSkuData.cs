// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the HciSku data model.
    /// Sku details.
    /// </summary>
    public partial class HciSkuData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HciSkuData"/>. </summary>
        public HciSkuData()
        {
            SkuMappings = new ChangeTrackingList<HciSkuMappings>();
        }

        /// <summary> Initializes a new instance of <see cref="HciSkuData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning State. </param>
        /// <param name="publisherId"> Identifier of the Publisher for the offer. </param>
        /// <param name="offerId"> Identifier of the Offer for the sku. </param>
        /// <param name="content"> JSON serialized catalog content of the sku offer. </param>
        /// <param name="contentVersion"> The API version of the catalog service used to serve the catalog content. </param>
        /// <param name="skuMappings"> Array of SKU mappings. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HciSkuData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provisioningState, string publisherId, string offerId, string content, string contentVersion, IList<HciSkuMappings> skuMappings, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PublisherId = publisherId;
            OfferId = offerId;
            Content = content;
            ContentVersion = contentVersion;
            SkuMappings = skuMappings;
            _rawData = rawData;
        }

        /// <summary> Provisioning State. </summary>
        public string ProvisioningState { get; }
        /// <summary> Identifier of the Publisher for the offer. </summary>
        public string PublisherId { get; set; }
        /// <summary> Identifier of the Offer for the sku. </summary>
        public string OfferId { get; set; }
        /// <summary> JSON serialized catalog content of the sku offer. </summary>
        public string Content { get; set; }
        /// <summary> The API version of the catalog service used to serve the catalog content. </summary>
        public string ContentVersion { get; set; }
        /// <summary> Array of SKU mappings. </summary>
        public IList<HciSkuMappings> SkuMappings { get; }
    }
}
