// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The TenantResourceGetBillingBenefitsSavingsPlansOptions. </summary>
    public partial class TenantResourceGetBillingBenefitsSavingsPlansOptions
    {
        /// <summary> Initializes a new instance of <see cref="TenantResourceGetBillingBenefitsSavingsPlansOptions"/>. </summary>
        public TenantResourceGetBillingBenefitsSavingsPlansOptions()
        {
        }

        /// <summary> May be used to filter by reservation properties. The filter supports 'eq', 'or', and 'and'. It does not currently support 'ne', 'gt', 'le', 'ge', or 'not'. Reservation properties include sku/name, properties/{appliedScopeType, archived, displayName, displayProvisioningState, effectiveDateTime, expiryDate, provisioningState, quantity, renew, reservedResourceType, term, userFriendlyAppliedScopeType, userFriendlyRenewState}. </summary>
        public string Filter { get; set; }
        /// <summary> May be used to sort order by reservation properties. </summary>
        public string OrderBy { get; set; }
        /// <summary> To indicate whether to refresh the roll up counts of the savings plans group by provisioning states. </summary>
        public string RefreshSummary { get; set; }
        /// <summary> The number of savings plans to skip from the list before returning results. </summary>
        public float? SkipToken { get; set; }
        /// <summary> The selected provisioning state. </summary>
        public string SelectedState { get; set; }
        /// <summary> To number of savings plans to return. </summary>
        public float? Take { get; set; }
    }
}
