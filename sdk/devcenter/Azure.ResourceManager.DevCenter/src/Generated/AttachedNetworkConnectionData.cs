// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary> A class representing the AttachedNetworkConnection data model. </summary>
    public partial class AttachedNetworkConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of AttachedNetworkConnectionData. </summary>
        public AttachedNetworkConnectionData()
        {
        }

        /// <summary> Initializes a new instance of AttachedNetworkConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="networkConnectionId"> The resource ID of the NetworkConnection you want to attach. </param>
        /// <param name="networkConnectionLocation"> The geo-location where the NetworkConnection resource specified in &apos;networkConnectionResourceId&apos; property lives. </param>
        /// <param name="healthCheckStatus"> Health check status values. </param>
        /// <param name="domainJoinType"> AAD Join type of the network. This is populated based on the referenced Network Connection. </param>
        internal AttachedNetworkConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provisioningState, string networkConnectionId, string networkConnectionLocation, HealthCheckStatus? healthCheckStatus, DomainJoinType? domainJoinType) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            NetworkConnectionId = networkConnectionId;
            NetworkConnectionLocation = networkConnectionLocation;
            HealthCheckStatus = healthCheckStatus;
            DomainJoinType = domainJoinType;
        }

        /// <summary> The provisioning state of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The resource ID of the NetworkConnection you want to attach. </summary>
        public string NetworkConnectionId { get; set; }
        /// <summary> The geo-location where the NetworkConnection resource specified in &apos;networkConnectionResourceId&apos; property lives. </summary>
        public string NetworkConnectionLocation { get; }
        /// <summary> Health check status values. </summary>
        public HealthCheckStatus? HealthCheckStatus { get; }
        /// <summary> AAD Join type of the network. This is populated based on the referenced Network Connection. </summary>
        public DomainJoinType? DomainJoinType { get; }
    }
}
