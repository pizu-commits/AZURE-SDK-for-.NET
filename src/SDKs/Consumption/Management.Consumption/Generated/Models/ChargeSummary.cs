// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A charge summary resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ChargeSummary : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ChargeSummary class.
        /// </summary>
        public ChargeSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChargeSummary class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="billingPeriodId">The id of the billing period resource
        /// that the charge belongs to.</param>
        /// <param name="usageStart">Usage start date.</param>
        /// <param name="usageEnd"> Usage end date.</param>
        /// <param name="azureCharges">Azure Charges.</param>
        /// <param name="chargesBilledSeparately">Charges Billed
        /// separately.</param>
        /// <param name="marketplaceCharges">Marketplace Charges.</param>
        /// <param name="currency">Currency Code</param>
        public ChargeSummary(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string billingPeriodId = default(string), string usageStart = default(string), string usageEnd = default(string), decimal? azureCharges = default(decimal?), decimal? chargesBilledSeparately = default(decimal?), decimal? marketplaceCharges = default(decimal?), string currency = default(string))
            : base(id, name, type, tags)
        {
            BillingPeriodId = billingPeriodId;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            AzureCharges = azureCharges;
            ChargesBilledSeparately = chargesBilledSeparately;
            MarketplaceCharges = marketplaceCharges;
            Currency = currency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the billing period resource that the charge belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodId")]
        public string BillingPeriodId { get; private set; }

        /// <summary>
        /// Gets usage start date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageStart")]
        public string UsageStart { get; private set; }

        /// <summary>
        /// Gets  Usage end date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageEnd")]
        public string UsageEnd { get; private set; }

        /// <summary>
        /// Gets azure Charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureCharges")]
        public decimal? AzureCharges { get; private set; }

        /// <summary>
        /// Gets charges Billed separately.
        /// </summary>
        [JsonProperty(PropertyName = "properties.chargesBilledSeparately")]
        public decimal? ChargesBilledSeparately { get; private set; }

        /// <summary>
        /// Gets marketplace Charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplaceCharges")]
        public decimal? MarketplaceCharges { get; private set; }

        /// <summary>
        /// Gets currency Code
        /// </summary>
        [JsonProperty(PropertyName = "properties.currency")]
        public string Currency { get; private set; }

    }
}
