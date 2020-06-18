// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal class DataFlowDebugSessionExecuteCommandHeaders
    {
        private readonly Response _response;
        public DataFlowDebugSessionExecuteCommandHeaders(Response response)
        {
            _response = response;
        }
        public string Location => _response.Headers.TryGetValue("location", out string value) ? value : null;
    }
}
