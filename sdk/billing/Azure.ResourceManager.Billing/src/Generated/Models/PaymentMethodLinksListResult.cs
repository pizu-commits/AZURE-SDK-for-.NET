// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The list of payment method links. </summary>
    internal partial class PaymentMethodLinksListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PaymentMethodLinksListResult"/>. </summary>
        internal PaymentMethodLinksListResult()
        {
            Value = new ChangeTrackingList<BillingPaymentMethodLinkData>();
        }

        /// <summary> Initializes a new instance of <see cref="PaymentMethodLinksListResult"/>. </summary>
        /// <param name="value"> The list of payment method links. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PaymentMethodLinksListResult(IReadOnlyList<BillingPaymentMethodLinkData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of payment method links. </summary>
        public IReadOnlyList<BillingPaymentMethodLinkData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
