// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class AppWhitelistingGroup
    {
        /// <summary>
        /// Initializes a new instance of the AppWhitelistingGroup class.
        /// </summary>
        public AppWhitelistingGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppWhitelistingGroup class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Location where the resource is
        /// stored</param>
        /// <param name="enforcementMode">Possible values include: 'Audit',
        /// 'Enforce', 'None'</param>
        /// <param name="configurationStatus">Possible values include:
        /// 'Configured', 'NotConfigured', 'InProgress', 'Failed',
        /// 'NoStatus'</param>
        /// <param name="recommendationStatus">Possible values include:
        /// 'Recommended', 'NotRecommended', 'NotAvailable', 'NoStatus'</param>
        /// <param name="sourceSystem">Possible values include:
        /// 'Azure_AppLocker', 'Azure_AuditD', 'NonAzure_AppLocker',
        /// 'NonAzure_AuditD', 'None'</param>
        public AppWhitelistingGroup(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string enforcementMode = default(string), ProtectionMode protectionMode = default(ProtectionMode), string configurationStatus = default(string), string recommendationStatus = default(string), IList<AppWhitelistingIssueSummary> issues = default(IList<AppWhitelistingIssueSummary>), string sourceSystem = default(string), IList<VmRecommendation> vmRecommendations = default(IList<VmRecommendation>), IList<PathRecommendation> pathRecommendations = default(IList<PathRecommendation>))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            EnforcementMode = enforcementMode;
            ProtectionMode = protectionMode;
            ConfigurationStatus = configurationStatus;
            RecommendationStatus = recommendationStatus;
            Issues = issues;
            SourceSystem = sourceSystem;
            VmRecommendations = vmRecommendations;
            PathRecommendations = pathRecommendations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets location where the resource is stored
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets possible values include: 'Audit', 'Enforce', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enforcementMode")]
        public string EnforcementMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.protectionMode")]
        public ProtectionMode ProtectionMode { get; set; }

        /// <summary>
        /// Gets possible values include: 'Configured', 'NotConfigured',
        /// 'InProgress', 'Failed', 'NoStatus'
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationStatus")]
        public string ConfigurationStatus { get; set; }

        /// <summary>
        /// Gets possible values include: 'Recommended', 'NotRecommended',
        /// 'NotAvailable', 'NoStatus'
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendationStatus")]
        public string RecommendationStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.issues")]
        public IList<AppWhitelistingIssueSummary> Issues { get; set; }

        /// <summary>
        /// Gets possible values include: 'Azure_AppLocker', 'Azure_AuditD',
        /// 'NonAzure_AppLocker', 'NonAzure_AuditD', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceSystem")]
        public string SourceSystem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmRecommendations")]
        public IList<VmRecommendation> VmRecommendations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.pathRecommendations")]
        public IList<PathRecommendation> PathRecommendations { get; set; }

    }
}
