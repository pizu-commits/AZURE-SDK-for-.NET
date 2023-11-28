// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Description of an additional API Management resource location. </summary>
    public partial class AdditionalLocation
    {
        /// <summary> Initializes a new instance of <see cref="AdditionalLocation"/>. </summary>
        /// <param name="location"> The location name of the additional region among Azure Data center regions. </param>
        /// <param name="sku"> SKU properties of the API Management service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public AdditionalLocation(AzureLocation location, ApiManagementServiceSkuProperties sku)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Location = location;
            Sku = sku;
            Zones = new ChangeTrackingList<string>();
            PublicIPAddresses = new ChangeTrackingList<IPAddress>();
            PrivateIPAddresses = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="AdditionalLocation"/>. </summary>
        /// <param name="location"> The location name of the additional region among Azure Data center regions. </param>
        /// <param name="sku"> SKU properties of the API Management service. </param>
        /// <param name="zones"> A list of availability zones denoting where the resource needs to come from. </param>
        /// <param name="publicIPAddresses"> Public Static Load Balanced IP addresses of the API Management service in the additional location. Available only for Basic, Standard, Premium and Isolated SKU. </param>
        /// <param name="privateIPAddresses"> Private Static Load Balanced IP addresses of the API Management service which is deployed in an Internal Virtual Network in a particular additional location. Available only for Basic, Standard, Premium and Isolated SKU. </param>
        /// <param name="publicIPAddressId"> Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the location. Supported only for Premium SKU being deployed in Virtual Network. </param>
        /// <param name="virtualNetworkConfiguration"> Virtual network configuration for the location. </param>
        /// <param name="gatewayRegionalUri"> Gateway URL of the API Management service in the Region. </param>
        /// <param name="disableGateway"> Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location. </param>
        /// <param name="platformVersion"> Compute Platform Version running the service. </param>
        internal AdditionalLocation(AzureLocation location, ApiManagementServiceSkuProperties sku, IList<string> zones, IReadOnlyList<IPAddress> publicIPAddresses, IReadOnlyList<IPAddress> privateIPAddresses, ResourceIdentifier publicIPAddressId, VirtualNetworkConfiguration virtualNetworkConfiguration, Uri gatewayRegionalUri, bool? disableGateway, PlatformVersion? platformVersion)
        {
            Location = location;
            Sku = sku;
            Zones = zones;
            PublicIPAddresses = publicIPAddresses;
            PrivateIPAddresses = privateIPAddresses;
            PublicIPAddressId = publicIPAddressId;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            GatewayRegionalUri = gatewayRegionalUri;
            DisableGateway = disableGateway;
            PlatformVersion = platformVersion;
        }

        /// <summary> The location name of the additional region among Azure Data center regions. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> SKU properties of the API Management service. </summary>
        public ApiManagementServiceSkuProperties Sku { get; set; }
        /// <summary> A list of availability zones denoting where the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> Public Static Load Balanced IP addresses of the API Management service in the additional location. Available only for Basic, Standard, Premium and Isolated SKU. </summary>
        public IReadOnlyList<IPAddress> PublicIPAddresses { get; }
        /// <summary> Private Static Load Balanced IP addresses of the API Management service which is deployed in an Internal Virtual Network in a particular additional location. Available only for Basic, Standard, Premium and Isolated SKU. </summary>
        public IReadOnlyList<IPAddress> PrivateIPAddresses { get; }
        /// <summary> Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the location. Supported only for Premium SKU being deployed in Virtual Network. </summary>
        public ResourceIdentifier PublicIPAddressId { get; set; }
        /// <summary> Virtual network configuration for the location. </summary>
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }
        /// <summary> Gateway URL of the API Management service in the Region. </summary>
        public Uri GatewayRegionalUri { get; }
        /// <summary> Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location. </summary>
        public bool? DisableGateway { get; set; }
        /// <summary> Compute Platform Version running the service. </summary>
        public PlatformVersion? PlatformVersion { get; }
    }
}
