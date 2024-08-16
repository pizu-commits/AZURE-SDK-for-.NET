// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    internal class AppComplianceDownloadResultOperationSource : IOperationSource<AppComplianceDownloadResult>
    {
        AppComplianceDownloadResult IOperationSource<AppComplianceDownloadResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return AppComplianceDownloadResult.DeserializeAppComplianceDownloadResult(document.RootElement);
        }

        async ValueTask<AppComplianceDownloadResult> IOperationSource<AppComplianceDownloadResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return AppComplianceDownloadResult.DeserializeAppComplianceDownloadResult(document.RootElement);
        }
    }
}
