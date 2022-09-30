// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A web application firewall rule set.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayFirewallRuleSet : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayFirewallRuleSet
        /// class.
        /// </summary>
        public ApplicationGatewayFirewallRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayFirewallRuleSet
        /// class.
        /// </summary>
        /// <param name="ruleSetType">The type of the web application firewall
        /// rule set.</param>
        /// <param name="ruleSetVersion">The version of the web application
        /// firewall rule set type.</param>
        /// <param name="ruleGroups">The rule groups of the web application
        /// firewall rule set.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="provisioningState">The provisioning state of the web
        /// application firewall rule set. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="tiers">Tier of an application gateway that support the
        /// rule set.</param>
        public ApplicationGatewayFirewallRuleSet(string ruleSetType, string ruleSetVersion, IList<ApplicationGatewayFirewallRuleGroup> ruleGroups, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), IList<string> tiers = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = ruleGroups;
            Tiers = tiers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the web application firewall rule
        /// set. Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the type of the web application firewall rule set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleSetType")]
        public string RuleSetType { get; set; }

        /// <summary>
        /// Gets or sets the version of the web application firewall rule set
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleSetVersion")]
        public string RuleSetVersion { get; set; }

        /// <summary>
        /// Gets or sets the rule groups of the web application firewall rule
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleGroups")]
        public IList<ApplicationGatewayFirewallRuleGroup> RuleGroups { get; set; }

        /// <summary>
        /// Gets or sets tier of an application gateway that support the rule
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tiers")]
        public IList<string> Tiers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RuleSetType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetType");
            }
            if (RuleSetVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetVersion");
            }
            if (RuleGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleGroups");
            }
            if (RuleGroups != null)
            {
                foreach (var element in RuleGroups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
