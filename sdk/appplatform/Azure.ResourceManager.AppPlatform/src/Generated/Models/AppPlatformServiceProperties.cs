// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Service properties payload. </summary>
    public partial class AppPlatformServiceProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformServiceProperties"/>. </summary>
        public AppPlatformServiceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformServiceProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the Service. </param>
        /// <param name="networkProfile"> Network profile of the Service. </param>
        /// <param name="vnetAddons"> Additional Service settings in vnet injection instance. </param>
        /// <param name="version"> Version of the Service. </param>
        /// <param name="serviceInstanceId"> ServiceInstanceEntity GUID which uniquely identifies a created resource. </param>
        /// <param name="powerState"> Power state of the Service. </param>
        /// <param name="isZoneRedundant"></param>
        /// <param name="fqdn"> Fully qualified dns name of the service instance. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformServiceProperties(AppPlatformServiceProvisioningState? provisioningState, AppPlatformServiceNetworkProfile networkProfile, ServiceVnetAddons vnetAddons, int? version, string serviceInstanceId, AppPlatformServicePowerState? powerState, bool? isZoneRedundant, string fqdn, Dictionary<string, BinaryData> rawData)
        {
            ProvisioningState = provisioningState;
            NetworkProfile = networkProfile;
            VnetAddons = vnetAddons;
            Version = version;
            ServiceInstanceId = serviceInstanceId;
            PowerState = powerState;
            IsZoneRedundant = isZoneRedundant;
            Fqdn = fqdn;
            _rawData = rawData;
        }

        /// <summary> Provisioning state of the Service. </summary>
        public AppPlatformServiceProvisioningState? ProvisioningState { get; }
        /// <summary> Network profile of the Service. </summary>
        public AppPlatformServiceNetworkProfile NetworkProfile { get; set; }
        /// <summary> Additional Service settings in vnet injection instance. </summary>
        internal ServiceVnetAddons VnetAddons { get; set; }
        /// <summary> Indicates whether the log stream in vnet injection instance could be accessed from internet. </summary>
        public bool? IsLogStreamPublicEndpoint
        {
            get => VnetAddons is null ? default : VnetAddons.IsLogStreamPublicEndpoint;
            set
            {
                if (VnetAddons is null)
                    VnetAddons = new ServiceVnetAddons();
                VnetAddons.IsLogStreamPublicEndpoint = value;
            }
        }

        /// <summary> Version of the Service. </summary>
        public int? Version { get; }
        /// <summary> ServiceInstanceEntity GUID which uniquely identifies a created resource. </summary>
        public string ServiceInstanceId { get; }
        /// <summary> Power state of the Service. </summary>
        public AppPlatformServicePowerState? PowerState { get; }
        /// <summary> Gets or sets the is zone redundant. </summary>
        public bool? IsZoneRedundant { get; set; }
        /// <summary> Fully qualified dns name of the service instance. </summary>
        public string Fqdn { get; }
    }
}
