// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Endpoints accessed for a common purpose that the App Service Environment requires outbound network access to. </summary>
    public partial class OutboundEnvironmentEndpoint
    {
        /// <summary> Initializes a new instance of OutboundEnvironmentEndpoint. </summary>
        internal OutboundEnvironmentEndpoint()
        {
            Endpoints = new ChangeTrackingList<EndpointDependency>();
        }

        /// <summary> Initializes a new instance of OutboundEnvironmentEndpoint. </summary>
        /// <param name="category"> The type of service accessed by the App Service Environment, e.g., Azure Storage, Azure SQL Database, and Azure Active Directory. </param>
        /// <param name="endpoints"> The endpoints that the App Service Environment reaches the service at. </param>
        internal OutboundEnvironmentEndpoint(string category, IReadOnlyList<EndpointDependency> endpoints)
        {
            Category = category;
            Endpoints = endpoints;
        }

        /// <summary> The type of service accessed by the App Service Environment, e.g., Azure Storage, Azure SQL Database, and Azure Active Directory. </summary>
        public string Category { get; }
        /// <summary> The endpoints that the App Service Environment reaches the service at. </summary>
        public IReadOnlyList<EndpointDependency> Endpoints { get; }
    }
}
