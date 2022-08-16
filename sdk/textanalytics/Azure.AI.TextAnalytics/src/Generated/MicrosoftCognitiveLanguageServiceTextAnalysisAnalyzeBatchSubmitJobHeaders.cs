// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    internal partial class MicrosoftCognitiveLanguageServiceTextAnalysisAnalyzeBatchSubmitJobHeaders
    {
        private readonly Response _response;
        public MicrosoftCognitiveLanguageServiceTextAnalysisAnalyzeBatchSubmitJobHeaders(Response response)
        {
            _response = response;
        }
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
