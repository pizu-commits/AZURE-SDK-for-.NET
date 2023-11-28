// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.IotCentral;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmIotCentralModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="IotCentral.IotCentralAppData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="skuName"> A valid instance SKU. </param>
        /// <param name="identity"> The managed identities for the IoT Central application. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="provisioningState"> The provisioning state of the application. </param>
        /// <param name="applicationId"> The ID of the application. </param>
        /// <param name="displayName"> The display name of the application. </param>
        /// <param name="subdomain"> The subdomain of the application. </param>
        /// <param name="template"> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </param>
        /// <param name="state"> The current state of the application. </param>
        /// <param name="publicNetworkAccess"> Whether requests from the public network are allowed. </param>
        /// <param name="networkRuleSets"> Network Rule Set Properties of this IoT Central application. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IoT Central application. </param>
        /// <returns> A new <see cref="IotCentral.IotCentralAppData"/> instance for mocking. </returns>
        public static IotCentralAppData IotCentralAppData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IotCentralAppSku? skuName = null, ManagedServiceIdentity identity = null, IotCentralProvisioningState? provisioningState = null, Guid? applicationId = null, string displayName = null, string subdomain = null, string template = null, IotCentralAppState? state = null, IotCentralPublicNetworkAccess? publicNetworkAccess = null, IotCentralNetworkRuleSets networkRuleSets = null, IEnumerable<IotCentralPrivateEndpointConnectionData> privateEndpointConnections = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<IotCentralPrivateEndpointConnectionData>();

            return new IotCentralAppData(id, name, resourceType, systemData, tags, location, skuName.HasValue ? new IotCentralAppSkuInfo(skuName.Value) : null, identity, provisioningState, applicationId, displayName, subdomain, template, state, publicNetworkAccess, networkRuleSets, privateEndpointConnections?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="IotCentral.IotCentralPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupIds"> The group ids for the private endpoint resource. </param>
        /// <param name="privateEndpointId"> The private endpoint resource. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <returns> A new <see cref="IotCentral.IotCentralPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static IotCentralPrivateEndpointConnectionData IotCentralPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<string> groupIds = null, ResourceIdentifier privateEndpointId = null, IotCentralPrivateLinkServiceConnectionState connectionState = null, IotCentralPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            groupIds ??= new List<string>();

            return new IotCentralPrivateEndpointConnectionData(id, name, resourceType, systemData, groupIds?.ToList(), privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="IotCentral.IotCentralPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource private link DNS zone name. </param>
        /// <returns> A new <see cref="IotCentral.IotCentralPrivateLinkResourceData"/> instance for mocking. </returns>
        public static IotCentralPrivateLinkResourceData IotCentralPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new IotCentralPrivateLinkResourceData(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.IotCentralAppNameAvailabilityResponse"/>. </summary>
        /// <param name="isNameAvailable"> The value which indicates whether the provided name is available. </param>
        /// <param name="iotCentralAppNameUnavailableReason"> The reason for unavailability. </param>
        /// <param name="message"> The detailed reason message. </param>
        /// <returns> A new <see cref="Models.IotCentralAppNameAvailabilityResponse"/> instance for mocking. </returns>
        public static IotCentralAppNameAvailabilityResponse IotCentralAppNameAvailabilityResponse(bool? isNameAvailable = null, string iotCentralAppNameUnavailableReason = null, string message = null)
        {
            return new IotCentralAppNameAvailabilityResponse(isNameAvailable, iotCentralAppNameUnavailableReason, message);
        }

        /// <summary> Initializes a new instance of <see cref="Models.IotCentralAppTemplate"/>. </summary>
        /// <param name="manifestId"> The ID of the template. </param>
        /// <param name="manifestVersion"> The version of the template. </param>
        /// <param name="name"> The name of the template. </param>
        /// <param name="title"> The title of the template. </param>
        /// <param name="order"> The order of the template in the templates list. </param>
        /// <param name="description"> The description of the template. </param>
        /// <param name="industry"> The industry of the template. </param>
        /// <param name="locations"> A list of locations that support the template. </param>
        /// <returns> A new <see cref="Models.IotCentralAppTemplate"/> instance for mocking. </returns>
        public static IotCentralAppTemplate IotCentralAppTemplate(string manifestId = null, string manifestVersion = null, string name = null, string title = null, int? order = null, string description = null, string industry = null, IEnumerable<IotCentralAppTemplateLocation> locations = null)
        {
            locations ??= new List<IotCentralAppTemplateLocation>();

            return new IotCentralAppTemplate(manifestId, manifestVersion, name, title, order, description, industry, locations?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.IotCentralAppTemplateLocation"/>. </summary>
        /// <param name="location"> The ID of the location. </param>
        /// <param name="displayName"> The display name of the location. </param>
        /// <returns> A new <see cref="Models.IotCentralAppTemplateLocation"/> instance for mocking. </returns>
        public static IotCentralAppTemplateLocation IotCentralAppTemplateLocation(AzureLocation? location = null, string displayName = null)
        {
            return new IotCentralAppTemplateLocation(location, displayName);
        }
    }
}
