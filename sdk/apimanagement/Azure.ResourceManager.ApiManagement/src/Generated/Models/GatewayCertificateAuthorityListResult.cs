// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Gateway certificate authority list representation. </summary>
    internal partial class GatewayCertificateAuthorityListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GatewayCertificateAuthorityListResult"/>. </summary>
        internal GatewayCertificateAuthorityListResult()
        {
            Value = new ChangeTrackingList<ApiManagementGatewayCertificateAuthorityData>();
        }

        /// <summary> Initializes a new instance of <see cref="GatewayCertificateAuthorityListResult"/>. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GatewayCertificateAuthorityListResult(IReadOnlyList<ApiManagementGatewayCertificateAuthorityData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<ApiManagementGatewayCertificateAuthorityData> Value { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
