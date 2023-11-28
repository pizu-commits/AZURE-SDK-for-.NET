// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the TopicType data model.
    /// Properties of a topic type info.
    /// </summary>
    public partial class TopicTypeData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TopicTypeData"/>. </summary>
        public TopicTypeData()
        {
            SupportedLocations = new ChangeTrackingList<string>();
            SupportedScopesForSource = new ChangeTrackingList<TopicTypeSourceScope>();
        }

        /// <summary> Initializes a new instance of <see cref="TopicTypeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provider"> Namespace of the provider of the topic type. </param>
        /// <param name="displayName"> Display Name for the topic type. </param>
        /// <param name="description"> Description of the topic type. </param>
        /// <param name="resourceRegionType"> Region type of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the topic type. </param>
        /// <param name="supportedLocations"> List of locations supported by this topic type. </param>
        /// <param name="sourceResourceFormat"> Source resource format. </param>
        /// <param name="supportedScopesForSource"> Supported source scopes. </param>
        /// <param name="areRegionalAndGlobalSourcesSupported"> Flag to indicate that a topic type can support both regional or global system topics. </param>
        internal TopicTypeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provider, string displayName, string description, EventGridResourceRegionType? resourceRegionType, TopicTypeProvisioningState? provisioningState, IList<string> supportedLocations, string sourceResourceFormat, IList<TopicTypeSourceScope> supportedScopesForSource, bool? areRegionalAndGlobalSourcesSupported) : base(id, name, resourceType, systemData)
        {
            Provider = provider;
            DisplayName = displayName;
            Description = description;
            ResourceRegionType = resourceRegionType;
            ProvisioningState = provisioningState;
            SupportedLocations = supportedLocations;
            SourceResourceFormat = sourceResourceFormat;
            SupportedScopesForSource = supportedScopesForSource;
            AreRegionalAndGlobalSourcesSupported = areRegionalAndGlobalSourcesSupported;
        }

        /// <summary> Namespace of the provider of the topic type. </summary>
        public string Provider { get; set; }
        /// <summary> Display Name for the topic type. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of the topic type. </summary>
        public string Description { get; set; }
        /// <summary> Region type of the resource. </summary>
        public EventGridResourceRegionType? ResourceRegionType { get; set; }
        /// <summary> Provisioning state of the topic type. </summary>
        public TopicTypeProvisioningState? ProvisioningState { get; set; }
        /// <summary> List of locations supported by this topic type. </summary>
        public IList<string> SupportedLocations { get; }
        /// <summary> Source resource format. </summary>
        public string SourceResourceFormat { get; set; }
        /// <summary> Supported source scopes. </summary>
        public IList<TopicTypeSourceScope> SupportedScopesForSource { get; }
        /// <summary> Flag to indicate that a topic type can support both regional or global system topics. </summary>
        public bool? AreRegionalAndGlobalSourcesSupported { get; set; }
    }
}
