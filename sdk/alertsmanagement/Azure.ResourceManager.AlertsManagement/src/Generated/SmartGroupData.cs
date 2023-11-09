// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary>
    /// A class representing the SmartGroup data model.
    /// Set of related alerts grouped together smartly by AMS.
    /// </summary>
    public partial class SmartGroupData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SmartGroupData"/>. </summary>
        public SmartGroupData()
        {
            Resources = new ChangeTrackingList<SmartGroupAggregatedProperty>();
            ResourceTypes = new ChangeTrackingList<SmartGroupAggregatedProperty>();
            ResourceGroups = new ChangeTrackingList<SmartGroupAggregatedProperty>();
            MonitorServices = new ChangeTrackingList<SmartGroupAggregatedProperty>();
            MonitorConditions = new ChangeTrackingList<SmartGroupAggregatedProperty>();
            AlertStates = new ChangeTrackingList<SmartGroupAggregatedProperty>();
            AlertSeverities = new ChangeTrackingList<SmartGroupAggregatedProperty>();
        }

        /// <summary> Initializes a new instance of <see cref="SmartGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="alertsCount"> Total number of alerts in smart group. </param>
        /// <param name="smartGroupState"> Smart group state. </param>
        /// <param name="severity"> Severity of smart group is the highest(Sev0 &gt;... &gt; Sev4) severity of all the alerts in the group. </param>
        /// <param name="startOn"> Creation time of smart group. Date-Time in ISO-8601 format. </param>
        /// <param name="lastModifiedOn"> Last updated time of smart group. Date-Time in ISO-8601 format. </param>
        /// <param name="lastModifiedBy"> Last modified by user name. </param>
        /// <param name="resources"> Summary of target resources in the smart group. </param>
        /// <param name="resourceTypes"> Summary of target resource types in the smart group. </param>
        /// <param name="resourceGroups"> Summary of target resource groups in the smart group. </param>
        /// <param name="monitorServices"> Summary of monitorServices in the smart group. </param>
        /// <param name="monitorConditions"> Summary of monitorConditions in the smart group. </param>
        /// <param name="alertStates"> Summary of alertStates in the smart group. </param>
        /// <param name="alertSeverities"> Summary of alertSeverities in the smart group. </param>
        /// <param name="nextLink"> The URI to fetch the next page of alerts. Call ListNext() with this URI to fetch the next page alerts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SmartGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, long? alertsCount, SmartGroupState? smartGroupState, ServiceAlertSeverity? severity, DateTimeOffset? startOn, DateTimeOffset? lastModifiedOn, string lastModifiedBy, IList<SmartGroupAggregatedProperty> resources, IList<SmartGroupAggregatedProperty> resourceTypes, IList<SmartGroupAggregatedProperty> resourceGroups, IList<SmartGroupAggregatedProperty> monitorServices, IList<SmartGroupAggregatedProperty> monitorConditions, IList<SmartGroupAggregatedProperty> alertStates, IList<SmartGroupAggregatedProperty> alertSeverities, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AlertsCount = alertsCount;
            SmartGroupState = smartGroupState;
            Severity = severity;
            StartOn = startOn;
            LastModifiedOn = lastModifiedOn;
            LastModifiedBy = lastModifiedBy;
            Resources = resources;
            ResourceTypes = resourceTypes;
            ResourceGroups = resourceGroups;
            MonitorServices = monitorServices;
            MonitorConditions = monitorConditions;
            AlertStates = alertStates;
            AlertSeverities = alertSeverities;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Total number of alerts in smart group. </summary>
        public long? AlertsCount { get; set; }
        /// <summary> Smart group state. </summary>
        public SmartGroupState? SmartGroupState { get; }
        /// <summary> Severity of smart group is the highest(Sev0 &gt;... &gt; Sev4) severity of all the alerts in the group. </summary>
        public ServiceAlertSeverity? Severity { get; }
        /// <summary> Creation time of smart group. Date-Time in ISO-8601 format. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Last updated time of smart group. Date-Time in ISO-8601 format. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Last modified by user name. </summary>
        public string LastModifiedBy { get; }
        /// <summary> Summary of target resources in the smart group. </summary>
        public IList<SmartGroupAggregatedProperty> Resources { get; }
        /// <summary> Summary of target resource types in the smart group. </summary>
        public IList<SmartGroupAggregatedProperty> ResourceTypes { get; }
        /// <summary> Summary of target resource groups in the smart group. </summary>
        public IList<SmartGroupAggregatedProperty> ResourceGroups { get; }
        /// <summary> Summary of monitorServices in the smart group. </summary>
        public IList<SmartGroupAggregatedProperty> MonitorServices { get; }
        /// <summary> Summary of monitorConditions in the smart group. </summary>
        public IList<SmartGroupAggregatedProperty> MonitorConditions { get; }
        /// <summary> Summary of alertStates in the smart group. </summary>
        public IList<SmartGroupAggregatedProperty> AlertStates { get; }
        /// <summary> Summary of alertSeverities in the smart group. </summary>
        public IList<SmartGroupAggregatedProperty> AlertSeverities { get; }
        /// <summary> The URI to fetch the next page of alerts. Call ListNext() with this URI to fetch the next page alerts. </summary>
        public string NextLink { get; set; }
    }
}
