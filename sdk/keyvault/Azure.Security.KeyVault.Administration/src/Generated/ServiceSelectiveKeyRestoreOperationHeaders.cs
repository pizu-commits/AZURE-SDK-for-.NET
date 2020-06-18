// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    internal class ServiceSelectiveKeyRestoreOperationHeaders
    {
        private readonly Response _response;
        public ServiceSelectiveKeyRestoreOperationHeaders(Response response)
        {
            _response = response;
        }
        public int? RetryAfter => _response.Headers.TryGetValue("Retry-After", out int? value) ? value : null;
        public string AzureAsyncOperation => _response.Headers.TryGetValue("Azure-AsyncOperation", out string value) ? value : null;
    }
}
