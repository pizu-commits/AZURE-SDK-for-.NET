// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing the BillingPaymentMethod data model.
    /// A payment method.
    /// </summary>
    public partial class BillingPaymentMethodData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BillingPaymentMethodData"/>. </summary>
        public BillingPaymentMethodData()
        {
            Logos = new ChangeTrackingList<PaymentMethodLogo>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingPaymentMethodData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="family"> The family of payment method. </param>
        /// <param name="paymentMethodType"> The type of payment method. </param>
        /// <param name="accountHolderName"> The account holder name for the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="expiration"> The expiration month and year of the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="lastFourDigits"> Last four digits of payment method. </param>
        /// <param name="displayName"> The display name of the payment method. </param>
        /// <param name="logos"> The list of logos for the payment method. </param>
        /// <param name="status"> Status of the payment method. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingPaymentMethodData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PaymentMethodFamily? family, string paymentMethodType, string accountHolderName, string expiration, string lastFourDigits, string displayName, IList<PaymentMethodLogo> logos, PaymentMethodStatus? status, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Family = family;
            PaymentMethodType = paymentMethodType;
            AccountHolderName = accountHolderName;
            Expiration = expiration;
            LastFourDigits = lastFourDigits;
            DisplayName = displayName;
            Logos = logos;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> The family of payment method. </summary>
        public PaymentMethodFamily? Family { get; set; }
        /// <summary> The type of payment method. </summary>
        public string PaymentMethodType { get; }
        /// <summary> The account holder name for the payment method. This is only supported for payment methods with family CreditCard. </summary>
        public string AccountHolderName { get; }
        /// <summary> The expiration month and year of the payment method. This is only supported for payment methods with family CreditCard. </summary>
        public string Expiration { get; }
        /// <summary> Last four digits of payment method. </summary>
        public string LastFourDigits { get; }
        /// <summary> The display name of the payment method. </summary>
        public string DisplayName { get; }
        /// <summary> The list of logos for the payment method. </summary>
        public IList<PaymentMethodLogo> Logos { get; }
        /// <summary> Status of the payment method. </summary>
        public PaymentMethodStatus? Status { get; set; }
    }
}
