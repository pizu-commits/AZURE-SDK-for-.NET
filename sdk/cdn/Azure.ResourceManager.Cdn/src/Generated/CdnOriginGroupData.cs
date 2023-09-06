// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the CdnOriginGroup data model.
    /// Origin group comprising of origins is used for load balancing to origins when the content cannot be served from CDN.
    /// </summary>
    public partial class CdnOriginGroupData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CdnOriginGroupData"/>. </summary>
        public CdnOriginGroupData()
        {
            Origins = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CdnOriginGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="healthProbeSettings"> Health probe settings to the origin that is used to determine the health of the origin. </param>
        /// <param name="origins"> The source of the content being delivered via CDN within given origin group. </param>
        /// <param name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes"> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </param>
        /// <param name="responseBasedOriginErrorDetectionSettings"> The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported. </param>
        /// <param name="resourceState"> Resource status of the origin group. </param>
        /// <param name="provisioningState"> Provisioning status of the origin group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnOriginGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, HealthProbeSettings healthProbeSettings, IList<WritableSubResource> origins, int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes, ResponseBasedOriginErrorDetectionSettings responseBasedOriginErrorDetectionSettings, OriginGroupResourceState? resourceState, OriginGroupProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            HealthProbeSettings = healthProbeSettings;
            Origins = origins;
            TrafficRestorationTimeToHealedOrNewEndpointsInMinutes = trafficRestorationTimeToHealedOrNewEndpointsInMinutes;
            ResponseBasedOriginErrorDetectionSettings = responseBasedOriginErrorDetectionSettings;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Health probe settings to the origin that is used to determine the health of the origin. </summary>
        public HealthProbeSettings HealthProbeSettings { get; set; }
        /// <summary> The source of the content being delivered via CDN within given origin group. </summary>
        public IList<WritableSubResource> Origins { get; }
        /// <summary> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </summary>
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
        /// <summary> The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported. </summary>
        public ResponseBasedOriginErrorDetectionSettings ResponseBasedOriginErrorDetectionSettings { get; set; }
        /// <summary> Resource status of the origin group. </summary>
        public OriginGroupResourceState? ResourceState { get; }
        /// <summary> Provisioning status of the origin group. </summary>
        public OriginGroupProvisioningState? ProvisioningState { get; }
    }
}
