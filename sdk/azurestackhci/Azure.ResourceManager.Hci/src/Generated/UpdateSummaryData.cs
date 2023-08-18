// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the UpdateSummary data model.
    /// Get the update summaries for the cluster
    /// </summary>
    public partial class UpdateSummaryData : ResourceData
    {
        /// <summary> Initializes a new instance of UpdateSummaryData. </summary>
        public UpdateSummaryData()
        {
            PackageVersions = new Core.ChangeTrackingList<HciPackageVersionInfo>();
            HealthCheckResult = new Core.ChangeTrackingList<HciPrecheckResult>();
        }

        /// <summary> Initializes a new instance of UpdateSummaryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="provisioningState"> Provisioning state of the UpdateSummaries proxy resource. </param>
        /// <param name="oemFamily"> OEM family name. </param>
        /// <param name="hardwareModel"> Name of the hardware model. </param>
        /// <param name="packageVersions"> Current version of each updatable component. </param>
        /// <param name="currentVersion"> Current Solution Bundle version of the stamp. </param>
        /// <param name="lastUpdated"> Last time an update installation completed successfully. </param>
        /// <param name="lastChecked"> Last time the update service successfully checked for updates. </param>
        /// <param name="healthState"> Overall health state for update-specific health checks. </param>
        /// <param name="healthCheckResult"> An array of pre-check result objects. </param>
        /// <param name="healthCheckOn"> Last time the package-specific checks were run. </param>
        /// <param name="state"> Overall update state of the stamp. </param>
        internal UpdateSummaryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, HciProvisioningState? provisioningState, string oemFamily, string hardwareModel, IList<HciPackageVersionInfo> packageVersions, string currentVersion, DateTimeOffset? lastUpdated, DateTimeOffset? lastChecked, HciHealthState? healthState, IList<HciPrecheckResult> healthCheckResult, DateTimeOffset? healthCheckOn, UpdateSummariesPropertiesState? state) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ProvisioningState = provisioningState;
            OemFamily = oemFamily;
            HardwareModel = hardwareModel;
            PackageVersions = packageVersions;
            CurrentVersion = currentVersion;
            LastUpdated = lastUpdated;
            LastChecked = lastChecked;
            HealthState = healthState;
            HealthCheckResult = healthCheckResult;
            HealthCheckOn = healthCheckOn;
            State = state;
        }

        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Provisioning state of the UpdateSummaries proxy resource. </summary>
        public HciProvisioningState? ProvisioningState { get; }
        /// <summary> OEM family name. </summary>
        public string OemFamily { get; set; }
        /// <summary> Name of the hardware model. </summary>
        public string HardwareModel { get; set; }
        /// <summary> Current version of each updatable component. </summary>
        public IList<HciPackageVersionInfo> PackageVersions { get; }
        /// <summary> Current Solution Bundle version of the stamp. </summary>
        public string CurrentVersion { get; set; }
        /// <summary> Last time an update installation completed successfully. </summary>
        public DateTimeOffset? LastUpdated { get; set; }
        /// <summary> Last time the update service successfully checked for updates. </summary>
        public DateTimeOffset? LastChecked { get; set; }
        /// <summary> Overall health state for update-specific health checks. </summary>
        public HciHealthState? HealthState { get; set; }
        /// <summary> An array of pre-check result objects. </summary>
        public IList<HciPrecheckResult> HealthCheckResult { get; }
        /// <summary> Last time the package-specific checks were run. </summary>
        public DateTimeOffset? HealthCheckOn { get; set; }
        /// <summary> Overall update state of the stamp. </summary>
        public UpdateSummariesPropertiesState? State { get; set; }
    }
}
