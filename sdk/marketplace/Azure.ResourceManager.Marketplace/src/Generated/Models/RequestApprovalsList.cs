// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> List of admin request approval resources. </summary>
    internal partial class RequestApprovalsList
    {
        /// <summary> Initializes a new instance of <see cref="RequestApprovalsList"/>. </summary>
        internal RequestApprovalsList()
        {
            Value = new ChangeTrackingList<MarketplaceApprovalRequestData>();
        }

        /// <summary> Initializes a new instance of <see cref="RequestApprovalsList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of notifications list results if there are any. </param>
        internal RequestApprovalsList(IReadOnlyList<MarketplaceApprovalRequestData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<MarketplaceApprovalRequestData> Value { get; }
        /// <summary> URL to get the next set of notifications list results if there are any. </summary>
        public string NextLink { get; }
    }
}
