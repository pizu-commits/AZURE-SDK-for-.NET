// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> A credit summary resource. </summary>
    public partial class ConsumptionCreditSummary : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConsumptionCreditSummary"/>. </summary>
        public ConsumptionCreditSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionCreditSummary"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="balanceSummary"> Summary of balances associated with this credit summary. </param>
        /// <param name="pendingCreditAdjustments"> Pending credit adjustments. </param>
        /// <param name="expiredCredit"> Expired credit. </param>
        /// <param name="pendingEligibleCharges"> Pending eligible charges. </param>
        /// <param name="creditCurrency"> The credit currency. </param>
        /// <param name="billingCurrency"> The billing currency. </param>
        /// <param name="reseller"> Credit's reseller. </param>
        /// <param name="etag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionCreditSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CreditBalanceSummary balanceSummary, ConsumptionAmount pendingCreditAdjustments, ConsumptionAmount expiredCredit, ConsumptionAmount pendingEligibleCharges, string creditCurrency, string billingCurrency, ConsumptionReseller reseller, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            BalanceSummary = balanceSummary;
            PendingCreditAdjustments = pendingCreditAdjustments;
            ExpiredCredit = expiredCredit;
            PendingEligibleCharges = pendingEligibleCharges;
            CreditCurrency = creditCurrency;
            BillingCurrency = billingCurrency;
            Reseller = reseller;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Summary of balances associated with this credit summary. </summary>
        public CreditBalanceSummary BalanceSummary { get; }
        /// <summary> Pending credit adjustments. </summary>
        public ConsumptionAmount PendingCreditAdjustments { get; }
        /// <summary> Expired credit. </summary>
        public ConsumptionAmount ExpiredCredit { get; }
        /// <summary> Pending eligible charges. </summary>
        public ConsumptionAmount PendingEligibleCharges { get; }
        /// <summary> The credit currency. </summary>
        public string CreditCurrency { get; }
        /// <summary> The billing currency. </summary>
        public string BillingCurrency { get; }
        /// <summary> Credit's reseller. </summary>
        public ConsumptionReseller Reseller { get; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}
