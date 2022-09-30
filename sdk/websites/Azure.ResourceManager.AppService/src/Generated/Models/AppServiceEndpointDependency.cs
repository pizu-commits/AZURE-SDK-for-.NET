// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A domain name that a service is reached at, including details of the current connection status. </summary>
    public partial class AppServiceEndpointDependency
    {
        /// <summary> Initializes a new instance of AppServiceEndpointDependency. </summary>
        internal AppServiceEndpointDependency()
        {
            EndpointDetails = new ChangeTrackingList<AppServiceEndpointDetail>();
        }

        /// <summary> Initializes a new instance of AppServiceEndpointDependency. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The IP Addresses and Ports used when connecting to DomainName. </param>
        internal AppServiceEndpointDependency(string domainName, IReadOnlyList<AppServiceEndpointDetail> endpointDetails)
        {
            DomainName = domainName;
            EndpointDetails = endpointDetails;
        }

        /// <summary> The domain name of the dependency. </summary>
        public string DomainName { get; }
        /// <summary> The IP Addresses and Ports used when connecting to DomainName. </summary>
        public IReadOnlyList<AppServiceEndpointDetail> EndpointDetails { get; }
    }
}
