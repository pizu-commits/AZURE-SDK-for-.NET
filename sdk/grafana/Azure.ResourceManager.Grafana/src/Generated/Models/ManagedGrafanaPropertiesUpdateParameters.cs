// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> The properties parameters for a PATCH request to a grafana resource. </summary>
    public partial class ManagedGrafanaPropertiesUpdateParameters
    {
        /// <summary> Initializes a new instance of ManagedGrafanaPropertiesUpdateParameters. </summary>
        public ManagedGrafanaPropertiesUpdateParameters()
        {
        }

        /// <summary> The zone redundancy setting of the Grafana instance. </summary>
        public GrafanaZoneRedundancy? ZoneRedundancy { get; set; }
        /// <summary> The api key setting of the Grafana instance. </summary>
        public GrafanaApiKey? ApiKey { get; set; }
        /// <summary> Whether a Grafana instance uses deterministic outbound IPs. </summary>
        public DeterministicOutboundIP? DeterministicOutboundIP { get; set; }
        /// <summary> Indicate the state for enable or disable traffic over the public interface. </summary>
        public GrafanaPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
