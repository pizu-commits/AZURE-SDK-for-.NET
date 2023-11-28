// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains custom Dns resolution configuration from customer. </summary>
    public partial class CustomDnsConfigProperties
    {
        /// <summary> Initializes a new instance of <see cref="CustomDnsConfigProperties"/>. </summary>
        public CustomDnsConfigProperties()
        {
            IPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomDnsConfigProperties"/>. </summary>
        /// <param name="fqdn"> Fqdn that resolves to private endpoint ip address. </param>
        /// <param name="ipAddresses"> A list of private ip addresses of the private endpoint. </param>
        internal CustomDnsConfigProperties(string fqdn, IList<string> ipAddresses)
        {
            Fqdn = fqdn;
            IPAddresses = ipAddresses;
        }

        /// <summary> Fqdn that resolves to private endpoint ip address. </summary>
        public string Fqdn { get; set; }
        /// <summary> A list of private ip addresses of the private endpoint. </summary>
        public IList<string> IPAddresses { get; }
    }
}
