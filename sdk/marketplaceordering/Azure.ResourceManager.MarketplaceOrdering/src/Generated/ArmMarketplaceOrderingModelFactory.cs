// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.MarketplaceOrdering;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MarketplaceOrdering.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMarketplaceOrderingModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="MarketplaceAgreementTermData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publisher"> Publisher identifier string of image being deployed. </param>
        /// <param name="product"> Offer identifier string of image being deployed. </param>
        /// <param name="plan"> Plan identifier string of image being deployed. </param>
        /// <param name="licenseTextLink"> Link to HTML with Microsoft and Publisher terms. </param>
        /// <param name="privacyPolicyLink"> Link to the privacy policy of the publisher. </param>
        /// <param name="marketplaceTermsLink"> Link to HTML with Azure Marketplace terms. </param>
        /// <param name="retrievedOn"> Date and time in UTC of when the terms were accepted. This is empty if Accepted is false. </param>
        /// <param name="signature"> Terms signature. </param>
        /// <param name="isAccepted"> If any version of the terms have been accepted, otherwise false. </param>
        /// <returns> A new <see cref="MarketplaceOrdering.MarketplaceAgreementTermData"/> instance for mocking. </returns>
        public static MarketplaceAgreementTermData MarketplaceAgreementTermData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string publisher = null, string product = null, string plan = null, Uri licenseTextLink = null, Uri privacyPolicyLink = null, Uri marketplaceTermsLink = null, DateTimeOffset? retrievedOn = null, string signature = null, bool? isAccepted = null)
        {
            return new MarketplaceAgreementTermData(id, name, resourceType, systemData, publisher, product, plan, licenseTextLink, privacyPolicyLink, marketplaceTermsLink, retrievedOn, signature, isAccepted, default);
        }
    }
}
