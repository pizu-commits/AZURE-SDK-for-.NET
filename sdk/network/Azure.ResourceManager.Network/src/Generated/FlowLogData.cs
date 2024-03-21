// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the FlowLog data model.
    /// A flow log resource.
    /// </summary>
    public partial class FlowLogData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="FlowLogData"/>. </summary>
        public FlowLogData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FlowLogData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="targetResourceId"> ID of network security group to which flow log will be applied. </param>
        /// <param name="targetResourceGuid"> Guid of network security group to which flow log will be applied. </param>
        /// <param name="storageId"> ID of the storage account which is used to store the flow log. </param>
        /// <param name="enabled"> Flag to enable/disable flow logging. </param>
        /// <param name="retentionPolicy"> Parameters that define the retention policy for flow log. </param>
        /// <param name="format"> Parameters that define the flow log format. </param>
        /// <param name="flowAnalyticsConfiguration"> Parameters that define the configuration of traffic analytics. </param>
        /// <param name="provisioningState"> The provisioning state of the flow log. </param>
        internal FlowLogData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, ResourceIdentifier targetResourceId, Guid? targetResourceGuid, ResourceIdentifier storageId, bool? enabled, RetentionPolicyParameters retentionPolicy, FlowLogProperties format, TrafficAnalyticsProperties flowAnalyticsConfiguration, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            TargetResourceId = targetResourceId;
            TargetResourceGuid = targetResourceGuid;
            StorageId = storageId;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            Format = format;
            FlowAnalyticsConfiguration = flowAnalyticsConfiguration;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> ID of network security group to which flow log will be applied. </summary>
        public ResourceIdentifier TargetResourceId { get; set; }
        /// <summary> Guid of network security group to which flow log will be applied. </summary>
        public Guid? TargetResourceGuid { get; }
        /// <summary> ID of the storage account which is used to store the flow log. </summary>
        public ResourceIdentifier StorageId { get; set; }
        /// <summary> Flag to enable/disable flow logging. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Parameters that define the retention policy for flow log. </summary>
        public RetentionPolicyParameters RetentionPolicy { get; set; }
        /// <summary> Parameters that define the flow log format. </summary>
        public FlowLogProperties Format { get; set; }
        /// <summary> Parameters that define the configuration of traffic analytics. </summary>
        internal TrafficAnalyticsProperties FlowAnalyticsConfiguration { get; set; }
        /// <summary> Parameters that define the configuration of traffic analytics. </summary>
        public TrafficAnalyticsConfigurationProperties TrafficAnalyticsConfiguration
        {
            get => FlowAnalyticsConfiguration is null ? default : FlowAnalyticsConfiguration.TrafficAnalyticsConfiguration;
            set
            {
                if (FlowAnalyticsConfiguration is null)
                    FlowAnalyticsConfiguration = new TrafficAnalyticsProperties();
                FlowAnalyticsConfiguration.TrafficAnalyticsConfiguration = value;
            }
        }

        /// <summary> The provisioning state of the flow log. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
