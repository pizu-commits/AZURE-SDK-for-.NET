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

namespace Azure.ResourceManager.ManagedServices
{
    internal class ManagedServicesRegistrationOperationSource : Core.IOperationSource<ManagedServicesRegistrationResource>
    {
        private readonly ArmClient _client;

        internal ManagedServicesRegistrationOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedServicesRegistrationResource Core.IOperationSource<ManagedServicesRegistrationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedServicesRegistrationData.DeserializeManagedServicesRegistrationData(document.RootElement);
            return new ManagedServicesRegistrationResource(_client, data);
        }

        async ValueTask<ManagedServicesRegistrationResource> Core.IOperationSource<ManagedServicesRegistrationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedServicesRegistrationData.DeserializeManagedServicesRegistrationData(document.RootElement);
            return new ManagedServicesRegistrationResource(_client, data);
        }
    }
}
