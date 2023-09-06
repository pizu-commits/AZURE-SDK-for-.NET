// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Savings plan patch request. </summary>
    public partial class BillingBenefitsSavingsPlanPatchProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanPatchProperties"/>. </summary>
        public BillingBenefitsSavingsPlanPatchProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanPatchProperties"/>. </summary>
        /// <param name="displayName"> Display name. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. </param>
        /// <param name="isRenewed"> Setting this to true will automatically purchase a new benefit on the expiration date time. </param>
        /// <param name="renewProperties"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingBenefitsSavingsPlanPatchProperties(string displayName, BillingBenefitsAppliedScopeType? appliedScopeType, BillingBenefitsAppliedScopeProperties appliedScopeProperties, bool? isRenewed, RenewProperties renewProperties, Dictionary<string, BinaryData> rawData)
        {
            DisplayName = displayName;
            AppliedScopeType = appliedScopeType;
            AppliedScopeProperties = appliedScopeProperties;
            IsRenewed = isRenewed;
            RenewProperties = renewProperties;
            _rawData = rawData;
        }

        /// <summary> Display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        public BillingBenefitsAppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. </summary>
        public BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get; set; }
        /// <summary> Setting this to true will automatically purchase a new benefit on the expiration date time. </summary>
        public bool? IsRenewed { get; set; }
        /// <summary> Gets or sets the renew properties. </summary>
        internal RenewProperties RenewProperties { get; set; }
        /// <summary> Gets or sets the renew purchase properties. </summary>
        public BillingBenefitsPurchaseContent RenewPurchaseProperties
        {
            get => RenewProperties is null ? default : RenewProperties.PurchaseProperties;
            set
            {
                if (RenewProperties is null)
                    RenewProperties = new RenewProperties();
                RenewProperties.PurchaseProperties = value;
            }
        }
    }
}
