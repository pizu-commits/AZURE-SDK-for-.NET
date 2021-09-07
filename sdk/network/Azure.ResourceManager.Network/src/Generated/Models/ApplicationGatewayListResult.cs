// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListApplicationGateways API service call. </summary>
    internal partial class ApplicationGatewayListResult
    {
        /// <summary> Initializes a new instance of ApplicationGatewayListResult. </summary>
        internal ApplicationGatewayListResult()
        {
            Value = new ChangeTrackingList<ApplicationGatewayData>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayListResult. </summary>
        /// <param name="value"> List of an application gateways in a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal ApplicationGatewayListResult(IReadOnlyList<ApplicationGatewayData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of an application gateways in a resource group. </summary>
        public IReadOnlyList<ApplicationGatewayData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
