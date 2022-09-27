// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Elastic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Elastic
{
    /// <summary> A class representing the MonitoringTagRule data model. </summary>
    public partial class MonitoringTagRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of MonitoringTagRuleData. </summary>
        public MonitoringTagRuleData()
        {
        }

        /// <summary> Initializes a new instance of MonitoringTagRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the monitoring tag rules. </param>
        internal MonitoringTagRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MonitoringTagRulesProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the monitoring tag rules. </summary>
        public MonitoringTagRulesProperties Properties { get; set; }
    }
}
