// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary>
    /// A class representing the BillingBenefitsSavingsPlanOrderAlias data model.
    /// Savings plan order alias
    /// </summary>
    public partial class BillingBenefitsSavingsPlanOrderAliasData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanOrderAliasData"/>. </summary>
        /// <param name="sku"> Savings plan SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public BillingBenefitsSavingsPlanOrderAliasData(BillingBenefitsSku sku)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanOrderAliasData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Savings plan SKU. </param>
        /// <param name="kind"> Resource provider kind. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="savingsPlanOrderId"> Identifier of the savings plan created. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing the benefit. </param>
        /// <param name="term"> Represent benefit term in ISO 8601 format. </param>
        /// <param name="billingPlan"> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. </param>
        /// <param name="commitment"> Commitment towards the benefit. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingBenefitsSavingsPlanOrderAliasData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BillingBenefitsSku sku, string kind, string displayName, ResourceIdentifier savingsPlanOrderId, BillingBenefitsProvisioningState? provisioningState, ResourceIdentifier billingScopeId, BillingBenefitsTerm? term, BillingBenefitsBillingPlan? billingPlan, BillingBenefitsAppliedScopeType? appliedScopeType, BillingBenefitsAppliedScopeProperties appliedScopeProperties, BillingBenefitsCommitment commitment, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Kind = kind;
            DisplayName = displayName;
            SavingsPlanOrderId = savingsPlanOrderId;
            ProvisioningState = provisioningState;
            BillingScopeId = billingScopeId;
            Term = term;
            BillingPlan = billingPlan;
            AppliedScopeType = appliedScopeType;
            AppliedScopeProperties = appliedScopeProperties;
            Commitment = commitment;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanOrderAliasData"/> for deserialization. </summary>
        internal BillingBenefitsSavingsPlanOrderAliasData()
        {
        }

        /// <summary> Savings plan SKU. </summary>
        internal BillingBenefitsSku Sku { get; set; }
        /// <summary> Name of the SKU to be applied. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new BillingBenefitsSku();
                Sku.Name = value;
            }
        }

        /// <summary> Resource provider kind. </summary>
        public string Kind { get; set; }
        /// <summary> Display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Identifier of the savings plan created. </summary>
        public ResourceIdentifier SavingsPlanOrderId { get; }
        /// <summary> Provisioning state. </summary>
        public BillingBenefitsProvisioningState? ProvisioningState { get; }
        /// <summary> Subscription that will be charged for purchasing the benefit. </summary>
        public ResourceIdentifier BillingScopeId { get; set; }
        /// <summary> Represent benefit term in ISO 8601 format. </summary>
        public BillingBenefitsTerm? Term { get; set; }
        /// <summary> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </summary>
        public BillingBenefitsBillingPlan? BillingPlan { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        public BillingBenefitsAppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. </summary>
        public BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get; set; }
        /// <summary> Commitment towards the benefit. </summary>
        public BillingBenefitsCommitment Commitment { get; set; }
    }
}
