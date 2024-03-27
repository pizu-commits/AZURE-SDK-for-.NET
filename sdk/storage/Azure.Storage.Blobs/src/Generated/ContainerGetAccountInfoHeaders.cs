// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.Storage.Blobs.Models;

namespace Azure.Storage.Blobs
{
    internal partial class ContainerGetAccountInfoHeaders
    {
        private readonly Response _response;
        public ContainerGetAccountInfoHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> Identifies the sku name of the account. </summary>
        public SkuName? SkuName => _response.Headers.TryGetValue("x-ms-sku-name", out string value) ? value.ToSkuName() : null;
        /// <summary> Identifies the account kind. </summary>
        public AccountKind? AccountKind => _response.Headers.TryGetValue("x-ms-account-kind", out string value) ? value.ToAccountKind() : null;
        /// <summary> Version 2019-07-07 and newer. Indicates if the account has a hierarchical namespace enabled. </summary>
        public bool? IsHierarchicalNamespaceEnabled => _response.Headers.TryGetValue("x-ms-is-hns-enabled", out bool? value) ? value : null;
    }
}
