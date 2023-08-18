// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Properties that define a ProactiveDetection configuration. </summary>
    public partial class ApplicationInsightsComponentProactiveDetectionConfiguration
    {
        /// <summary> Initializes a new instance of ApplicationInsightsComponentProactiveDetectionConfiguration. </summary>
        public ApplicationInsightsComponentProactiveDetectionConfiguration()
        {
            CustomEmails = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentProactiveDetectionConfiguration. </summary>
        /// <param name="name"> The rule name. </param>
        /// <param name="isEnabled"> A flag that indicates whether this rule is enabled by the user. </param>
        /// <param name="sendEmailsToSubscriptionOwners"> A flag that indicated whether notifications on this rule should be sent to subscription owners. </param>
        /// <param name="customEmails"> Custom email addresses for this rule notifications. </param>
        /// <param name="lastUpdatedTime"> The last time this rule was updated. </param>
        /// <param name="ruleDefinitions"> Static definitions of the ProactiveDetection configuration rule (same values for all components). </param>
        internal ApplicationInsightsComponentProactiveDetectionConfiguration(string name, bool? isEnabled, bool? sendEmailsToSubscriptionOwners, IList<string> customEmails, string lastUpdatedTime, ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions ruleDefinitions)
        {
            Name = name;
            IsEnabled = isEnabled;
            SendEmailsToSubscriptionOwners = sendEmailsToSubscriptionOwners;
            CustomEmails = customEmails;
            LastUpdatedTime = lastUpdatedTime;
            RuleDefinitions = ruleDefinitions;
        }

        /// <summary> The rule name. </summary>
        public string Name { get; set; }
        /// <summary> A flag that indicates whether this rule is enabled by the user. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> A flag that indicated whether notifications on this rule should be sent to subscription owners. </summary>
        public bool? SendEmailsToSubscriptionOwners { get; set; }
        /// <summary> Custom email addresses for this rule notifications. </summary>
        public IList<string> CustomEmails { get; }
        /// <summary> The last time this rule was updated. </summary>
        public string LastUpdatedTime { get; set; }
        /// <summary> Static definitions of the ProactiveDetection configuration rule (same values for all components). </summary>
        public ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions RuleDefinitions { get; set; }
    }
}
