// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the VnetInfoResource data model. </summary>
    public partial class VnetInfoResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of VnetInfoResourceData. </summary>
        public VnetInfoResourceData()
        {
            Routes = new ChangeTrackingList<VnetRoute>();
        }

        /// <summary> Initializes a new instance of VnetInfoResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetResourceId"> The Virtual Network&apos;s resource ID. </param>
        /// <param name="certThumbprint"> The client certificate thumbprint. </param>
        /// <param name="certBlob">
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
        /// Point-To-Site VPN connection.
        /// </param>
        /// <param name="routes"> The routes that this Virtual Network connection uses. </param>
        /// <param name="resyncRequired"> &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="dnsServers"> DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses. </param>
        /// <param name="isSwift"> Flag that is used to denote if this is VNET injection. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal VnetInfoResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier vnetResourceId, string certThumbprint, string certBlob, IReadOnlyList<VnetRoute> routes, bool? resyncRequired, string dnsServers, bool? isSwift, string kind) : base(id, name, resourceType, systemData)
        {
            VnetResourceId = vnetResourceId;
            CertThumbprint = certThumbprint;
            CertBlob = certBlob;
            Routes = routes;
            ResyncRequired = resyncRequired;
            DnsServers = dnsServers;
            IsSwift = isSwift;
            Kind = kind;
        }

        /// <summary> The Virtual Network&apos;s resource ID. </summary>
        public ResourceIdentifier VnetResourceId { get; set; }
        /// <summary> The client certificate thumbprint. </summary>
        public string CertThumbprint { get; }
        /// <summary>
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
        /// Point-To-Site VPN connection.
        /// </summary>
        public string CertBlob { get; set; }
        /// <summary> The routes that this Virtual Network connection uses. </summary>
        public IReadOnlyList<VnetRoute> Routes { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? ResyncRequired { get; }
        /// <summary> DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses. </summary>
        public string DnsServers { get; set; }
        /// <summary> Flag that is used to denote if this is VNET injection. </summary>
        public bool? IsSwift { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
