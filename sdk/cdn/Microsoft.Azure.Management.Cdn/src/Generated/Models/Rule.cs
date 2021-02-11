// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Friendly Rules name mapping to the any Rules or secret related
    /// information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Rule : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Rule class.
        /// </summary>
        public Rule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Rule class.
        /// </summary>
        /// <param name="order">The order in which the rules are applied for
        /// the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser
        /// order will be applied before a rule with a greater order. Rule with
        /// order 0 is a special rule. It does not require any condition and
        /// actions listed in it will always be applied.</param>
        /// <param name="actions">A list of actions that are executed when all
        /// the conditions of a rule are satisfied.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="conditions">A list of conditions that must be matched
        /// for the actions to be executed</param>
        /// <param name="matchProcessingBehavior">If this rule is a match
        /// should the rules engine continue running the remaining rules or
        /// stop. If not present, defaults to Continue. Possible values
        /// include: 'Continue', 'Stop'</param>
        /// <param name="provisioningState">Provisioning status. Possible
        /// values include: 'Succeeded', 'Failed', 'Updating', 'Deleting',
        /// 'Creating'</param>
        /// <param name="deploymentStatus">Possible values include:
        /// 'NotStarted', 'InProgress', 'Succeeded', 'Failed'</param>
        public Rule(int order, IList<DeliveryRuleAction> actions, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IList<DeliveryRuleCondition> conditions = default(IList<DeliveryRuleCondition>), string matchProcessingBehavior = default(string), string provisioningState = default(string), string deploymentStatus = default(string))
            : base(id, name, type, systemData)
        {
            Order = order;
            Conditions = conditions;
            Actions = actions;
            MatchProcessingBehavior = matchProcessingBehavior;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the order in which the rules are applied for the
        /// endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order
        /// will be applied before a rule with a greater order. Rule with order
        /// 0 is a special rule. It does not require any condition and actions
        /// listed in it will always be applied.
        /// </summary>
        [JsonProperty(PropertyName = "properties.order")]
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets a list of conditions that must be matched for the
        /// actions to be executed
        /// </summary>
        [JsonProperty(PropertyName = "properties.conditions")]
        public IList<DeliveryRuleCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets a list of actions that are executed when all the
        /// conditions of a rule are satisfied.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<DeliveryRuleAction> Actions { get; set; }

        /// <summary>
        /// Gets or sets if this rule is a match should the rules engine
        /// continue running the remaining rules or stop. If not present,
        /// defaults to Continue. Possible values include: 'Continue', 'Stop'
        /// </summary>
        [JsonProperty(PropertyName = "properties.matchProcessingBehavior")]
        public string MatchProcessingBehavior { get; set; }

        /// <summary>
        /// Gets provisioning status. Possible values include: 'Succeeded',
        /// 'Failed', 'Updating', 'Deleting', 'Creating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets possible values include: 'NotStarted', 'InProgress',
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentStatus")]
        public string DeploymentStatus { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Actions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Actions");
            }
        }
    }
}
