// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Rule condition of type nat. </summary>
    public partial class NatRuleCondition : FirewallPolicyRuleCondition
    {
        /// <summary> Initializes a new instance of NatRuleCondition. </summary>
        public NatRuleCondition()
        {
            IpProtocols = new ChangeTrackingList<FirewallPolicyRuleConditionNetworkProtocol>();
            SourceAddresses = new ChangeTrackingList<string>();
            DestinationAddresses = new ChangeTrackingList<string>();
            DestinationPorts = new ChangeTrackingList<string>();
            SourceIpGroups = new ChangeTrackingList<string>();
            RuleConditionType = FirewallPolicyRuleConditionType.NatRuleCondition;
        }

        /// <summary> Initializes a new instance of NatRuleCondition. </summary>
        /// <param name="name"> Name of the rule condition. </param>
        /// <param name="description"> Description of the rule condition. </param>
        /// <param name="ruleConditionType"> Rule Condition Type. </param>
        /// <param name="ipProtocols"> Array of FirewallPolicyRuleConditionNetworkProtocols. </param>
        /// <param name="sourceAddresses"> List of source IP addresses for this rule. </param>
        /// <param name="destinationAddresses"> List of destination IP addresses or Service Tags. </param>
        /// <param name="destinationPorts"> List of destination ports. </param>
        /// <param name="sourceIpGroups"> List of source IpGroups for this rule. </param>
        /// <param name="terminateTLS"> Terminate TLS connections for this rule. </param>
        internal NatRuleCondition(string name, string description, FirewallPolicyRuleConditionType ruleConditionType, IList<FirewallPolicyRuleConditionNetworkProtocol> ipProtocols, IList<string> sourceAddresses, IList<string> destinationAddresses, IList<string> destinationPorts, IList<string> sourceIpGroups, bool? terminateTLS) : base(name, description, ruleConditionType)
        {
            IpProtocols = ipProtocols;
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            SourceIpGroups = sourceIpGroups;
            TerminateTLS = terminateTLS;
            RuleConditionType = ruleConditionType;
        }

        /// <summary> Array of FirewallPolicyRuleConditionNetworkProtocols. </summary>
        public IList<FirewallPolicyRuleConditionNetworkProtocol> IpProtocols { get; }
        /// <summary> List of source IP addresses for this rule. </summary>
        public IList<string> SourceAddresses { get; }
        /// <summary> List of destination IP addresses or Service Tags. </summary>
        public IList<string> DestinationAddresses { get; }
        /// <summary> List of destination ports. </summary>
        public IList<string> DestinationPorts { get; }
        /// <summary> List of source IpGroups for this rule. </summary>
        public IList<string> SourceIpGroups { get; }
        /// <summary> Terminate TLS connections for this rule. </summary>
        public bool? TerminateTLS { get; set; }
    }
}
