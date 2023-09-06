// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> A domain name that a service is reached at. </summary>
    public partial class EndpointDependency
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EndpointDependency"/>. </summary>
        internal EndpointDependency()
        {
            EndpointDetails = new ChangeTrackingList<EndpointDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="EndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The Ports used when connecting to DomainName. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointDependency(string domainName, IReadOnlyList<EndpointDetail> endpointDetails, Dictionary<string, BinaryData> rawData)
        {
            DomainName = domainName;
            EndpointDetails = endpointDetails;
            _rawData = rawData;
        }

        /// <summary> The domain name of the dependency. </summary>
        public string DomainName { get; }
        /// <summary> The Ports used when connecting to DomainName. </summary>
        public IReadOnlyList<EndpointDetail> EndpointDetails { get; }
    }
}
