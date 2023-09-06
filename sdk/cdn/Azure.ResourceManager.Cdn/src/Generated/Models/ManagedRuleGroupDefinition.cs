// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes a managed rule group. </summary>
    public partial class ManagedRuleGroupDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupDefinition"/>. </summary>
        internal ManagedRuleGroupDefinition()
        {
            Rules = new ChangeTrackingList<ManagedRuleDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupDefinition"/>. </summary>
        /// <param name="ruleGroupName"> Name of the managed rule group. </param>
        /// <param name="description"> Description of the managed rule group. </param>
        /// <param name="rules"> List of rules within the managed rule group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleGroupDefinition(string ruleGroupName, string description, IReadOnlyList<ManagedRuleDefinition> rules, Dictionary<string, BinaryData> rawData)
        {
            RuleGroupName = ruleGroupName;
            Description = description;
            Rules = rules;
            _rawData = rawData;
        }

        /// <summary> Name of the managed rule group. </summary>
        public string RuleGroupName { get; }
        /// <summary> Description of the managed rule group. </summary>
        public string Description { get; }
        /// <summary> List of rules within the managed rule group. </summary>
        public IReadOnlyList<ManagedRuleDefinition> Rules { get; }
    }
}
