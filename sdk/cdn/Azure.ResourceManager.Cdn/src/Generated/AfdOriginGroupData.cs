// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdOriginGroup data model. </summary>
    public partial class AfdOriginGroupData : ProxyResource
    {
        /// <summary> Initializes a new instance of AfdOriginGroupData. </summary>
        public AfdOriginGroupData()
        {
        }

        /// <summary> Initializes a new instance of AfdOriginGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Read only system data. </param>
        /// <param name="loadBalancingSettings"> Load balancing settings for a backend pool. </param>
        /// <param name="healthProbeSettings"> Health probe settings to the origin that is used to determine the health of the origin. </param>
        /// <param name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes"> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </param>
        /// <param name="responseBasedAfdOriginErrorDetectionSettings"> The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported. </param>
        /// <param name="sessionAffinityState"> Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        internal AfdOriginGroupData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, LoadBalancingSettingsParameters loadBalancingSettings, HealthProbeParameters healthProbeSettings, int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes, ResponseBasedOriginErrorDetectionParameters responseBasedAfdOriginErrorDetectionSettings, EnabledState? sessionAffinityState, AfdProvisioningState? provisioningState, DeploymentStatus? deploymentStatus) : base(id, name, type, systemData)
        {
            LoadBalancingSettings = loadBalancingSettings;
            HealthProbeSettings = healthProbeSettings;
            TrafficRestorationTimeToHealedOrNewEndpointsInMinutes = trafficRestorationTimeToHealedOrNewEndpointsInMinutes;
            ResponseBasedAfdOriginErrorDetectionSettings = responseBasedAfdOriginErrorDetectionSettings;
            SessionAffinityState = sessionAffinityState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
        }

        /// <summary> Load balancing settings for a backend pool. </summary>
        public LoadBalancingSettingsParameters LoadBalancingSettings { get; set; }
        /// <summary> Health probe settings to the origin that is used to determine the health of the origin. </summary>
        public HealthProbeParameters HealthProbeSettings { get; set; }
        /// <summary> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </summary>
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
        /// <summary> The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported. </summary>
        public ResponseBasedOriginErrorDetectionParameters ResponseBasedAfdOriginErrorDetectionSettings { get; set; }
        /// <summary> Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? SessionAffinityState { get; set; }
        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
    }
}
