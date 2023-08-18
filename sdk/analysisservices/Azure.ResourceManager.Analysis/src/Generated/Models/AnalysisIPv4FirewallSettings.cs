// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> An array of firewall rules. </summary>
    public partial class AnalysisIPv4FirewallSettings
    {
        /// <summary> Initializes a new instance of AnalysisIPv4FirewallSettings. </summary>
        public AnalysisIPv4FirewallSettings()
        {
            FirewallRules = new Core.ChangeTrackingList<AnalysisIPv4FirewallRule>();
        }

        /// <summary> Initializes a new instance of AnalysisIPv4FirewallSettings. </summary>
        /// <param name="firewallRules"> An array of firewall rules. </param>
        /// <param name="isPowerBIServiceEnabled"> The indicator of enabling PBI service. </param>
        internal AnalysisIPv4FirewallSettings(IList<AnalysisIPv4FirewallRule> firewallRules, bool? isPowerBIServiceEnabled)
        {
            FirewallRules = firewallRules;
            IsPowerBIServiceEnabled = isPowerBIServiceEnabled;
        }

        /// <summary> An array of firewall rules. </summary>
        public IList<AnalysisIPv4FirewallRule> FirewallRules { get; }
        /// <summary> The indicator of enabling PBI service. </summary>
        public bool? IsPowerBIServiceEnabled { get; set; }
    }
}
