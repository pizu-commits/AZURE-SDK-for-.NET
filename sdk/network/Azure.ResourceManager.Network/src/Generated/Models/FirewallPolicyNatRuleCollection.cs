// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Firewall Policy NAT Rule Collection. </summary>
    public partial class FirewallPolicyNatRuleCollection : FirewallPolicyRuleCollection
    {
        /// <summary> Initializes a new instance of FirewallPolicyNatRuleCollection. </summary>
        public FirewallPolicyNatRuleCollection()
        {
            Rules = new ChangeTrackingList<FirewallPolicyRule>();
            RuleCollectionType = FirewallPolicyRuleCollectionType.FirewallPolicyNatRuleCollection;
        }

        /// <summary> Initializes a new instance of FirewallPolicyNatRuleCollection. </summary>
        /// <param name="ruleCollectionType"> The type of the rule collection. </param>
        /// <param name="name"> The name of the rule collection. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection resource. </param>
        /// <param name="action"> The action type of a Nat rule collection. </param>
        /// <param name="rules"> List of rules included in a rule collection. </param>
        internal FirewallPolicyNatRuleCollection(FirewallPolicyRuleCollectionType ruleCollectionType, string name, int? priority, FirewallPolicyNatRuleCollectionAction action, IList<FirewallPolicyRule> rules) : base(ruleCollectionType, name, priority)
        {
            Action = action;
            Rules = rules;
            RuleCollectionType = ruleCollectionType;
        }

        /// <summary> The action type of a Nat rule collection. </summary>
        internal FirewallPolicyNatRuleCollectionAction Action { get; set; }
        /// <summary> The type of action. </summary>
        public FirewallPolicyNatRuleCollectionActionType? FirewallPolicyNatRuleCollectionActionType
        {
            get => Action is null ? default : Action.FirewallPolicyNatRuleCollectionActionType;
            set
            {
                if (Action is null)
                    Action = new FirewallPolicyNatRuleCollectionAction();
                Action.FirewallPolicyNatRuleCollectionActionType = value;
            }
        }

        /// <summary> List of rules included in a rule collection. </summary>
        public IList<FirewallPolicyRule> Rules { get; }
    }
}
