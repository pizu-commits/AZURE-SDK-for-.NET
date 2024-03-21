// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> The properties parameters for a PATCH request to a grafana resource. </summary>
    public partial class ManagedGrafanaPatchProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedGrafanaPatchProperties"/>. </summary>
        public ManagedGrafanaPatchProperties()
        {
            GrafanaPlugins = new ChangeTrackingDictionary<string, GrafanaPlugin>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedGrafanaPatchProperties"/>. </summary>
        /// <param name="zoneRedundancy"> The zone redundancy setting of the Grafana instance. </param>
        /// <param name="apiKey"> The api key setting of the Grafana instance. </param>
        /// <param name="deterministicOutboundIP"> Whether a Grafana instance uses deterministic outbound IPs. </param>
        /// <param name="publicNetworkAccess"> Indicate the state for enable or disable traffic over the public interface. </param>
        /// <param name="grafanaIntegrations"> GrafanaIntegrations is a bundled observability experience (e.g. pre-configured data source, tailored Grafana dashboards, alerting defaults) for common monitoring scenarios. </param>
        /// <param name="enterpriseConfigurations"> Enterprise settings of a Grafana instance. </param>
        /// <param name="grafanaConfigurations"> Server configurations of a Grafana instance. </param>
        /// <param name="grafanaPlugins"> Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given plugin id will be removed. Otherwise, given plugin will be installed. </param>
        /// <param name="grafanaMajorVersion"> The major Grafana software version to target. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedGrafanaPatchProperties(GrafanaZoneRedundancy? zoneRedundancy, GrafanaApiKey? apiKey, DeterministicOutboundIP? deterministicOutboundIP, GrafanaPublicNetworkAccess? publicNetworkAccess, GrafanaIntegrations grafanaIntegrations, EnterpriseConfigurations enterpriseConfigurations, GrafanaConfigurations grafanaConfigurations, IDictionary<string, GrafanaPlugin> grafanaPlugins, string grafanaMajorVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ZoneRedundancy = zoneRedundancy;
            ApiKey = apiKey;
            DeterministicOutboundIP = deterministicOutboundIP;
            PublicNetworkAccess = publicNetworkAccess;
            GrafanaIntegrations = grafanaIntegrations;
            EnterpriseConfigurations = enterpriseConfigurations;
            GrafanaConfigurations = grafanaConfigurations;
            GrafanaPlugins = grafanaPlugins;
            GrafanaMajorVersion = grafanaMajorVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The zone redundancy setting of the Grafana instance. </summary>
        public GrafanaZoneRedundancy? ZoneRedundancy { get; set; }
        /// <summary> The api key setting of the Grafana instance. </summary>
        public GrafanaApiKey? ApiKey { get; set; }
        /// <summary> Whether a Grafana instance uses deterministic outbound IPs. </summary>
        public DeterministicOutboundIP? DeterministicOutboundIP { get; set; }
        /// <summary> Indicate the state for enable or disable traffic over the public interface. </summary>
        public GrafanaPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> GrafanaIntegrations is a bundled observability experience (e.g. pre-configured data source, tailored Grafana dashboards, alerting defaults) for common monitoring scenarios. </summary>
        internal GrafanaIntegrations GrafanaIntegrations { get; set; }
        /// <summary> Gets the monitor workspace integrations. </summary>
        public IList<MonitorWorkspaceIntegration> MonitorWorkspaceIntegrations
        {
            get
            {
                if (GrafanaIntegrations is null)
                    GrafanaIntegrations = new GrafanaIntegrations();
                return GrafanaIntegrations.MonitorWorkspaceIntegrations;
            }
        }

        /// <summary> Enterprise settings of a Grafana instance. </summary>
        public EnterpriseConfigurations EnterpriseConfigurations { get; set; }
        /// <summary> Server configurations of a Grafana instance. </summary>
        internal GrafanaConfigurations GrafanaConfigurations { get; set; }
        /// <summary>
        /// Email server settings.
        /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
        /// </summary>
        public Smtp GrafanaConfigurationsSmtp
        {
            get => GrafanaConfigurations is null ? default : GrafanaConfigurations.Smtp;
            set
            {
                if (GrafanaConfigurations is null)
                    GrafanaConfigurations = new GrafanaConfigurations();
                GrafanaConfigurations.Smtp = value;
            }
        }

        /// <summary> Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given plugin id will be removed. Otherwise, given plugin will be installed. </summary>
        public IDictionary<string, GrafanaPlugin> GrafanaPlugins { get; }
        /// <summary> The major Grafana software version to target. </summary>
        public string GrafanaMajorVersion { get; set; }
    }
}
