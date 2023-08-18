// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A collection of related endpoints from the same service for which the Batch service requires outbound access. </summary>
    public partial class BatchAccountOutboundEnvironmentEndpoint
    {
        /// <summary> Initializes a new instance of BatchAccountOutboundEnvironmentEndpoint. </summary>
        internal BatchAccountOutboundEnvironmentEndpoint()
        {
            Endpoints = new Core.ChangeTrackingList<BatchAccountEndpointDependency>();
        }

        /// <summary> Initializes a new instance of BatchAccountOutboundEnvironmentEndpoint. </summary>
        /// <param name="category"> The type of service that the Batch service connects to. </param>
        /// <param name="endpoints"> The endpoints for this service to which the Batch service makes outbound calls. </param>
        internal BatchAccountOutboundEnvironmentEndpoint(string category, IReadOnlyList<BatchAccountEndpointDependency> endpoints)
        {
            Category = category;
            Endpoints = endpoints;
        }

        /// <summary> The type of service that the Batch service connects to. </summary>
        public string Category { get; }
        /// <summary> The endpoints for this service to which the Batch service makes outbound calls. </summary>
        public IReadOnlyList<BatchAccountEndpointDependency> Endpoints { get; }
    }
}
