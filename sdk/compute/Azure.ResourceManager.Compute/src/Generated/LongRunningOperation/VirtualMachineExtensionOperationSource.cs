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

namespace Azure.ResourceManager.Compute
{
    internal class VirtualMachineExtensionOperationSource : IOperationSource<VirtualMachineExtensionResource>
    {
        private readonly ArmClient _client;

        internal VirtualMachineExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualMachineExtensionResource IOperationSource<VirtualMachineExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement);
            return new VirtualMachineExtensionResource(_client, data);
        }

        async ValueTask<VirtualMachineExtensionResource> IOperationSource<VirtualMachineExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement);
            return new VirtualMachineExtensionResource(_client, data);
        }
    }
}
