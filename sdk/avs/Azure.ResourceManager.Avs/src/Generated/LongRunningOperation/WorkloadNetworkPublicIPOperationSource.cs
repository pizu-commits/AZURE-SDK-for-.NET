// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    internal class WorkloadNetworkPublicIPOperationSource : Core.IOperationSource<WorkloadNetworkPublicIPResource>
    {
        private readonly ArmClient _client;

        internal WorkloadNetworkPublicIPOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkloadNetworkPublicIPResource Core.IOperationSource<WorkloadNetworkPublicIPResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WorkloadNetworkPublicIPData.DeserializeWorkloadNetworkPublicIPData(document.RootElement);
            return new WorkloadNetworkPublicIPResource(_client, data);
        }

        async ValueTask<WorkloadNetworkPublicIPResource> Core.IOperationSource<WorkloadNetworkPublicIPResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WorkloadNetworkPublicIPData.DeserializeWorkloadNetworkPublicIPData(document.RootElement);
            return new WorkloadNetworkPublicIPResource(_client, data);
        }
    }
}
