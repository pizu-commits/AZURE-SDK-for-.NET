// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Workloads
{
    internal class SapCentralServerInstanceOperationSource : IOperationSource<SapCentralServerInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapCentralServerInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapCentralServerInstanceResource IOperationSource<SapCentralServerInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SapCentralServerInstanceData.DeserializeSapCentralServerInstanceData(document.RootElement);
            return new SapCentralServerInstanceResource(_client, data);
        }

        async ValueTask<SapCentralServerInstanceResource> IOperationSource<SapCentralServerInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SapCentralServerInstanceData.DeserializeSapCentralServerInstanceData(document.RootElement);
            return new SapCentralServerInstanceResource(_client, data);
        }
    }
}
