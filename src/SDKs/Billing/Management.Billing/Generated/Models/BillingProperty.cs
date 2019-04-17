// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A billing property resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingProperty : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingProperty class.
        /// </summary>
        public BillingProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingProperty class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="productId">Product Id.</param>
        /// <param name="billingTenantId">Billing tenant Id.</param>
        /// <param name="billingAccountId">Billing account Id.</param>
        /// <param name="billingAccountName">Billing account name.</param>
        /// <param name="billingProfileId">Billing profile Id.</param>
        /// <param name="billingProfileName">Billing profile name.</param>
        /// <param name="invoiceSectionId">Invoice Section Id.</param>
        /// <param name="invoiceSectionName">Invoice Section name.</param>
        /// <param name="skuId">SKU Id.</param>
        /// <param name="skuDescription">SKU description.</param>
        public BillingProperty(string id = default(string), string name = default(string), string type = default(string), string productId = default(string), string billingTenantId = default(string), string billingAccountId = default(string), string billingAccountName = default(string), string billingProfileId = default(string), string billingProfileName = default(string), string invoiceSectionId = default(string), string invoiceSectionName = default(string), string skuId = default(string), string skuDescription = default(string))
            : base(id, name, type)
        {
            ProductId = productId;
            BillingTenantId = billingTenantId;
            BillingAccountId = billingAccountId;
            BillingAccountName = billingAccountName;
            BillingProfileId = billingProfileId;
            BillingProfileName = billingProfileName;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionName = invoiceSectionName;
            SkuId = skuId;
            SkuDescription = skuDescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets product Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productId")]
        public string ProductId { get; private set; }

        /// <summary>
        /// Gets billing tenant Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingTenantId")]
        public string BillingTenantId { get; private set; }

        /// <summary>
        /// Gets billing account Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAccountId")]
        public string BillingAccountId { get; private set; }

        /// <summary>
        /// Gets billing account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAccountName")]
        public string BillingAccountName { get; private set; }

        /// <summary>
        /// Gets billing profile Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets billing profile name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileName")]
        public string BillingProfileName { get; private set; }

        /// <summary>
        /// Gets invoice Section Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets invoice Section name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionName")]
        public string InvoiceSectionName { get; private set; }

        /// <summary>
        /// Gets SKU Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuId")]
        public string SkuId { get; private set; }

        /// <summary>
        /// Gets SKU description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuDescription")]
        public string SkuDescription { get; private set; }

    }
}
