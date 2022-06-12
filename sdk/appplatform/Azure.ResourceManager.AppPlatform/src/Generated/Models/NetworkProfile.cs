// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Service network profile payload. </summary>
    public partial class NetworkProfile
    {
        /// <summary> Initializes a new instance of NetworkProfile. </summary>
        public NetworkProfile()
        {
            RequiredTraffics = new ChangeTrackingList<RequiredTraffic>();
        }

        /// <summary> Initializes a new instance of NetworkProfile. </summary>
        /// <param name="serviceRuntimeSubnetId"> Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime. </param>
        /// <param name="appSubnetId"> Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps. </param>
        /// <param name="serviceCidr"> Azure Spring Cloud service reserved CIDR. </param>
        /// <param name="serviceRuntimeNetworkResourceGroup"> Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. </param>
        /// <param name="appNetworkResourceGroup"> Name of the resource group containing network resources of Azure Spring Cloud Apps. </param>
        /// <param name="outboundIPs"> Desired outbound IP resources for Azure Spring Cloud instance. </param>
        /// <param name="requiredTraffics"> Required inbound or outbound traffics for Azure Spring Cloud instance. </param>
        internal NetworkProfile(ResourceIdentifier serviceRuntimeSubnetId, ResourceIdentifier appSubnetId, string serviceCidr, string serviceRuntimeNetworkResourceGroup, string appNetworkResourceGroup, NetworkProfileOutboundIPs outboundIPs, IReadOnlyList<RequiredTraffic> requiredTraffics)
        {
            ServiceRuntimeSubnetId = serviceRuntimeSubnetId;
            AppSubnetId = appSubnetId;
            ServiceCidr = serviceCidr;
            ServiceRuntimeNetworkResourceGroup = serviceRuntimeNetworkResourceGroup;
            AppNetworkResourceGroup = appNetworkResourceGroup;
            OutboundIPs = outboundIPs;
            RequiredTraffics = requiredTraffics;
        }

        /// <summary> Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime. </summary>
        public ResourceIdentifier ServiceRuntimeSubnetId { get; set; }
        /// <summary> Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps. </summary>
        public ResourceIdentifier AppSubnetId { get; set; }
        /// <summary> Azure Spring Cloud service reserved CIDR. </summary>
        public string ServiceCidr { get; set; }
        /// <summary> Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. </summary>
        public string ServiceRuntimeNetworkResourceGroup { get; set; }
        /// <summary> Name of the resource group containing network resources of Azure Spring Cloud Apps. </summary>
        public string AppNetworkResourceGroup { get; set; }
        /// <summary> Desired outbound IP resources for Azure Spring Cloud instance. </summary>
        internal NetworkProfileOutboundIPs OutboundIPs { get; }
        /// <summary> A list of public IP addresses. </summary>
        public IReadOnlyList<string> OutboundPublicIPs
        {
            get => OutboundIPs?.PublicIPs;
        }

        /// <summary> Required inbound or outbound traffics for Azure Spring Cloud instance. </summary>
        public IReadOnlyList<RequiredTraffic> RequiredTraffics { get; }
    }
}
