// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The alert rule resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AlertRuleResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AlertRuleResource class.
        /// </summary>
        public AlertRuleResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertRuleResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="alertRuleResourceName">the name of the alert
        /// rule.</param>
        /// <param name="isEnabled">the flag that indicates whether the alert
        /// rule is enabled.</param>
        /// <param name="condition">the condition that results in the alert
        /// rule being activated.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="kind">Metadata used by portal/tooling/etc to render
        /// different UX experiences for resources of the same type; e.g.
        /// ApiApps are a kind of Microsoft.Web/sites type.  If supported, the
        /// resource provider must validate and persist this value.</param>
        /// <param name="etag">The etag field is *not* required. If it is
        /// provided in the response body, it must also be provided as a header
        /// per the normal etag convention.  Entity tags are used for comparing
        /// two or more entities from the same requested resource. HTTP/1.1
        /// uses entity tags in the etag (section 14.19), If-Match (section
        /// 14.24), If-None-Match (section 14.26), and If-Range (section 14.27)
        /// header fields. </param>
        /// <param name="description">the description of the alert rule that
        /// will be included in the alert email.</param>
        /// <param name="provisioningState">the provisioning state.</param>
        /// <param name="action">action that is performed when the alert rule
        /// becomes active, and when an alert condition is resolved.</param>
        /// <param name="actions">the array of actions that are performed when
        /// the alert rule becomes active, and when an alert condition is
        /// resolved.</param>
        /// <param name="lastUpdatedTime">Last time the rule was updated in
        /// ISO8601 format.</param>
        public AlertRuleResource(string location, string alertRuleResourceName, bool isEnabled, RuleCondition condition, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), string etag = default(string), string description = default(string), string provisioningState = default(string), RuleAction action = default(RuleAction), IList<RuleAction> actions = default(IList<RuleAction>), System.DateTime? lastUpdatedTime = default(System.DateTime?))
            : base(location, id, name, type, tags, kind, etag)
        {
            AlertRuleResourceName = alertRuleResourceName;
            Description = description;
            ProvisioningState = provisioningState;
            IsEnabled = isEnabled;
            Condition = condition;
            Action = action;
            Actions = actions;
            LastUpdatedTime = lastUpdatedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the alert rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string AlertRuleResourceName { get; set; }

        /// <summary>
        /// Gets or sets the description of the alert rule that will be
        /// included in the alert email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether the alert rule is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the condition that results in the alert rule being
        /// activated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.condition")]
        public RuleCondition Condition { get; set; }

        /// <summary>
        /// Gets or sets action that is performed when the alert rule becomes
        /// active, and when an alert condition is resolved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.action")]
        public RuleAction Action { get; set; }

        /// <summary>
        /// Gets or sets the array of actions that are performed when the alert
        /// rule becomes active, and when an alert condition is resolved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<RuleAction> Actions { get; set; }

        /// <summary>
        /// Gets last time the rule was updated in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (AlertRuleResourceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AlertRuleResourceName");
            }
            if (Condition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Condition");
            }
        }
    }
}
