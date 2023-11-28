// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters for Create or Update Request for ServiceResource. </summary>
    public partial class CosmosDBServiceCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBServiceCreateOrUpdateContent"/>. </summary>
        public CosmosDBServiceCreateOrUpdateContent()
        {
        }

        /// <summary> Instance type for the service. </summary>
        public CosmosDBServiceSize? InstanceSize { get; set; }
        /// <summary> Instance count for the service. </summary>
        public int? InstanceCount { get; set; }
        /// <summary> ServiceType for the service. </summary>
        public CosmosDBServiceType? ServiceType { get; set; }
    }
}
