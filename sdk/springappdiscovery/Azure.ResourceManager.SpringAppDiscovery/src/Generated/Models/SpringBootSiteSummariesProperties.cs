// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    /// <summary>
    /// Summaries properties
    /// Serialized Name: SummariesProperties
    /// </summary>
    public partial class SpringBootSiteSummariesProperties
    {
        /// <summary> Initializes a new instance of <see cref="SpringBootSiteSummariesProperties"/>. </summary>
        public SpringBootSiteSummariesProperties()
        {
            Errors = new ChangeTrackingList<SpringBootSiteError>();
        }

        /// <summary> Initializes a new instance of <see cref="SpringBootSiteSummariesProperties"/>. </summary>
        /// <param name="discoveredServers">
        /// The of number discovered spring boot servers.
        /// Serialized Name: SummariesProperties.discoveredServers
        /// </param>
        /// <param name="discoveredApps">
        /// The of number discovered spring boot apps.
        /// Serialized Name: SummariesProperties.discoveredApps
        /// </param>
        /// <param name="errors">
        /// The list of errors.
        /// Serialized Name: SummariesProperties.errors
        /// </param>
        /// <param name="provisioningState">
        /// The resource provisioning state.
        /// Serialized Name: SummariesProperties.provisioningState
        /// </param>
        internal SpringBootSiteSummariesProperties(long? discoveredServers, long? discoveredApps, IList<SpringBootSiteError> errors, SpringAppDiscoveryProvisioningState? provisioningState)
        {
            DiscoveredServers = discoveredServers;
            DiscoveredApps = discoveredApps;
            Errors = errors;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// The of number discovered spring boot servers.
        /// Serialized Name: SummariesProperties.discoveredServers
        /// </summary>
        public long? DiscoveredServers { get; set; }
        /// <summary>
        /// The of number discovered spring boot apps.
        /// Serialized Name: SummariesProperties.discoveredApps
        /// </summary>
        public long? DiscoveredApps { get; set; }
        /// <summary>
        /// The list of errors.
        /// Serialized Name: SummariesProperties.errors
        /// </summary>
        public IList<SpringBootSiteError> Errors { get; }
        /// <summary>
        /// The resource provisioning state.
        /// Serialized Name: SummariesProperties.provisioningState
        /// </summary>
        public SpringAppDiscoveryProvisioningState? ProvisioningState { get; set; }
    }
}
