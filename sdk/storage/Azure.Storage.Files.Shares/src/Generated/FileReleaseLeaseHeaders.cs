// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Storage.Files.Shares
{
    internal partial class FileReleaseLeaseHeaders
    {
        private readonly Response _response;
        public FileReleaseLeaseHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the file was last modified. Any operation that modifies the file, including an update of the file's metadata or properties, changes the last-modified time of the file. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
