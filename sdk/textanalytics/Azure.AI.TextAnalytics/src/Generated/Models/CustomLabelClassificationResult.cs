// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The CustomLabelClassificationResult. </summary>
    internal partial class CustomLabelClassificationResult : CustomResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomLabelClassificationResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <param name="documents"> Response by document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/>, <paramref name="projectName"/>, <paramref name="deploymentName"/> or <paramref name="documents"/> is null. </exception>
        public CustomLabelClassificationResult(IEnumerable<DocumentError> errors, string projectName, string deploymentName, IEnumerable<CustomLabelClassificationResultDocumentsItem> documents) : base(errors, projectName, deploymentName)
        {
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(documents, nameof(documents));

            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CustomLabelClassificationResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <param name="documents"> Response by document. </param>
        internal CustomLabelClassificationResult(IList<DocumentError> errors, TextDocumentBatchStatistics statistics, string projectName, string deploymentName, IList<CustomLabelClassificationResultDocumentsItem> documents) : base(errors, statistics, projectName, deploymentName)
        {
            Documents = documents;
        }

        /// <summary> Response by document. </summary>
        public IList<CustomLabelClassificationResultDocumentsItem> Documents { get; }
    }
}
