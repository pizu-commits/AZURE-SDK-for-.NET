// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list domains. It contains a list of domain objects and a URL link to get the next set of results. </summary>
    internal partial class FrontDoorCustomDomainListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainListResult"/>. </summary>
        internal FrontDoorCustomDomainListResult()
        {
            Value = new ChangeTrackingList<FrontDoorCustomDomainData>();
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainListResult"/>. </summary>
        /// <param name="value"> List of AzureFrontDoor domains within a profile. </param>
        /// <param name="nextLink"> URL to get the next set of domain objects if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorCustomDomainListResult(IReadOnlyList<FrontDoorCustomDomainData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of AzureFrontDoor domains within a profile. </summary>
        public IReadOnlyList<FrontDoorCustomDomainData> Value { get; }
        /// <summary> URL to get the next set of domain objects if there are any. </summary>
        public string NextLink { get; }
    }
}
