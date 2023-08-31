// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridConnectivity.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary>
    /// A class representing the EndpointResource data model.
    /// The endpoint for the target resource.
    /// </summary>
    public partial class EndpointResourceData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EndpointResourceData"/>. </summary>
        public EndpointResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EndpointResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="endpointType"> The type of endpoint. </param>
        /// <param name="resourceId"> The resource Id of the connectivity endpoint (optional). </param>
        /// <param name="provisioningState"></param>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="createdByType"> The type of identity that created the resource. </param>
        /// <param name="createdOn"> The timestamp of resource creation (UTC). </param>
        /// <param name="lastModifiedBy"> The identity that last modified the resource. </param>
        /// <param name="lastModifiedByType"> The type of identity that last modified the resource. </param>
        /// <param name="lastModifiedOn"> The timestamp of resource last modification (UTC). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EndpointType? endpointType, string resourceId, string provisioningState, string createdBy, Models.CreatedByType? createdByType, DateTimeOffset? createdOn, string lastModifiedBy, Models.CreatedByType? lastModifiedByType, DateTimeOffset? lastModifiedOn, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            EndpointType = endpointType;
            ResourceId = resourceId;
            ProvisioningState = provisioningState;
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            CreatedOn = createdOn;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            LastModifiedOn = lastModifiedOn;
            _rawData = rawData;
        }

        /// <summary> The type of endpoint. </summary>
        public EndpointType? EndpointType { get; set; }
        /// <summary> The resource Id of the connectivity endpoint (optional). </summary>
        public string ResourceId { get; set; }
        /// <summary> Gets the provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The identity that created the resource. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The type of identity that created the resource. </summary>
        public Models.CreatedByType? CreatedByType { get; set; }
        /// <summary> The timestamp of resource creation (UTC). </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The identity that last modified the resource. </summary>
        public string LastModifiedBy { get; set; }
        /// <summary> The type of identity that last modified the resource. </summary>
        public Models.CreatedByType? LastModifiedByType { get; set; }
        /// <summary> The timestamp of resource last modification (UTC). </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
    }
}
