// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningFeatureSetJobOperationSource : IOperationSource<MachineLearningFeatureSetJob>
    {
        MachineLearningFeatureSetJob IOperationSource<MachineLearningFeatureSetJob>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return MachineLearningFeatureSetJob.DeserializeMachineLearningFeatureSetJob(document.RootElement);
        }

        async ValueTask<MachineLearningFeatureSetJob> IOperationSource<MachineLearningFeatureSetJob>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return MachineLearningFeatureSetJob.DeserializeMachineLearningFeatureSetJob(document.RootElement);
        }
    }
}
