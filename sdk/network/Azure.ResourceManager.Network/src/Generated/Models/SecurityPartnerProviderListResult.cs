// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListSecurityPartnerProviders API service call. </summary>
    internal partial class SecurityPartnerProviderListResult
    {
        /// <summary> Initializes a new instance of SecurityPartnerProviderListResult. </summary>
        internal SecurityPartnerProviderListResult()
        {
            Value = new ChangeTrackingList<SecurityPartnerProvider>();
        }

        /// <summary> Initializes a new instance of SecurityPartnerProviderListResult. </summary>
        /// <param name="value"> List of Security Partner Providers in a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal SecurityPartnerProviderListResult(IReadOnlyList<SecurityPartnerProvider> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Security Partner Providers in a resource group. </summary>
        public IReadOnlyList<SecurityPartnerProvider> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
