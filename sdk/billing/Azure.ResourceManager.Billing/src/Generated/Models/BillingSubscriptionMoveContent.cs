// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Request parameters to transfer billing subscription. </summary>
    public partial class BillingSubscriptionMoveContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionMoveContent"/>. </summary>
        public BillingSubscriptionMoveContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionMoveContent"/>. </summary>
        /// <param name="destinationEnrollmentAccountId"> The destination enrollment account id. </param>
        /// <param name="destinationInvoiceSectionId"> The destination invoice section id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingSubscriptionMoveContent(string destinationEnrollmentAccountId, ResourceIdentifier destinationInvoiceSectionId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DestinationEnrollmentAccountId = destinationEnrollmentAccountId;
            DestinationInvoiceSectionId = destinationInvoiceSectionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The destination enrollment account id. </summary>
        public string DestinationEnrollmentAccountId { get; set; }
        /// <summary> The destination invoice section id. </summary>
        public ResourceIdentifier DestinationInvoiceSectionId { get; set; }
    }
}
