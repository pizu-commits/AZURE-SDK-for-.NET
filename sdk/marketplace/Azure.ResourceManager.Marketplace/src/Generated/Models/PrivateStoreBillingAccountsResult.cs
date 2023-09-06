// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Billing accounts response object. </summary>
    public partial class PrivateStoreBillingAccountsResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateStoreBillingAccountsResult"/>. </summary>
        internal PrivateStoreBillingAccountsResult()
        {
            BillingAccounts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateStoreBillingAccountsResult"/>. </summary>
        /// <param name="billingAccounts"> Billing accounts list. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateStoreBillingAccountsResult(IReadOnlyList<string> billingAccounts, Dictionary<string, BinaryData> rawData)
        {
            BillingAccounts = billingAccounts;
            _rawData = rawData;
        }

        /// <summary> Billing accounts list. </summary>
        public IReadOnlyList<string> BillingAccounts { get; }
    }
}
