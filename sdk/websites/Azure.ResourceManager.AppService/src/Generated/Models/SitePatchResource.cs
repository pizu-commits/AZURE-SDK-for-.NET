// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> ARM resource for a site. </summary>
    public partial class SitePatchResource : ResourceData
    {
        /// <summary> Initializes a new instance of SitePatchResource. </summary>
        public SitePatchResource()
        {
            HostNames = new ChangeTrackingList<string>();
            EnabledHostNames = new ChangeTrackingList<string>();
            HostNameSslStates = new ChangeTrackingList<HostNameSslState>();
            TrafficManagerHostNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SitePatchResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> Managed service identity. </param>
        /// <param name="state"> Current state of the app. </param>
        /// <param name="hostNames"> Hostnames associated with the app. </param>
        /// <param name="repositorySiteName"> Name of the repository site. </param>
        /// <param name="usageState"> State indicating whether the app has exceeded its quota usage. Read-only. </param>
        /// <param name="enabled"> &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables the app (takes the app offline). </param>
        /// <param name="enabledHostNames">
        /// Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
        /// the app is not served on those hostnames.
        /// </param>
        /// <param name="availabilityState"> Management information availability state for the app. </param>
        /// <param name="hostNameSslStates"> Hostname SSL states are used to manage the SSL bindings for app&apos;s hostnames. </param>
        /// <param name="serverFarmId"> Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;. </param>
        /// <param name="reserved"> &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isXenon"> Obsolete: Hyper-V sandbox. </param>
        /// <param name="hyperV"> Hyper-V sandbox. </param>
        /// <param name="lastModifiedTimeUtc"> Last time the app was modified, in UTC. Read-only. </param>
        /// <param name="siteConfig"> Configuration of the app. </param>
        /// <param name="trafficManagerHostNames"> Azure Traffic Manager hostnames associated with the app. Read-only. </param>
        /// <param name="scmSiteAlsoStopped"> &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="targetSwapSlot"> Specifies which deployment slot this app will swap into. Read-only. </param>
        /// <param name="hostingEnvironmentProfile"> App Service Environment to use for the app. </param>
        /// <param name="clientAffinityEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="clientCertEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise, &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="clientCertMode">
        /// This composes with ClientCertEnabled setting.
        /// - ClientCertEnabled: false means ClientCert is ignored.
        /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
        /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
        /// </param>
        /// <param name="clientCertExclusionPaths"> client certificate authentication comma-separated exclusion paths. </param>
        /// <param name="hostNamesDisabled">
        /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
        /// </param>
        /// <param name="customDomainVerificationId"> Unique identifier that verifies the custom domains assigned to the app. Customer will add this id to a txt record for verification. </param>
        /// <param name="outboundIPAddresses"> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from tenants that site can be hosted with current settings. Read-only. </param>
        /// <param name="possibleOutboundIPAddresses"> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from all tenants except dataComponent. Read-only. </param>
        /// <param name="containerSize"> Size of the function container. </param>
        /// <param name="dailyMemoryTimeQuota"> Maximum allowed daily memory-time quota (applicable on dynamic apps only). </param>
        /// <param name="suspendedTill"> App suspended till in case memory-time quota is exceeded. </param>
        /// <param name="maxNumberOfWorkers">
        /// Maximum number of workers.
        /// This only applies to Functions container.
        /// </param>
        /// <param name="cloningInfo"> If specified during app creation, the app is cloned from a source app. </param>
        /// <param name="resourceGroup"> Name of the resource group the app belongs to. Read-only. </param>
        /// <param name="isDefaultContainer"> &lt;code&gt;true&lt;/code&gt; if the app is a default container; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="defaultHostName"> Default hostname of the app. Read-only. </param>
        /// <param name="slotSwapStatus"> Status of the last deployment slot swap operation. </param>
        /// <param name="httpsOnly">
        /// HttpsOnly: configures a web site to accept only https requests. Issues redirect for
        /// http requests
        /// </param>
        /// <param name="redundancyMode"> Site redundancy mode. </param>
        /// <param name="inProgressOperationId"> Specifies an operation id if this site has a pending operation. </param>
        /// <param name="storageAccountRequired"> Checks if Customer provided storage account is required. </param>
        /// <param name="keyVaultReferenceIdentity"> Identity to use for Key Vault Reference authentication. </param>
        /// <param name="virtualNetworkSubnetId">
        /// Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET Integration.
        /// This must be of the form /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
        /// </param>
        /// <param name="kind"> Kind of resource. </param>
        internal SitePatchResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, string state, IReadOnlyList<string> hostNames, string repositorySiteName, UsageState? usageState, bool? enabled, IReadOnlyList<string> enabledHostNames, SiteAvailabilityState? availabilityState, IList<HostNameSslState> hostNameSslStates, string serverFarmId, bool? reserved, bool? isXenon, bool? hyperV, DateTimeOffset? lastModifiedTimeUtc, SiteConfigProperties siteConfig, IReadOnlyList<string> trafficManagerHostNames, bool? scmSiteAlsoStopped, string targetSwapSlot, HostingEnvironmentProfile hostingEnvironmentProfile, bool? clientAffinityEnabled, bool? clientCertEnabled, ClientCertMode? clientCertMode, string clientCertExclusionPaths, bool? hostNamesDisabled, string customDomainVerificationId, string outboundIPAddresses, string possibleOutboundIPAddresses, int? containerSize, int? dailyMemoryTimeQuota, DateTimeOffset? suspendedTill, int? maxNumberOfWorkers, CloningInfo cloningInfo, string resourceGroup, bool? isDefaultContainer, string defaultHostName, SlotSwapStatus slotSwapStatus, bool? httpsOnly, RedundancyMode? redundancyMode, Guid? inProgressOperationId, bool? storageAccountRequired, string keyVaultReferenceIdentity, string virtualNetworkSubnetId, string kind) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            State = state;
            HostNames = hostNames;
            RepositorySiteName = repositorySiteName;
            UsageState = usageState;
            Enabled = enabled;
            EnabledHostNames = enabledHostNames;
            AvailabilityState = availabilityState;
            HostNameSslStates = hostNameSslStates;
            ServerFarmId = serverFarmId;
            Reserved = reserved;
            IsXenon = isXenon;
            HyperV = hyperV;
            LastModifiedTimeUtc = lastModifiedTimeUtc;
            SiteConfig = siteConfig;
            TrafficManagerHostNames = trafficManagerHostNames;
            ScmSiteAlsoStopped = scmSiteAlsoStopped;
            TargetSwapSlot = targetSwapSlot;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            ClientAffinityEnabled = clientAffinityEnabled;
            ClientCertEnabled = clientCertEnabled;
            ClientCertMode = clientCertMode;
            ClientCertExclusionPaths = clientCertExclusionPaths;
            HostNamesDisabled = hostNamesDisabled;
            CustomDomainVerificationId = customDomainVerificationId;
            OutboundIPAddresses = outboundIPAddresses;
            PossibleOutboundIPAddresses = possibleOutboundIPAddresses;
            ContainerSize = containerSize;
            DailyMemoryTimeQuota = dailyMemoryTimeQuota;
            SuspendedTill = suspendedTill;
            MaxNumberOfWorkers = maxNumberOfWorkers;
            CloningInfo = cloningInfo;
            ResourceGroup = resourceGroup;
            IsDefaultContainer = isDefaultContainer;
            DefaultHostName = defaultHostName;
            SlotSwapStatus = slotSwapStatus;
            HttpsOnly = httpsOnly;
            RedundancyMode = redundancyMode;
            InProgressOperationId = inProgressOperationId;
            StorageAccountRequired = storageAccountRequired;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
            Kind = kind;
        }

        /// <summary> Managed service identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Current state of the app. </summary>
        public string State { get; }
        /// <summary> Hostnames associated with the app. </summary>
        public IReadOnlyList<string> HostNames { get; }
        /// <summary> Name of the repository site. </summary>
        public string RepositorySiteName { get; }
        /// <summary> State indicating whether the app has exceeded its quota usage. Read-only. </summary>
        public UsageState? UsageState { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables the app (takes the app offline). </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
        /// the app is not served on those hostnames.
        /// </summary>
        public IReadOnlyList<string> EnabledHostNames { get; }
        /// <summary> Management information availability state for the app. </summary>
        public SiteAvailabilityState? AvailabilityState { get; }
        /// <summary> Hostname SSL states are used to manage the SSL bindings for app&apos;s hostnames. </summary>
        public IList<HostNameSslState> HostNameSslStates { get; }
        /// <summary> Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;. </summary>
        public string ServerFarmId { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? Reserved { get; set; }
        /// <summary> Obsolete: Hyper-V sandbox. </summary>
        public bool? IsXenon { get; set; }
        /// <summary> Hyper-V sandbox. </summary>
        public bool? HyperV { get; set; }
        /// <summary> Last time the app was modified, in UTC. Read-only. </summary>
        public DateTimeOffset? LastModifiedTimeUtc { get; }
        /// <summary> Configuration of the app. </summary>
        public SiteConfigProperties SiteConfig { get; set; }
        /// <summary> Azure Traffic Manager hostnames associated with the app. Read-only. </summary>
        public IReadOnlyList<string> TrafficManagerHostNames { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? ScmSiteAlsoStopped { get; set; }
        /// <summary> Specifies which deployment slot this app will swap into. Read-only. </summary>
        public string TargetSwapSlot { get; }
        /// <summary> App Service Environment to use for the app. </summary>
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? ClientAffinityEnabled { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise, &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? ClientCertEnabled { get; set; }
        /// <summary>
        /// This composes with ClientCertEnabled setting.
        /// - ClientCertEnabled: false means ClientCert is ignored.
        /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
        /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
        /// </summary>
        public ClientCertMode? ClientCertMode { get; set; }
        /// <summary> client certificate authentication comma-separated exclusion paths. </summary>
        public string ClientCertExclusionPaths { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
        /// </summary>
        public bool? HostNamesDisabled { get; set; }
        /// <summary> Unique identifier that verifies the custom domains assigned to the app. Customer will add this id to a txt record for verification. </summary>
        public string CustomDomainVerificationId { get; set; }
        /// <summary> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from tenants that site can be hosted with current settings. Read-only. </summary>
        public string OutboundIPAddresses { get; }
        /// <summary> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from all tenants except dataComponent. Read-only. </summary>
        public string PossibleOutboundIPAddresses { get; }
        /// <summary> Size of the function container. </summary>
        public int? ContainerSize { get; set; }
        /// <summary> Maximum allowed daily memory-time quota (applicable on dynamic apps only). </summary>
        public int? DailyMemoryTimeQuota { get; set; }
        /// <summary> App suspended till in case memory-time quota is exceeded. </summary>
        public DateTimeOffset? SuspendedTill { get; }
        /// <summary>
        /// Maximum number of workers.
        /// This only applies to Functions container.
        /// </summary>
        public int? MaxNumberOfWorkers { get; }
        /// <summary> If specified during app creation, the app is cloned from a source app. </summary>
        public CloningInfo CloningInfo { get; set; }
        /// <summary> Name of the resource group the app belongs to. Read-only. </summary>
        public string ResourceGroup { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the app is a default container; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDefaultContainer { get; }
        /// <summary> Default hostname of the app. Read-only. </summary>
        public string DefaultHostName { get; }
        /// <summary> Status of the last deployment slot swap operation. </summary>
        public SlotSwapStatus SlotSwapStatus { get; }
        /// <summary>
        /// HttpsOnly: configures a web site to accept only https requests. Issues redirect for
        /// http requests
        /// </summary>
        public bool? HttpsOnly { get; set; }
        /// <summary> Site redundancy mode. </summary>
        public RedundancyMode? RedundancyMode { get; set; }
        /// <summary> Specifies an operation id if this site has a pending operation. </summary>
        public Guid? InProgressOperationId { get; }
        /// <summary> Checks if Customer provided storage account is required. </summary>
        public bool? StorageAccountRequired { get; set; }
        /// <summary> Identity to use for Key Vault Reference authentication. </summary>
        public string KeyVaultReferenceIdentity { get; set; }
        /// <summary>
        /// Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET Integration.
        /// This must be of the form /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
        /// </summary>
        public string VirtualNetworkSubnetId { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
