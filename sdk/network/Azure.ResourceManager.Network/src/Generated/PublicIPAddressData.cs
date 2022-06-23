// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the PublicIPAddress data model. </summary>
    public partial class PublicIPAddressData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of PublicIPAddressData. </summary>
        public PublicIPAddressData()
        {
            Zones = new ChangeTrackingList<string>();
            IPTags = new ChangeTrackingList<IPTag>();
        }

        /// <summary> Initializes a new instance of PublicIPAddressData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the public ip address. </param>
        /// <param name="sku"> The public IP address SKU. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="publicIPAllocationMethod"> The public IP address allocation method. </param>
        /// <param name="publicIPAddressVersion"> The public IP address version. </param>
        /// <param name="ipConfiguration"> The IP configuration associated with the public IP address. </param>
        /// <param name="dnsSettings"> The FQDN of the DNS record associated with the public IP address. </param>
        /// <param name="ddosSettings"> The DDoS protection custom policy associated with the public IP address. </param>
        /// <param name="ipTags"> The list of tags associated with the public IP address. </param>
        /// <param name="ipAddress"> The IP address associated with the public IP address resource. </param>
        /// <param name="publicIPPrefix"> The Public IP Prefix this Public IP Address should be allocated from. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the public IP address. </param>
        /// <param name="resourceGuid"> The resource GUID property of the public IP address resource. </param>
        /// <param name="provisioningState"> The provisioning state of the public IP address resource. </param>
        /// <param name="servicePublicIPAddress"> The service public IP address of the public IP address resource. </param>
        /// <param name="natGateway"> The NatGateway for the Public IP address. </param>
        /// <param name="migrationPhase"> Migration phase of Public IP Address. </param>
        /// <param name="linkedPublicIPAddress"> The linked public IP address of the public IP address resource. </param>
        /// <param name="deleteOption"> Specify what happens to the public IP address when the VM using it is deleted. </param>
        internal PublicIPAddressData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, Models.ExtendedLocation extendedLocation, PublicIPAddressSku sku, ETag? eTag, IList<string> zones, IPAllocationMethod? publicIPAllocationMethod, IPVersion? publicIPAddressVersion, IPConfiguration ipConfiguration, PublicIPAddressDnsSettings dnsSettings, DdosSettings ddosSettings, IList<IPTag> ipTags, string ipAddress, WritableSubResource publicIPPrefix, int? idleTimeoutInMinutes, Guid? resourceGuid, NetworkProvisioningState? provisioningState, PublicIPAddressData servicePublicIPAddress, NatGatewayData natGateway, PublicIPAddressMigrationPhase? migrationPhase, PublicIPAddressData linkedPublicIPAddress, IPAddressDeleteOption? deleteOption) : base(id, name, resourceType, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Sku = sku;
            ETag = eTag;
            Zones = zones;
            PublicIPAllocationMethod = publicIPAllocationMethod;
            PublicIPAddressVersion = publicIPAddressVersion;
            IPConfiguration = ipConfiguration;
            DnsSettings = dnsSettings;
            DdosSettings = ddosSettings;
            IPTags = ipTags;
            IPAddress = ipAddress;
            PublicIPPrefix = publicIPPrefix;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            ServicePublicIPAddress = servicePublicIPAddress;
            NatGateway = natGateway;
            MigrationPhase = migrationPhase;
            LinkedPublicIPAddress = linkedPublicIPAddress;
            DeleteOption = deleteOption;
        }

        /// <summary> The extended location of the public ip address. </summary>
        public Models.ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The public IP address SKU. </summary>
        public PublicIPAddressSku Sku { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> The public IP address allocation method. </summary>
        public IPAllocationMethod? PublicIPAllocationMethod { get; set; }
        /// <summary> The public IP address version. </summary>
        public IPVersion? PublicIPAddressVersion { get; set; }
        /// <summary> The IP configuration associated with the public IP address. </summary>
        public IPConfiguration IPConfiguration { get; }
        /// <summary> The FQDN of the DNS record associated with the public IP address. </summary>
        public PublicIPAddressDnsSettings DnsSettings { get; set; }
        /// <summary> The DDoS protection custom policy associated with the public IP address. </summary>
        public DdosSettings DdosSettings { get; set; }
        /// <summary> The list of tags associated with the public IP address. </summary>
        public IList<IPTag> IPTags { get; }
        /// <summary> The IP address associated with the public IP address resource. </summary>
        public string IPAddress { get; set; }
        /// <summary> The Public IP Prefix this Public IP Address should be allocated from. </summary>
        internal WritableSubResource PublicIPPrefix { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPPrefixId
        {
            get => PublicIPPrefix is null ? default : PublicIPPrefix.Id;
            set
            {
                if (PublicIPPrefix is null)
                    PublicIPPrefix = new WritableSubResource();
                PublicIPPrefix.Id = value;
            }
        }

        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The resource GUID property of the public IP address resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the public IP address resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The service public IP address of the public IP address resource. </summary>
        public PublicIPAddressData ServicePublicIPAddress { get; set; }
        /// <summary> The NatGateway for the Public IP address. </summary>
        public NatGatewayData NatGateway { get; set; }
        /// <summary> Migration phase of Public IP Address. </summary>
        public PublicIPAddressMigrationPhase? MigrationPhase { get; set; }
        /// <summary> The linked public IP address of the public IP address resource. </summary>
        public PublicIPAddressData LinkedPublicIPAddress { get; set; }
        /// <summary> Specify what happens to the public IP address when the VM using it is deleted. </summary>
        public IPAddressDeleteOption? DeleteOption { get; set; }
    }
}
