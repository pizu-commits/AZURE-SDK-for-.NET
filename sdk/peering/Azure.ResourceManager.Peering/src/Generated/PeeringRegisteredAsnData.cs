// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary> A class representing the PeeringRegisteredAsn data model. </summary>
    public partial class PeeringRegisteredAsnData : ResourceData
    {
        /// <summary> Initializes a new instance of PeeringRegisteredAsnData. </summary>
        public PeeringRegisteredAsnData()
        {
        }

        /// <summary> Initializes a new instance of PeeringRegisteredAsnData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="asn"> The customer&apos;s ASN from which traffic originates. </param>
        /// <param name="peeringServicePrefixKey"> The peering service prefix key that is to be shared with the customer. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal PeeringRegisteredAsnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? asn, string peeringServicePrefixKey, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Asn = asn;
            PeeringServicePrefixKey = peeringServicePrefixKey;
            ProvisioningState = provisioningState;
        }

        /// <summary> The customer&apos;s ASN from which traffic originates. </summary>
        public int? Asn { get; set; }
        /// <summary> The peering service prefix key that is to be shared with the customer. </summary>
        public string PeeringServicePrefixKey { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
