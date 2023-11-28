// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The request for a QueryInboundNatRulePortMapping API. Either IpConfiguration or IpAddress should be set. </summary>
    public partial class QueryInboundNatRulePortMappingContent
    {
        /// <summary> Initializes a new instance of <see cref="QueryInboundNatRulePortMappingContent"/>. </summary>
        public QueryInboundNatRulePortMappingContent()
        {
        }

        /// <summary> NetworkInterfaceIPConfiguration set in load balancer backend address. </summary>
        internal WritableSubResource IPConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier IPConfigurationId
        {
            get => IPConfiguration is null ? default : IPConfiguration.Id;
            set
            {
                if (IPConfiguration is null)
                    IPConfiguration = new WritableSubResource();
                IPConfiguration.Id = value;
            }
        }

        /// <summary> IP address set in load balancer backend address. </summary>
        public string IPAddress { get; set; }
    }
}
