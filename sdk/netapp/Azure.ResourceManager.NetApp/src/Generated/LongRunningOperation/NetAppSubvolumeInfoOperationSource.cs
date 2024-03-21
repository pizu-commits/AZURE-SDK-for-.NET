// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NetApp
{
    internal class NetAppSubvolumeInfoOperationSource : IOperationSource<NetAppSubvolumeInfoResource>
    {
        private readonly ArmClient _client;

        internal NetAppSubvolumeInfoOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetAppSubvolumeInfoResource IOperationSource<NetAppSubvolumeInfoResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetAppSubvolumeInfoData.DeserializeNetAppSubvolumeInfoData(document.RootElement);
            return new NetAppSubvolumeInfoResource(_client, data);
        }

        async ValueTask<NetAppSubvolumeInfoResource> IOperationSource<NetAppSubvolumeInfoResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetAppSubvolumeInfoData.DeserializeNetAppSubvolumeInfoData(document.RootElement);
            return new NetAppSubvolumeInfoResource(_client, data);
        }
    }
}
