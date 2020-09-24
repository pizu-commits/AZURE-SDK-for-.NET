// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Communication
{
    internal class CommunicationServiceCreateOrUpdateHeaders
    {
        private readonly Response _response;
        public CommunicationServiceCreateOrUpdateHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL to query for status of the operation. </summary>
        public string AzureAsyncOperation => _response.Headers.TryGetValue("Azure-AsyncOperation", out string value) ? value : null;
    }
}
