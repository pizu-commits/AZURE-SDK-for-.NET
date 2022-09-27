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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal class JobOperationSource : IOperationSource<JobResource>
    {
        private readonly ArmClient _client;

        internal JobOperationSource(ArmClient client)
        {
            _client = client;
        }

        JobResource IOperationSource<JobResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = JobData.DeserializeJobData(document.RootElement);
            return new JobResource(_client, data);
        }

        async ValueTask<JobResource> IOperationSource<JobResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = JobData.DeserializeJobData(document.RootElement);
            return new JobResource(_client, data);
        }
    }
}
