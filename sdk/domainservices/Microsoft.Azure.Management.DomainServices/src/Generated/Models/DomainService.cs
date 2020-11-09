// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DomainServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Domain service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DomainService : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DomainService class.
        /// </summary>
        public DomainService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainService class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="etag">Resource etag</param>
        /// <param name="version">Data Model Version</param>
        /// <param name="tenantId">Azure Active Directory Tenant Id</param>
        /// <param name="domainName">The name of the Azure domain that the user
        /// would like to deploy Domain Services to.</param>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="vnetSiteId">Virtual network site id</param>
        /// <param name="subnetId">The name of the virtual network that Domain
        /// Services will be deployed on. The id of the subnet that Domain
        /// Services will be deployed on.
        /// /virtualNetwork/vnetName/subnets/subnetName.</param>
        /// <param name="ldapsSettings">Secure LDAP Settings</param>
        /// <param name="domainSecuritySettings">DomainSecurity
        /// Settings</param>
        /// <param name="resourceForestSettings">Resource Forest
        /// Settings</param>
        /// <param name="domainConfigurationType">Domain Configuration
        /// Type</param>
        /// <param name="sku">Sku Type</param>
        /// <param name="healthLastEvaluated">Last domain evaluation run
        /// DateTime</param>
        /// <param name="healthMonitors">List of Domain Health Monitors</param>
        /// <param name="healthAlerts">List of Domain Health Alerts</param>
        /// <param name="notificationSettings">Notification Settings</param>
        /// <param name="filteredSync">Enabled or Disabled flag to turn on
        /// Group-based filtered sync. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="domainControllerIpAddress">List of Domain Controller
        /// IP Address</param>
        /// <param name="serviceStatus">Status of Domain Service
        /// instance</param>
        /// <param name="provisioningState">the current deployment or
        /// provisioning state, which only appears in the response.</param>
        public DomainService(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), int? version = default(int?), string tenantId = default(string), string domainName = default(string), string deploymentId = default(string), string vnetSiteId = default(string), string subnetId = default(string), LdapsSettings ldapsSettings = default(LdapsSettings), DomainSecuritySettings domainSecuritySettings = default(DomainSecuritySettings), ResourceForestSettings resourceForestSettings = default(ResourceForestSettings), string domainConfigurationType = default(string), string sku = default(string), System.DateTime? healthLastEvaluated = default(System.DateTime?), IList<HealthMonitor> healthMonitors = default(IList<HealthMonitor>), IList<HealthAlert> healthAlerts = default(IList<HealthAlert>), NotificationSettings notificationSettings = default(NotificationSettings), string filteredSync = default(string), IList<string> domainControllerIpAddress = default(IList<string>), string serviceStatus = default(string), string provisioningState = default(string))
            : base(id, name, type, location, tags, etag)
        {
            Version = version;
            TenantId = tenantId;
            DomainName = domainName;
            DeploymentId = deploymentId;
            VnetSiteId = vnetSiteId;
            SubnetId = subnetId;
            LdapsSettings = ldapsSettings;
            DomainSecuritySettings = domainSecuritySettings;
            ResourceForestSettings = resourceForestSettings;
            DomainConfigurationType = domainConfigurationType;
            Sku = sku;
            HealthLastEvaluated = healthLastEvaluated;
            HealthMonitors = healthMonitors;
            HealthAlerts = healthAlerts;
            NotificationSettings = notificationSettings;
            FilteredSync = filteredSync;
            DomainControllerIpAddress = domainControllerIpAddress;
            ServiceStatus = serviceStatus;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets data Model Version
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public int? Version { get; private set; }

        /// <summary>
        /// Gets azure Active Directory Tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the name of the Azure domain that the user would like
        /// to deploy Domain Services to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets deployment Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentId")]
        public string DeploymentId { get; private set; }

        /// <summary>
        /// Gets virtual network site id
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetSiteId")]
        public string VnetSiteId { get; private set; }

        /// <summary>
        /// Gets or sets the name of the virtual network that Domain Services
        /// will be deployed on. The id of the subnet that Domain Services will
        /// be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets secure LDAP Settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.ldapsSettings")]
        public LdapsSettings LdapsSettings { get; set; }

        /// <summary>
        /// Gets or sets domainSecurity Settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainSecuritySettings")]
        public DomainSecuritySettings DomainSecuritySettings { get; set; }

        /// <summary>
        /// Gets or sets resource Forest Settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceForestSettings")]
        public ResourceForestSettings ResourceForestSettings { get; set; }

        /// <summary>
        /// Gets or sets domain Configuration Type
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainConfigurationType")]
        public string DomainConfigurationType { get; set; }

        /// <summary>
        /// Gets or sets sku Type
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets last domain evaluation run DateTime
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "properties.healthLastEvaluated")]
        public System.DateTime? HealthLastEvaluated { get; private set; }

        /// <summary>
        /// Gets list of Domain Health Monitors
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthMonitors")]
        public IList<HealthMonitor> HealthMonitors { get; private set; }

        /// <summary>
        /// Gets list of Domain Health Alerts
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthAlerts")]
        public IList<HealthAlert> HealthAlerts { get; private set; }

        /// <summary>
        /// Gets or sets notification Settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationSettings")]
        public NotificationSettings NotificationSettings { get; set; }

        /// <summary>
        /// Gets or sets enabled or Disabled flag to turn on Group-based
        /// filtered sync. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.filteredSync")]
        public string FilteredSync { get; set; }

        /// <summary>
        /// Gets list of Domain Controller IP Address
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainControllerIpAddress")]
        public IList<string> DomainControllerIpAddress { get; private set; }

        /// <summary>
        /// Gets status of Domain Service instance
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceStatus")]
        public string ServiceStatus { get; private set; }

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
