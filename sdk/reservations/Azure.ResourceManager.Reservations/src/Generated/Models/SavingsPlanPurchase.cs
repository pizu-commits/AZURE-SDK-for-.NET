// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Request body for savings plan purchase. </summary>
    public partial class SavingsPlanPurchase
    {
        /// <summary> Initializes a new instance of <see cref="SavingsPlanPurchase"/>. </summary>
        public SavingsPlanPurchase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanPurchase"/>. </summary>
        /// <param name="sku"> The name of sku. </param>
        /// <param name="displayName"> Friendly name of the savings plan. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing reservation or savings plan. </param>
        /// <param name="term"> Represent savings plan term in ISO 8601 format. </param>
        /// <param name="billingPlan"> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </param>
        /// <param name="commitment"> Commitment towards the benefit. </param>
        internal SavingsPlanPurchase(ReservationsSkuName sku, string displayName, ResourceIdentifier billingScopeId, SavingsPlanTerm? term, SavingsPlanBillingPlan? billingPlan, AppliedScopeType? appliedScopeType, AppliedScopeProperties appliedScopeProperties, BenefitsCommitment commitment)
        {
            Sku = sku;
            DisplayName = displayName;
            BillingScopeId = billingScopeId;
            Term = term;
            BillingPlan = billingPlan;
            AppliedScopeType = appliedScopeType;
            AppliedScopeProperties = appliedScopeProperties;
            Commitment = commitment;
        }

        /// <summary> The name of sku. </summary>
        internal ReservationsSkuName Sku { get; set; }
        /// <summary> Gets or sets the sku name. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new ReservationsSkuName();
                Sku.Name = value;
            }
        }

        /// <summary> Friendly name of the savings plan. </summary>
        public string DisplayName { get; set; }
        /// <summary> Subscription that will be charged for purchasing reservation or savings plan. </summary>
        public ResourceIdentifier BillingScopeId { get; set; }
        /// <summary> Represent savings plan term in ISO 8601 format. </summary>
        public SavingsPlanTerm? Term { get; set; }
        /// <summary> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </summary>
        public SavingsPlanBillingPlan? BillingPlan { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        public AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </summary>
        public AppliedScopeProperties AppliedScopeProperties { get; set; }
        /// <summary> Commitment towards the benefit. </summary>
        public BenefitsCommitment Commitment { get; set; }
    }
}
