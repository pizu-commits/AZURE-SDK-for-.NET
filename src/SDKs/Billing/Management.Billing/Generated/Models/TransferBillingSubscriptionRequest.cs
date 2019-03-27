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
    /// Request parameters to transfer billing subscription.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TransferBillingSubscriptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TransferBillingSubscriptionRequest class.
        /// </summary>
        public TransferBillingSubscriptionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TransferBillingSubscriptionRequest class.
        /// </summary>
        /// <param name="destinationInvoiceSectionName">The destination
        /// invoiceSectionName.</param>
        public TransferBillingSubscriptionRequest(string destinationInvoiceSectionName = default(string))
        {
            DestinationInvoiceSectionName = destinationInvoiceSectionName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the destination invoiceSectionName.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationInvoiceSectionName")]
        public string DestinationInvoiceSectionName { get; set; }

    }
}
