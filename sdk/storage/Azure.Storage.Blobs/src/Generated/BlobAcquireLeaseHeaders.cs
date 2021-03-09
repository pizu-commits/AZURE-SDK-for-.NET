// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Blobs
{
    internal partial class BlobAcquireLeaseHeaders
    {
        private readonly Response _response;
        public BlobAcquireLeaseHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the blob was last modified. Any operation that modifies the blob, including an update of the blob&apos;s metadata or properties, changes the last-modified time of the blob. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Uniquely identifies a blobs&apos;s lease. </summary>
        public string LeaseId => _response.Headers.TryGetValue("x-ms-lease-id", out string value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
