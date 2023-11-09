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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupDefinition"/>. </summary>
        internal ManagedRuleGroupDefinition()
        {
            Rules = new ChangeTrackingList<ManagedRuleDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupDefinition"/>. </summary>
        /// <param name="ruleGroupName"> Name of the managed rule group. </param>
        /// <param name="description"> Description of the managed rule group. </param>
        /// <param name="rules"> List of rules within the managed rule group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleGroupDefinition(string ruleGroupName, string description, IReadOnlyList<ManagedRuleDefinition> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuleGroupName = ruleGroupName;
            Description = description;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the managed rule group. </summary>
        public string RuleGroupName { get; }
        /// <summary> Description of the managed rule group. </summary>
        public string Description { get; }
        /// <summary> List of rules within the managed rule group. </summary>
        public IReadOnlyList<ManagedRuleDefinition> Rules { get; }
    }
}
