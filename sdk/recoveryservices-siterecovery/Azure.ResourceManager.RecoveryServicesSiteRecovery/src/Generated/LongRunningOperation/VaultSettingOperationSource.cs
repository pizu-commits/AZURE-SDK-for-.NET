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
    internal class VaultSettingOperationSource : IOperationSource<VaultSettingResource>
    {
        private readonly ArmClient _client;

        internal VaultSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        VaultSettingResource IOperationSource<VaultSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VaultSettingData.DeserializeVaultSettingData(document.RootElement);
            return new VaultSettingResource(_client, data);
        }

        async ValueTask<VaultSettingResource> IOperationSource<VaultSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VaultSettingData.DeserializeVaultSettingData(document.RootElement);
            return new VaultSettingResource(_client, data);
        }
    }
}
