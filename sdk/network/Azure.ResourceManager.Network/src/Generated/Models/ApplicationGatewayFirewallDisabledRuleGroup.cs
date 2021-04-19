// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allows to disable rules within a rule group or an entire rule group. </summary>
    public partial class ApplicationGatewayFirewallDisabledRuleGroup
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFirewallDisabledRuleGroup. </summary>
        /// <param name="ruleGroupName"> The name of the rule group that will be disabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleGroupName"/> is null. </exception>
        public ApplicationGatewayFirewallDisabledRuleGroup(string ruleGroupName)
        {
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            RuleGroupName = ruleGroupName;
            Rules = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayFirewallDisabledRuleGroup. </summary>
        /// <param name="ruleGroupName"> The name of the rule group that will be disabled. </param>
        /// <param name="rules"> The list of rules that will be disabled. If null, all rules of the rule group will be disabled. </param>
        internal ApplicationGatewayFirewallDisabledRuleGroup(string ruleGroupName, IList<int> rules)
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
        }

        /// <summary> The name of the rule group that will be disabled. </summary>
        public string RuleGroupName { get; set; }
        /// <summary> The list of rules that will be disabled. If null, all rules of the rule group will be disabled. </summary>
        public IList<int> Rules { get; }
    }
}
